// UpdateSeason.cs
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyLab2;
namespace MyLab2.Pages
{
    public partial class UpdateSeason : Form
    {
        public int SeasonId { get; set; }

        public UpdateSeason(int id, string name)
        {
            InitializeComponent();
            SeasonId = id;
            txtName.Text = name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = @"UPDATE Seasons 
                          SET Name = @name
                          WHERE Id = @id";

                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@id", SeasonId);
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