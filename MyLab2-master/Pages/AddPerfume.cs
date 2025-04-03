using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLab2.Pages
{
    public partial class AddPerfume : Form
    {
        public int BrandId { get; set; }

        public AddPerfume()
        {
            InitializeComponent();
        }

        private void AddPerfume_Load(object sender, EventArgs e)
        {
            LoadBrands();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dynamic selectedItem = cbBrand.SelectedItem;
            int brandId = selectedItem.Value;

            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = @"INSERT INTO Perfumes (Name, BrandId, Season, Description) 
                          VALUES (@Name, @BrandId, @Season, @Description)";

                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Name", txtPerfumeName.Text);
                cmd.Parameters.AddWithValue("@BrandId", brandId);
                cmd.Parameters.AddWithValue("@Season", cbSeason.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Description", "");
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