namespace datagrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_latest = new System.Windows.Forms.Label();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.tb_latest = new System.Windows.Forms.TextBox();
            this.lb_add = new System.Windows.Forms.Label();
            this.gb_toolbox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_editNames = new System.Windows.Forms.Button();
            this.cb_manualAdd = new System.Windows.Forms.CheckBox();
            this.lb_names = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbb_add_names = new System.Windows.Forms.ComboBox();
            this.tb_add_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_day = new System.Windows.Forms.Label();
            this.cb_days = new System.Windows.Forms.ComboBox();
            this.cb_manualsearch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ipiresiesResult = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_ipiresies = new System.Windows.Forms.Label();
            this.tb_search_name = new System.Windows.Forms.TextBox();
            this.lb_search = new System.Windows.Forms.Label();
            this.cbb_search_days = new System.Windows.Forms.ComboBox();
            this.btn_addRow = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cb_reset = new System.Windows.Forms.CheckBox();
            this.gb_notes = new System.Windows.Forms.GroupBox();
            this.tb_notes = new System.Windows.Forms.RichTextBox();
            this.cb_showNotes = new System.Windows.Forms.CheckBox();
            this.btn_SaveNotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_toolbox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_notes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(287, 54);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(710, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Δευτέρα";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Τρίτη";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Τετάρτη";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Πέμπτη";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Παρασκευή";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Σάββατο";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Κυριακή";
            this.Column7.Name = "Column7";
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(421, 11);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(88, 13);
            this.lb_start.TabIndex = 1;
            this.lb_start.Text = "Πρώτη εγγραφή";
            // 
            // lb_latest
            // 
            this.lb_latest.AutoSize = true;
            this.lb_latest.Location = new System.Drawing.Point(567, 11);
            this.lb_latest.Name = "lb_latest";
            this.lb_latest.Size = new System.Drawing.Size(107, 13);
            this.lb_latest.TabIndex = 1;
            this.lb_latest.Text = "Τελευταία εγγραφή";
            // 
            // tb_start
            // 
            this.tb_start.Location = new System.Drawing.Point(424, 26);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(134, 20);
            this.tb_start.TabIndex = 2;
            // 
            // tb_latest
            // 
            this.tb_latest.Location = new System.Drawing.Point(570, 26);
            this.tb_latest.Name = "tb_latest";
            this.tb_latest.Size = new System.Drawing.Size(134, 20);
            this.tb_latest.TabIndex = 2;
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Location = new System.Drawing.Point(6, 8);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(56, 13);
            this.lb_add.TabIndex = 3;
            this.lb_add.Text = "Προσθήκη";
            // 
            // gb_toolbox
            // 
            this.gb_toolbox.Controls.Add(this.groupBox3);
            this.gb_toolbox.Controls.Add(this.groupBox1);
            this.gb_toolbox.Controls.Add(this.groupBox2);
            this.gb_toolbox.Location = new System.Drawing.Point(10, 12);
            this.gb_toolbox.Name = "gb_toolbox";
            this.gb_toolbox.Size = new System.Drawing.Size(271, 512);
            this.gb_toolbox.TabIndex = 4;
            this.gb_toolbox.TabStop = false;
            this.gb_toolbox.Text = "Επιλογές";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(7, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 172);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Συνολικές Υπηρεσίες";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_editNames);
            this.groupBox1.Controls.Add(this.cb_manualAdd);
            this.groupBox1.Controls.Add(this.lb_names);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.cbb_add_names);
            this.groupBox1.Controls.Add(this.tb_add_name);
            this.groupBox1.Controls.Add(this.lb_add);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_editNames
            // 
            this.btn_editNames.Location = new System.Drawing.Point(166, 48);
            this.btn_editNames.Name = "btn_editNames";
            this.btn_editNames.Size = new System.Drawing.Size(86, 47);
            this.btn_editNames.TabIndex = 14;
            this.btn_editNames.Text = "Επεξεργασία \r\nονομάτων";
            this.btn_editNames.UseVisualStyleBackColor = true;
            this.btn_editNames.Click += new System.EventHandler(this.btn_editNames_Click);
            // 
            // cb_manualAdd
            // 
            this.cb_manualAdd.AutoSize = true;
            this.cb_manualAdd.Location = new System.Drawing.Point(75, 9);
            this.cb_manualAdd.Name = "cb_manualAdd";
            this.cb_manualAdd.Size = new System.Drawing.Size(86, 17);
            this.cb_manualAdd.TabIndex = 13;
            this.cb_manualAdd.Text = "Χειροκίνητο";
            this.cb_manualAdd.UseVisualStyleBackColor = true;
            this.cb_manualAdd.CheckedChanged += new System.EventHandler(this.cb_manualAdd_CheckedChanged);
            // 
            // lb_names
            // 
            this.lb_names.AutoSize = true;
            this.lb_names.Location = new System.Drawing.Point(6, 32);
            this.lb_names.Name = "lb_names";
            this.lb_names.Size = new System.Drawing.Size(90, 13);
            this.lb_names.TabIndex = 10;
            this.lb_names.Text = "Ονοματεπώνυμα";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 101);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Προσθήκη";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbb_add_names
            // 
            this.cbb_add_names.FormattingEnabled = true;
            this.cbb_add_names.Location = new System.Drawing.Point(6, 48);
            this.cbb_add_names.Name = "cbb_add_names";
            this.cbb_add_names.Size = new System.Drawing.Size(147, 21);
            this.cbb_add_names.TabIndex = 4;
            // 
            // tb_add_name
            // 
            this.tb_add_name.Location = new System.Drawing.Point(6, 75);
            this.tb_add_name.Name = "tb_add_name";
            this.tb_add_name.Size = new System.Drawing.Size(147, 20);
            this.tb_add_name.TabIndex = 5;
            this.tb_add_name.TextChanged += new System.EventHandler(this.tb_add_name_TextChanged);
            this.tb_add_name.Enter += new System.EventHandler(this.tb_add_name_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_day);
            this.groupBox2.Controls.Add(this.cb_days);
            this.groupBox2.Controls.Add(this.cb_manualsearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lb_ipiresiesResult);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.lb_ipiresies);
            this.groupBox2.Controls.Add(this.tb_search_name);
            this.groupBox2.Controls.Add(this.lb_search);
            this.groupBox2.Controls.Add(this.cbb_search_days);
            this.groupBox2.Location = new System.Drawing.Point(6, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 169);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lb_day
            // 
            this.lb_day.AutoSize = true;
            this.lb_day.Location = new System.Drawing.Point(6, 106);
            this.lb_day.Name = "lb_day";
            this.lb_day.Size = new System.Drawing.Size(39, 13);
            this.lb_day.TabIndex = 14;
            this.lb_day.Text = "Ημέρα";
            // 
            // cb_days
            // 
            this.cb_days.FormattingEnabled = true;
            this.cb_days.Items.AddRange(new object[] {
            "Δευτέρα",
            "Τρίτη",
            "Τετάρτη",
            "Πέμπτη",
            "Παρασκευή",
            "Σάββατο",
            "Κυριακή"});
            this.cb_days.Location = new System.Drawing.Point(5, 122);
            this.cb_days.Name = "cb_days";
            this.cb_days.Size = new System.Drawing.Size(148, 21);
            this.cb_days.TabIndex = 13;
            // 
            // cb_manualsearch
            // 
            this.cb_manualsearch.AutoSize = true;
            this.cb_manualsearch.Location = new System.Drawing.Point(166, 47);
            this.cb_manualsearch.Name = "cb_manualsearch";
            this.cb_manualsearch.Size = new System.Drawing.Size(86, 17);
            this.cb_manualsearch.TabIndex = 12;
            this.cb_manualsearch.Text = "Χειροκίνητο";
            this.cb_manualsearch.UseVisualStyleBackColor = true;
            this.cb_manualsearch.CheckedChanged += new System.EventHandler(this.cb_manualsearch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ονοματεπώνυμα";
            // 
            // lb_ipiresiesResult
            // 
            this.lb_ipiresiesResult.AutoSize = true;
            this.lb_ipiresiesResult.Location = new System.Drawing.Point(113, 146);
            this.lb_ipiresiesResult.Name = "lb_ipiresiesResult";
            this.lb_ipiresiesResult.Size = new System.Drawing.Size(35, 13);
            this.lb_ipiresiesResult.TabIndex = 7;
            this.lb_ipiresiesResult.Text = "label1";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(167, 72);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Αναζήτηση";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lb_ipiresies
            // 
            this.lb_ipiresies.AutoSize = true;
            this.lb_ipiresies.Location = new System.Drawing.Point(6, 146);
            this.lb_ipiresies.Name = "lb_ipiresies";
            this.lb_ipiresies.Size = new System.Drawing.Size(103, 13);
            this.lb_ipiresies.TabIndex = 6;
            this.lb_ipiresies.Text = "Πλήθος υπηρεσιών:";
            // 
            // tb_search_name
            // 
            this.tb_search_name.Location = new System.Drawing.Point(7, 72);
            this.tb_search_name.Name = "tb_search_name";
            this.tb_search_name.Size = new System.Drawing.Size(142, 20);
            this.tb_search_name.TabIndex = 5;
            this.tb_search_name.TextChanged += new System.EventHandler(this.tb_search_name_TextChanged);
            this.tb_search_name.Enter += new System.EventHandler(this.tb_search_name_Enter);
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(98, 16);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(63, 13);
            this.lb_search.TabIndex = 3;
            this.lb_search.Text = "Αναζήτηση";
            // 
            // cbb_search_days
            // 
            this.cbb_search_days.FormattingEnabled = true;
            this.cbb_search_days.Location = new System.Drawing.Point(7, 47);
            this.cbb_search_days.Name = "cbb_search_days";
            this.cbb_search_days.Size = new System.Drawing.Size(141, 21);
            this.cbb_search_days.TabIndex = 4;
            // 
            // btn_addRow
            // 
            this.btn_addRow.Location = new System.Drawing.Point(287, 12);
            this.btn_addRow.Name = "btn_addRow";
            this.btn_addRow.Size = new System.Drawing.Size(131, 35);
            this.btn_addRow.TabIndex = 6;
            this.btn_addRow.Text = "Προσθήκη σειράς";
            this.btn_addRow.UseVisualStyleBackColor = true;
            this.btn_addRow.Click += new System.EventHandler(this.btn_addRow_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_Reset.ForeColor = System.Drawing.Color.Black;
            this.btn_Reset.Location = new System.Drawing.Point(868, 6);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(161, 23);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Επαναφορά";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cb_reset
            // 
            this.cb_reset.AutoSize = true;
            this.cb_reset.Location = new System.Drawing.Point(868, 31);
            this.cb_reset.Name = "cb_reset";
            this.cb_reset.Size = new System.Drawing.Size(164, 17);
            this.cb_reset.TabIndex = 8;
            this.cb_reset.Text = "Ενεργοποίηση επαναφοράς";
            this.cb_reset.UseVisualStyleBackColor = true;
            this.cb_reset.CheckedChanged += new System.EventHandler(this.cb_reset_CheckedChanged);
            // 
            // gb_notes
            // 
            this.gb_notes.Controls.Add(this.tb_notes);
            this.gb_notes.Location = new System.Drawing.Point(288, 360);
            this.gb_notes.Name = "gb_notes";
            this.gb_notes.Size = new System.Drawing.Size(744, 164);
            this.gb_notes.TabIndex = 9;
            this.gb_notes.TabStop = false;
            this.gb_notes.Text = "Σημειώσεις";
            // 
            // tb_notes
            // 
            this.tb_notes.Location = new System.Drawing.Point(7, 20);
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.Size = new System.Drawing.Size(731, 138);
            this.tb_notes.TabIndex = 0;
            this.tb_notes.Text = "";
            // 
            // cb_showNotes
            // 
            this.cb_showNotes.AutoSize = true;
            this.cb_showNotes.Location = new System.Drawing.Point(288, 337);
            this.cb_showNotes.Name = "cb_showNotes";
            this.cb_showNotes.Size = new System.Drawing.Size(141, 17);
            this.cb_showNotes.TabIndex = 10;
            this.cb_showNotes.Text = "Εμφάνιση σημειώσεων";
            this.cb_showNotes.UseVisualStyleBackColor = true;
            this.cb_showNotes.CheckedChanged += new System.EventHandler(this.cb_showNotes_CheckedChanged);
            // 
            // btn_SaveNotes
            // 
            this.btn_SaveNotes.Location = new System.Drawing.Point(868, 337);
            this.btn_SaveNotes.Name = "btn_SaveNotes";
            this.btn_SaveNotes.Size = new System.Drawing.Size(164, 23);
            this.btn_SaveNotes.TabIndex = 11;
            this.btn_SaveNotes.Text = "Αποθήκευση σημειώσεων";
            this.btn_SaveNotes.UseVisualStyleBackColor = true;
            this.btn_SaveNotes.Click += new System.EventHandler(this.btn_SaveNotes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 531);
            this.Controls.Add(this.btn_SaveNotes);
            this.Controls.Add(this.cb_showNotes);
            this.Controls.Add(this.gb_notes);
            this.Controls.Add(this.cb_reset);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_addRow);
            this.Controls.Add(this.tb_latest);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.lb_latest);
            this.Controls.Add(this.lb_start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_toolbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_toolbox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_notes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_latest;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.TextBox tb_latest;
        private System.Windows.Forms.Label lb_add;
        private System.Windows.Forms.GroupBox gb_toolbox;
        private System.Windows.Forms.TextBox tb_add_name;
        private System.Windows.Forms.ComboBox cbb_add_names;
        private System.Windows.Forms.TextBox tb_search_name;
        private System.Windows.Forms.ComboBox cbb_search_days;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label lb_ipiresies;
        private System.Windows.Forms.Label lb_ipiresiesResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_addRow;
        private System.Windows.Forms.Label lb_names;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_manualsearch;
        private System.Windows.Forms.CheckBox cb_manualAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.CheckBox cb_reset;
        private System.Windows.Forms.Label lb_day;
        private System.Windows.Forms.ComboBox cb_days;
        private System.Windows.Forms.GroupBox gb_notes;
        private System.Windows.Forms.RichTextBox tb_notes;
        private System.Windows.Forms.CheckBox cb_showNotes;
        private System.Windows.Forms.Button btn_SaveNotes;
        private System.Windows.Forms.Button btn_editNames;
    }
}

