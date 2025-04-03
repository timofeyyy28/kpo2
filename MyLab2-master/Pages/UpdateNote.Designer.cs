// UpdateNote.Designer.cs
namespace MyLab2.Pages
{
    partial class UpdateNote
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
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
            this.lblName.Size = new System.Drawing.Size(103, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Название ноты:";

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(200, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(300, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // cbType
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(150, 70);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 21);
            this.cbType.TabIndex = 4;

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(69, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Тип ноты:";

            // UpdateNote
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "UpdateNote";
            this.Text = "Редактировать ноту";
            this.Load += new System.EventHandler(this.UpdateNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
    }
}