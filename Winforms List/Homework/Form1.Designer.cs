namespace HomeWork
{
    partial class Form1
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
            this.Panel = new System.Windows.Forms.Panel();
            this.Edit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.maashText = new System.Windows.Forms.TextBox();
            this.vezifeText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.soyadText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridRow = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VezifeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaashCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRow)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Gold;
            this.Panel.Controls.Add(this.Edit);
            this.Panel.Controls.Add(this.btnAdd);
            this.Panel.Controls.Add(this.maashText);
            this.Panel.Controls.Add(this.vezifeText);
            this.Panel.Controls.Add(this.emailText);
            this.Panel.Controls.Add(this.soyadText);
            this.Panel.Controls.Add(this.label5);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.nameText);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Location = new System.Drawing.Point(2, 36);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(263, 402);
            this.Panel.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Edit.Location = new System.Drawing.Point(42, 275);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(82, 36);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Yenile";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(160, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Elave Et";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // maashText
            // 
            this.maashText.Location = new System.Drawing.Point(88, 220);
            this.maashText.Name = "maashText";
            this.maashText.Size = new System.Drawing.Size(120, 20);
            this.maashText.TabIndex = 9;
            this.maashText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaashText_KeyPress);
            // 
            // vezifeText
            // 
            this.vezifeText.Location = new System.Drawing.Point(88, 173);
            this.vezifeText.Name = "vezifeText";
            this.vezifeText.Size = new System.Drawing.Size(120, 20);
            this.vezifeText.TabIndex = 8;
            this.vezifeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VezifeText_KeyPress);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(88, 124);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(120, 20);
            this.emailText.TabIndex = 7;
           
            // 
            // soyadText
            // 
            this.soyadText.Location = new System.Drawing.Point(88, 79);
            this.soyadText.Name = "soyadText";
            this.soyadText.Size = new System.Drawing.Size(120, 20);
            this.soyadText.TabIndex = 6;
            this.soyadText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoyadText_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vezife";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // nameText
            // 
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameText.Location = new System.Drawing.Point(88, 34);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(120, 20);
            this.nameText.TabIndex = 1;
            this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // GridRow
            // 
            this.GridRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.nameCol,
            this.SurnameCol,
            this.EmailCol,
            this.VezifeCol,
            this.MaashCol});
            this.GridRow.Location = new System.Drawing.Point(271, 36);
            this.GridRow.Name = "GridRow";
            this.GridRow.Size = new System.Drawing.Size(530, 402);
            this.GridRow.TabIndex = 1;
            this.GridRow.DoubleClick += new System.EventHandler(this.GridRow_DoubleClick);
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "ID";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // SurnameCol
            // 
            this.SurnameCol.HeaderText = "SurName";
            this.SurnameCol.Name = "SurnameCol";
            this.SurnameCol.ReadOnly = true;
            // 
            // EmailCol
            // 
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            // 
            // VezifeCol
            // 
            this.VezifeCol.HeaderText = "Vezife";
            this.VezifeCol.Name = "VezifeCol";
            this.VezifeCol.ReadOnly = true;
            // 
            // MaashCol
            // 
            this.MaashCol.HeaderText = "Maash";
            this.MaashCol.Name = "MaashCol";
            this.MaashCol.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(671, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.GridRow);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vezifeText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox soyadText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maashText;
        private System.Windows.Forms.DataGridView GridRow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VezifeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaashCol;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Edit;
    }
}

