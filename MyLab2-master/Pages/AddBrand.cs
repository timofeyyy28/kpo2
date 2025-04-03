using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyLab2;
namespace MyLab2.Pages
{
    public partial class AddBrand : Form
    {
        public static string BrandName = "";

        public AddBrand()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandName = txtBrandName.Text;

            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = @"INSERT INTO Brands (Name) VALUES (@name);";

                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", txtBrandName.Text);
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        void CheckFields()
        {
            btnAdd.Enabled = !string.IsNullOrWhiteSpace(txtBrandName.Text);
        }

        private void txtBrandName_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void AddBrand_Load(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}