namespace datagrid
{
    partial class EditNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNames));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_Insert = new System.Windows.Forms.TextBox();
            this.pb_Insert = new System.Windows.Forms.PictureBox();
            this.lb_Lastname = new System.Windows.Forms.Label();
            this.pb_Delete = new System.Windows.Forms.PictureBox();
            this.lb_Delete = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_Save = new System.Windows.Forms.Label();
            this.pb_Save = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Insert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Save)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 0;
            // 
            // tb_Insert
            // 
            this.tb_Insert.Location = new System.Drawing.Point(47, 39);
            this.tb_Insert.Name = "tb_Insert";
            this.tb_Insert.Size = new System.Drawing.Size(135, 20);
            this.tb_Insert.TabIndex = 1;
            this.tb_Insert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Insert_KeyDown);
            // 
            // pb_Insert
            // 
            this.pb_Insert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_Insert.Image = ((System.Drawing.Image)(resources.GetObject("pb_Insert.Image")));
            this.pb_Insert.Location = new System.Drawing.Point(6, 23);
            this.pb_Insert.Name = "pb_Insert";
            this.pb_Insert.Size = new System.Drawing.Size(32, 36);
            this.pb_Insert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Insert.TabIndex = 2;
            this.pb_Insert.TabStop = false;
            this.pb_Insert.Click += new System.EventHandler(this.pb_Insert_Click);
            //this.pb_Insert.MouseHover += new System.EventHandler(this.SetBackColor);
            //this.pb_Insert.MouseLeave += new System.EventHandler(this.RemoveBackColor);
            // 
            // lb_Lastname
            // 
            this.lb_Lastname.AutoSize = true;
            this.lb_Lastname.Location = new System.Drawing.Point(44, 23);
            this.lb_Lastname.Name = "lb_Lastname";
            this.lb_Lastname.Size = new System.Drawing.Size(104, 13);
            this.lb_Lastname.TabIndex = 4;
            this.lb_Lastname.Text = "Εισαγωγή επιθέτου";
            // 
            // pb_Delete
            // 
            this.pb_Delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb_Delete.Image = ((System.Drawing.Image)(resources.GetObject("pb_Delete.Image")));
            this.pb_Delete.Location = new System.Drawing.Point(6, 19);
            this.pb_Delete.Name = "pb_Delete";
            this.pb_Delete.Size = new System.Drawing.Size(32, 36);
            this.pb_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Delete.TabIndex = 6;
            this.pb_Delete.TabStop = false;
            this.pb_Delete.Click += new System.EventHandler(this.pb_Delete_Click);
            //this.pb_Delete.MouseHover += new System.EventHandler(this.SetBackColor);
            //this.pb_Delete.MouseLeave += new System.EventHandler(this.RemoveBackColor);
            // 
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.Location = new System.Drawing.Point(44, 23);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(127, 26);
            this.lb_Delete.TabIndex = 7;
            this.lb_Delete.Text = "Διαγραφή επιλεγμένων \r\nστοιχείων";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Λίστα ονομάτων";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pb_Insert);
            this.groupBox1.Controls.Add(this.tb_Insert);
            this.groupBox1.Controls.Add(this.lb_Lastname);
            this.groupBox1.Location = new System.Drawing.Point(141, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Μενού επεξεργασίας";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_Save);
            this.groupBox2.Controls.Add(this.pb_Delete);
            this.groupBox2.Controls.Add(this.pb_Save);
            this.groupBox2.Controls.Add(this.lb_Delete);
            this.groupBox2.Location = new System.Drawing.Point(6, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Επιλογές...";
            // 
            // lb_Save
            // 
            this.lb_Save.AutoSize = true;
            this.lb_Save.Location = new System.Drawing.Point(44, 72);
            this.lb_Save.Name = "lb_Save";
            this.lb_Save.Size = new System.Drawing.Size(115, 13);
            this.lb_Save.TabIndex = 11;
            this.lb_Save.Text = "Αποθήκευση αλλαγών";
            // 
            // pb_Save
            // 
            this.pb_Save.Image = ((System.Drawing.Image)(resources.GetObject("pb_Save.Image")));
            this.pb_Save.Location = new System.Drawing.Point(6, 63);
            this.pb_Save.Name = "pb_Save";
            this.pb_Save.Size = new System.Drawing.Size(32, 31);
            this.pb_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Save.TabIndex = 10;
            this.pb_Save.TabStop = false;
            this.pb_Save.Click += new System.EventHandler(this.pb_Save_Click);
            //this.pb_Save.MouseHover += new System.EventHandler(this.SetBackColor);
            //this.pb_Save.MouseLeave += new System.EventHandler(this.RemoveBackColor);
            // 
            // EditNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 248);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditNames";
            this.Text = "EditNames";
            this.Load += new System.EventHandler(this.EditNames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Insert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Save)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_Insert;
        private System.Windows.Forms.PictureBox pb_Insert;
        private System.Windows.Forms.Label lb_Lastname;
        private System.Windows.Forms.PictureBox pb_Delete;
        private System.Windows.Forms.Label lb_Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Save;
        private System.Windows.Forms.PictureBox pb_Save;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}