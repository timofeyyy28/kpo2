using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLab2.Pages
{
    public partial class UpdatePerfume : Form
    {
        public int PerfumeId { get; set; }

        public UpdatePerfume(int id, string name, int brandId, string season)
        {
            InitializeComponent();
            PerfumeId = id;
            txtName.Text = name;
            LoadBrands();

            // Установка выбранного бренда
            foreach (dynamic item in cbBrand.Items)
            {
                if (item.Value == brandId)
                {
                    cbBrand.SelectedItem = item;
                    break;
                }
            }

            cbSeason.SelectedItem = season;
        }

        private void LoadBrands()
        {
            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = "SELECT Id, Name FROM Brands";
                var cmd = new SqlCommand(sql, cn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbBrand.Items.Add(new
                    {
                        Text = reader["Name"].ToString(),
                        Value = Convert.ToInt32(reader["Id"])
                    });
                }
                cbBrand.DisplayMember = "Text";
                cbBrand.ValueMember = "Value";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dynamic brandItem = cbBrand.SelectedItem;
            int brandId = brandItem.Value;

            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = @"UPDATE Perfumes 
                          SET Name = @name, 
                              BrandId = @brandId, 
                              Season = @season
                          WHERE Id = @id";

                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@brandId", brandId);
                cmd.Parameters.AddWithValue("@season", cbSeason.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@id", PerfumeId);
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
    }
}