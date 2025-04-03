// UpdatePerfume.Designer.cs
namespace MyLab2.Pages
{
    partial class UpdatePerfume
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(150, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Название парфюма:";

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(200, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(300, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // cbBrand
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(150, 70);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(200, 21);
            this.cbBrand.TabIndex = 4;

            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(30, 73);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 13);
            this.lblBrand.TabIndex = 5;
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
            this.cbSeason.Location = new System.Drawing.Point(150, 110);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(200, 21);
            this.cbSeason.TabIndex = 6;

            // lblSeason
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(30, 113);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(46, 13);
            this.lblSeason.TabIndex = 7;
            this.lblSeason.Text = "Сезон:";

            // UpdatePerfume
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.cbSeason);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "UpdatePerfume";
            this.Text = "Редактировать парфюм";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cbSeason;
        private System.Windows.Forms.Label lblSeason;
    }
}