namespace studentAndEmployee
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.sex = new System.Windows.Forms.GroupBox();
            this.radFamle = new System.Windows.Forms.RadioButton();
            this.groupShow = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.groupCommit = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sex.SuspendLayout();
            this.groupShow.SuspendLayout();
            this.groupCommit.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(235, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 24);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الطالب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "المستوى";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(147, 34);
            this.radMale.Name = "radMale";
            this.radMale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radMale.Size = new System.Drawing.Size(46, 21);
            this.radMale.TabIndex = 5;
            this.radMale.TabStop = true;
            this.radMale.Text = "ذكر";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // sex
            // 
            this.sex.Controls.Add(this.radFamle);
            this.sex.Controls.Add(this.radMale);
            this.sex.Location = new System.Drawing.Point(54, 85);
            this.sex.Name = "sex";
            this.sex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sex.Size = new System.Drawing.Size(226, 78);
            this.sex.TabIndex = 6;
            this.sex.TabStop = false;
            this.sex.Text = "الجنس";
            // 
            // radFamle
            // 
            this.radFamle.AutoSize = true;
            this.radFamle.Location = new System.Drawing.Point(51, 34);
            this.radFamle.Name = "radFamle";
            this.radFamle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radFamle.Size = new System.Drawing.Size(52, 21);
            this.radFamle.TabIndex = 6;
            this.radFamle.TabStop = true;
            this.radFamle.Text = "انثى";
            this.radFamle.UseVisualStyleBackColor = true;
            // 
            // groupShow
            // 
            this.groupShow.Controls.Add(this.button3);
            this.groupShow.Controls.Add(this.btnBack);
            this.groupShow.Controls.Add(this.tnDelete);
            this.groupShow.Controls.Add(this.button2);
            this.groupShow.Controls.Add(this.btnEdit);
            this.groupShow.Controls.Add(this.button1);
            this.groupShow.Controls.Add(this.btnAdd);
            this.groupShow.Controls.Add(this.btn_first);
            this.groupShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupShow.Location = new System.Drawing.Point(40, 187);
            this.groupShow.Name = "groupShow";
            this.groupShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupShow.Size = new System.Drawing.Size(467, 152);
            this.groupShow.TabIndex = 7;
            this.groupShow.TabStop = false;
            this.groupShow.Text = "ازرار العرض";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(41, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "الاخير";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(41, 93);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "عودة";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // tnDelete
            // 
            this.tnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.tnDelete.FlatAppearance.BorderSize = 2;
            this.tnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tnDelete.Location = new System.Drawing.Point(152, 93);
            this.tnDelete.Name = "tnDelete";
            this.tnDelete.Size = new System.Drawing.Size(80, 35);
            this.tnDelete.TabIndex = 0;
            this.tnDelete.Text = "حذف";
            this.tnDelete.UseVisualStyleBackColor = true;
            this.tnDelete.Click += new System.EventHandler(this.TnDelete_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(152, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "التالي";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(263, 93);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 35);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(263, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "السابق";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(374, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btn_first
            // 
            this.btn_first.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_first.FlatAppearance.BorderSize = 2;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_first.Location = new System.Drawing.Point(374, 35);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(74, 35);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "الاول";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.Btn_first_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.BackColor = System.Drawing.Color.Silver;
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(28, 37);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(95, 24);
            this.cmbLevel.TabIndex = 1;
            // 
            // groupCommit
            // 
            this.groupCommit.Controls.Add(this.btncancel);
            this.groupCommit.Controls.Add(this.btnSave);
            this.groupCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCommit.Location = new System.Drawing.Point(40, 349);
            this.groupCommit.Name = "groupCommit";
            this.groupCommit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupCommit.Size = new System.Drawing.Size(467, 94);
            this.groupCommit.TabIndex = 8;
            this.groupCommit.TabStop = false;
            this.groupCommit.Text = "ازرار التحديث";
            // 
            // btncancel
            // 
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btncancel.FlatAppearance.BorderSize = 2;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncancel.Location = new System.Drawing.Point(62, 40);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(127, 35);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "تراجع";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(328, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(536, 490);
            this.Controls.Add(this.groupCommit);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.groupShow);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.sex.ResumeLayout(false);
            this.sex.PerformLayout();
            this.groupShow.ResumeLayout(false);
            this.groupCommit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox sex;
        private System.Windows.Forms.RadioButton radFamle;
        private System.Windows.Forms.GroupBox groupShow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button tnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.GroupBox groupCommit;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnSave;
    }
}