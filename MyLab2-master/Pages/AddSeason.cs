using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyLab2;
namespace MyLab2.Pages
{
    public partial class AddSeason : Form
    {
        public AddSeason()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = @"INSERT INTO Seasons (Name) VALUES (@name);";

                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", txtSeasonName.Text);
                cmd.ExecuteNonQuery();

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        void CheckFields()
        {
            btnAdd.Enabled = !string.IsNullOrWhiteSpace(txtSeasonName.Text);
        }

        private void txtSeasonName_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void AddSeason_Load(object sender, EventArgs e)
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