using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace datagrid {

    public partial class EditNames : Form {

        //<Constructors>
        public EditNames() {
            InitializeComponent();
        }
        public EditNames(string _names) {
            InitializeComponent();
            NamesPath = _names;
        }
        //</constructors>

        private string names;
        private string NamesPath { get => names; set => names = value; }

        string _iconDir = Directory.GetCurrentDirectory() + "/res/icon.ico";

        private void EditNames_Load(object sender, EventArgs e) {
            /*
            needless for FormBorderStyle = FixedToolWindow
             * 
            Bitmap b = (Bitmap)Image.FromFile(_iconDir);
            IntPtr pIcon = b.GetHicon();
            Icon z = Icon.FromHandle(pIcon);
            Icon = z;
            */

            pb_Insert.BackColor = Color.Transparent;
            pb_Delete.BackColor = Color.Transparent;
            InitListBox();
        }


        private void pb_Insert_Click(object sender, EventArgs e) {
            if (!listBox1.Items.Contains(tb_Insert.Text))
                listBox1.Items.Add(tb_Insert.Text);
        }
        private void pb_Save_Click(object sender, EventArgs e) {
            UserConfirm();
        }

        private string GetNames() {
            string a = "";
            if (!File.Exists(NamesPath))
                return a;
            else
            {
                StreamReader reader = new StreamReader(NamesPath);
                a = reader.ReadToEnd();
                reader.Close();
                return a;
            }
        }
        private void SaveNames() {
            string _names = "[";
            foreach (object item in listBox1.Items)
            {
                _names += item + ",";
            }
            _names = _names.Remove(_names.Length - 1, 1);
            _names += "]";
            StreamWriter writer = new StreamWriter(NamesPath);
            writer.Write(_names);
            writer.Close();
        }
        private void InitListBox() {
            string _names = GetNames();
            if (_names == "")
                return;
            else
            {
                _names = _names.Trim(' ', '[', ']');
                char[] delim = { ',' };
                foreach (string item in _names.Split(delim, StringSplitOptions.RemoveEmptyEntries))
                    listBox1.Items.Add(item);
            }
        }
        private void UserConfirm() {
            DialogResult = MessageBox.Show("" +
                   "You are about to save your changes in the Names List.\n" +
                   "Do you want to proceed?",
                   "Save changes...",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.No)
                return;
            else
                if (DialogResult == DialogResult.Yes)
            {
                SaveNames();
                MessageBox.Show("Your changes have been saved.",
                    "Save changes...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void pb_Delete_Click(object sender, EventArgs e) {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
        }

        private void tb_Insert_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode.ToString() == "Return")
            {
                pb_Insert_Click(sender, e);
                tb_Insert.Text = "";
                e.SuppressKeyPress = true;
            }
        }/*
        private void SetBackColor(object sender,EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromName("ControlLight");
        }

        private void RemoveBackColor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromName("Transparent");
        }
        */
    }
}
