using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyLab2.Pages;


namespace MyLab2
{
    public partial class Form1 : Form
    {
        public static string ConnectionString =
    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=C:\Temp\PerfumeShopDB.mdf;
      Integrated Security=True;
      Connect Timeout=30"; 


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadBrands();
            treeView1.SelectedNode = null;
        }

        public void LoadBrands()
        {
            treeView1.Nodes.Clear();
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                var sql = "SELECT * FROM Brands";
                var cmd = new SqlCommand(sql, cn);

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TreeNode brandNode = new TreeNode(dr["Name"].ToString());
                    brandNode.Tag = dr["Id"];
                    brandNode.Name = dr["Name"].ToString();
                    treeView1.Nodes.Add(brandNode);
                    LoadPerfumes((int)dr["Id"], brandNode);
                }
            }
        }

        public void LoadPerfumes(int brandId, TreeNode parent)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                var sql = @"SELECT Id, Name FROM Perfumes
                          WHERE BrandId = @brandId";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@brandId", brandId);

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TreeNode perfumeNode = new TreeNode(dr["Name"].ToString());
                    perfumeNode.Tag = dr["Id"];
                    parent.Nodes.Add(perfumeNode);
                    LoadNotes((int)dr["Id"], perfumeNode);
                }
            }
        }

        public void LoadNotes(int perfumeId, TreeNode parent)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                var sql = @"SELECT n.Id, n.Name, pn.NoteType 
                          FROM Notes n
                          JOIN PerfumeNotes pn ON n.Id = pn.NoteId
                          WHERE pn.PerfumeId = @perfumeId";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@perfumeId", perfumeId);

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TreeNode noteNode = new TreeNode($"{dr["Name"]} ({dr["NoteType"]})");
                    noteNode.Tag = dr["Id"];
                    parent.Nodes.Add(noteNode);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            try
            {
                using (var cn = new SqlConnection(ConnectionString))
                {
                    cn.Open();
                    string sql = "";
                    string confirmMessage = "";

                    switch (treeView1.SelectedNode.Level)
                    {
                        case 0: // Бренд
                            sql = "DELETE FROM Brands WHERE Id = @id";
                            confirmMessage = "Удалить этот бренд и все связанные парфюмы?";
                            break;
                        case 1: // Парфюм
                            sql = "DELETE FROM Perfumes WHERE Id = @id";
                            confirmMessage = "Удалить этот парфюм и все связанные ноты?";
                            break;
                        case 2: // Нота
                            sql = "DELETE FROM PerfumeNotes WHERE NoteId = @id";
                            confirmMessage = "Удалить эту ноту из парфюма?";
                            break;
                    }

                    if (MessageBox.Show(confirmMessage, "Подтверждение",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                        cmd.ExecuteNonQuery();
                        treeView1.SelectedNode.Remove();
                        LoadBrands();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            switch (treeView1.SelectedNode.Level)
            {
                case 0: // Добавление парфюма к бренду
                    AddPerfume addPerfume = new AddPerfume();
                    addPerfume.BrandId = (int)treeView1.SelectedNode.Tag;
                    if (addPerfume.ShowDialog() == DialogResult.OK)
                        LoadBrands();
                    break;

                case 1: // Добавление ноты к парфюму
                    AddPerfumeNote addNote = new AddPerfumeNote();
                    addNote.PerfumeId = (int)treeView1.SelectedNode.Tag;
                    if (addNote.ShowDialog() == DialogResult.OK)
                        LoadBrands();
                    break;
            }
        }

        private void addBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            if (addBrand.ShowDialog() == DialogResult.OK)
            {
                LoadBrands();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            switch (treeView1.SelectedNode.Level)
            {
                case 0: // Редактирование бренда
                    UpdateBrand updateBrand = new UpdateBrand(
                        (int)treeView1.SelectedNode.Tag,
                        treeView1.SelectedNode.Text);
                    if (updateBrand.ShowDialog() == DialogResult.OK)
                        LoadBrands();
                    break;

                case 1: // Редактирование парфюма
                    // Здесь нужно получить полные данные о парфюме из БД
                    UpdatePerfume updatePerfume = new UpdatePerfume(
                        (int)treeView1.SelectedNode.Tag,
                        treeView1.SelectedNode.Text,
                        0, ""); // Замените на реальные параметры
                    if (updatePerfume.ShowDialog() == DialogResult.OK)
                        LoadBrands();
                    break;

                case 2: // Редактирование ноты
                    // Здесь нужно получить полные данные о ноте из БД
                    UpdateNote updateNote = new UpdateNote(
                        (int)treeView1.SelectedNode.Tag,
                        treeView1.SelectedNode.Text.Split('(')[0].Trim(),
                        ""); // Замените на реальный тип ноты
                    if (updateNote.ShowDialog() == DialogResult.OK)
                        LoadBrands();
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                addBrandToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            }
            else
            {
                addBrandToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;

                // Включаем добавление только для брендов и парфюмов
                addToolStripMenuItem.Enabled = treeView1.SelectedNode.Level < 2;
            }
        }
    }
}