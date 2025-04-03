// UpdateBrand.cs
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyLab2;
namespace MyLab2.Pages
{
    public partial class UpdateBrand : Form
    {
        public int BrandId { get; set; }

        public UpdateBrand(int id, string name)
        {
            InitializeComponent();
            BrandId = id;
            txtName.Text = name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = @"UPDATE Brands 
                  SET Name = @name
                  WHERE Id = @id";

                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@id", BrandId);
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
