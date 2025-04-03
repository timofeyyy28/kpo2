using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLab2.Pages
{
    public partial class AddPerfumeNote : Form
    {
        public int PerfumeId { get; set; }

        public AddPerfumeNote()
        {
            InitializeComponent();
        }

        private void AddPerfumeNote_Load(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = "SELECT Id, Name FROM Notes ORDER BY Name";
                var cmd = new SqlCommand(sql, cn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbNote.Items.Add(new
                    {
                        Text = reader["Name"].ToString(),
                        Value = Convert.ToInt32(reader["Id"])
                    });
                }
                cbNote.DisplayMember = "Text";
                cbNote.ValueMember = "Value";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string noteType = rbTop.Checked ? "Top" :
                            rbMiddle.Checked ? "Middle" : "Base";

            dynamic selectedItem = cbNote.SelectedItem;
            int noteId = selectedItem.Value;

            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = @"INSERT INTO PerfumeNotes (PerfumeId, NoteId, NoteType) 
                          VALUES (@PerfumeId, @NoteId, @NoteType)";

                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@PerfumeId", PerfumeId);
                cmd.Parameters.AddWithValue("@NoteId", noteId);
                cmd.Parameters.AddWithValue("@NoteType", noteType);
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработка изменения выбора ноты
        }

        private void NoteType_CheckedChanged(object sender, EventArgs e)
        {
            // Обработка изменения типа ноты
        }
    }
}