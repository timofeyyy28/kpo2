// UpdateNote.cs
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyLab2;
namespace MyLab2.Pages
{
    public partial class UpdateNote : Form
    {
        public int NoteId { get; set; }

        public UpdateNote(int id, string name, string type)
        {
            InitializeComponent();
            NoteId = id;
            txtName.Text = name;
            cbType.SelectedItem = type;
        }

        private void UpdateNote_Load(object sender, EventArgs e)
        {
            cbType.Items.AddRange(new object[] { "Верхние", "Средние", "Базовые" });
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Form1.ConnectionString))
            {
                cn.Open();
                var sql = @"UPDATE Notes 
                  SET Name = @name, 
                      Type = @type
                  WHERE Id = @id";

                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@type", cbType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@id", NoteId);
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