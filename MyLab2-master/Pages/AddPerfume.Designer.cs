namespace MyLab2.Pages
{
    partial class AddPerfume
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPerfumeName = new System.Windows.Forms.TextBox();
            this.lblPerfumeName = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(300, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(200, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;

            // txtPerfumeName
            this.txtPerfumeName.Location = new System.Drawing.Point(150, 20);
            this.txtPerfumeName.Name = "txtPerfumeName";
            this.txtPerfumeName.Size = new System.Drawing.Size(200, 20);
            this.txtPerfumeName.TabIndex = 9;

            // lblPerfumeName
            this.lblPerfumeName.AutoSize = true;
            this.lblPerfumeName.Location = new System.Drawing.Point(30, 23);
            this.lblPerfumeName.Name = "lblPerfumeName";
            this.lblPerfumeName.Size = new System.Drawing.Size(114, 13);
            this.lblPerfumeName.TabIndex = 10;
            this.lblPerfumeName.Text = "Название парфюма:";

            // cbBrand
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(150, 50);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(200, 21);
            this.cbBrand.TabIndex = 11;

            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(30, 53);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 13);
            this.lblBrand.TabIndex = 12;
            this.lblBrand.Text = "Бренд:";

            // cbSeason
            this.cbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Items.AddRange(new object[] {
                "Весна",
                "Лето",
                "Осень",
                "Зима",
                "Универсальный"});
            this.cbSeason.Location = new System.Drawing.Point(150, 80);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(200, 21);
            this.cbSeason.TabIndex = 13;

            // lblSeason
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(30, 83);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(46, 13);
            this.lblSeason.TabIndex = 14;
            this.lblSeason.Text = "Сезон:";

            // AddPerfume
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.cbSeason);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.lblPerfumeName);
            this.Controls.Add(this.txtPerfumeName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddPerfume";
            this.Text = "Добавить парфюм";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPerfumeName;
        private System.Windows.Forms.Label lblPerfumeName;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cbSeason;
        private System.Windows.Forms.Label lblSeason;
    }
}