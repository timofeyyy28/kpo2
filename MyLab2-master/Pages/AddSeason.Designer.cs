namespace MyLab2.Pages
{
    partial class AddSeason
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSeasonName = new System.Windows.Forms.Label();
            this.txtSeasonName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblSeasonName
            this.lblSeasonName.AutoSize = true;
            this.lblSeasonName.Location = new System.Drawing.Point(30, 30);
            this.lblSeasonName.Name = "lblSeasonName";
            this.lblSeasonName.Size = new System.Drawing.Size(98, 13);
            this.lblSeasonName.TabIndex = 11;
            this.lblSeasonName.Text = "Название сезона:";

            // txtSeasonName
            this.txtSeasonName.Location = new System.Drawing.Point(150, 27);
            this.txtSeasonName.Name = "txtSeasonName";
            this.txtSeasonName.Size = new System.Drawing.Size(200, 20);
            this.txtSeasonName.TabIndex = 12;
            this.txtSeasonName.TextChanged += new System.EventHandler(this.txtSeasonName_TextChanged);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(200, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(300, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // AddSeason
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 120);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSeasonName);
            this.Controls.Add(this.lblSeasonName);
            this.Name = "AddSeason";
            this.Text = "Добавить сезон";
            this.Load += new System.EventHandler(this.AddSeason_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSeasonName;
        private System.Windows.Forms.TextBox txtSeasonName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}