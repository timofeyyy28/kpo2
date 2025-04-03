namespace MyLab2.Pages
{
    partial class AddPerfumeNote
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
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbNoteType = new System.Windows.Forms.GroupBox();
            this.rbBase = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.cbNote = new System.Windows.Forms.ComboBox();
            this.gbNoteType.SuspendLayout();
            this.rbTop.CheckedChanged += new System.EventHandler(this.NoteType_CheckedChanged);
            this.rbMiddle.CheckedChanged += new System.EventHandler(this.NoteType_CheckedChanged);
            this.rbBase.CheckedChanged += new System.EventHandler(this.NoteType_CheckedChanged);
            this.cbNote.SelectedIndexChanged += new System.EventHandler(this.cbNote_SelectedIndexChanged);
            this.SuspendLayout();

            // lblNote
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(30, 30);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(66, 13);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Выберите ноту:";

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(200, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(300, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // gbNoteType
            this.gbNoteType.Controls.Add(this.rbBase);
            this.gbNoteType.Controls.Add(this.rbMiddle);
            this.gbNoteType.Controls.Add(this.rbTop);
            this.gbNoteType.Location = new System.Drawing.Point(200, 60);
            this.gbNoteType.Name = "gbNoteType";
            this.gbNoteType.Size = new System.Drawing.Size(200, 100);
            this.gbNoteType.TabIndex = 7;
            this.gbNoteType.TabStop = false;
            this.gbNoteType.Text = "Тип ноты";

            // rbBase
            this.rbBase.AutoSize = true;
            this.rbBase.Location = new System.Drawing.Point(20, 70);
            this.rbBase.Name = "rbBase";
            this.rbBase.Size = new System.Drawing.Size(98, 17);
            this.rbBase.TabIndex = 2;
            this.rbBase.TabStop = true;
            this.rbBase.Text = "Базовые ноты";
            this.rbBase.UseVisualStyleBackColor = true;
            this.rbBase.CheckedChanged += new System.EventHandler(this.NoteType_CheckedChanged);

            // rbMiddle
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.Location = new System.Drawing.Point(20, 45);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(108, 17);
            this.rbMiddle.TabIndex = 1;
            this.rbMiddle.TabStop = true;
            this.rbMiddle.Text = "Средние ноты";
            this.rbMiddle.UseVisualStyleBackColor = true;
            this.rbMiddle.CheckedChanged += new System.EventHandler(this.NoteType_CheckedChanged);

            // rbTop
            this.rbTop.AutoSize = true;
            this.rbTop.Location = new System.Drawing.Point(20, 20);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(106, 17);
            this.rbTop.TabIndex = 0;
            this.rbTop.TabStop = true;
            this.rbTop.Text = "Верхние ноты";
            this.rbTop.UseVisualStyleBackColor = true;
            this.rbTop.CheckedChanged += new System.EventHandler(this.NoteType_CheckedChanged);

            // cbNote
            this.cbNote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNote.FormattingEnabled = true;
            this.cbNote.Location = new System.Drawing.Point(30, 50);
            this.cbNote.Name = "cbNote";
            this.cbNote.Size = new System.Drawing.Size(150, 21);
            this.cbNote.TabIndex = 8;
            this.cbNote.SelectedIndexChanged += new System.EventHandler(this.cbNote_SelectedIndexChanged);

            // AddPerfumeNote
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 221);
            this.Controls.Add(this.cbNote);
            this.Controls.Add(this.gbNoteType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNote);
            this.Name = "AddPerfumeNote";
            this.Text = "Добавить ноту парфюма";
            this.Load += new System.EventHandler(this.AddPerfumeNote_Load);
            this.gbNoteType.ResumeLayout(false);
            this.gbNoteType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbNoteType;
        private System.Windows.Forms.RadioButton rbBase;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.ComboBox cbNote;
    }
}