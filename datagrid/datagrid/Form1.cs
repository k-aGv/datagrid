using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace datagrid
{
    public partial class Form1 : Form
    {
        int viewMargin = 10;
        bool _reset;
        static string _disDir = Directory.GetCurrentDirectory();
        string _database = _disDir + "/res/_stamps/__TMPDBSTAMP";
        string _timeStampFirst = _disDir + "/res/_stamps/__TIMESTAMPF";
        string _timeStampCurrent = _disDir + "/res/_stamps/__TIMESTAMPCUR";
        string _camoDir = _disDir + "/res/camo.jpg";
        string _iconDir = _disDir + "/res/icon.ico";
        string _notesDB = _disDir + "/res/_stamps/__DBNOTES";
        string _names = _disDir + "/res/_stamps/__NAMES";
        int counterDuties = 0;

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "/res/_stamps"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/res/_stamps");
                DirectoryInfo dirinfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "/res/_stamps");
                dirinfo.Attributes = FileAttributes.Hidden;
                
            }
            WindowState = FormWindowState.Maximized;
            _reset = false;
        }
      
        private string GetNames()
        {
            string a;
            if (File.Exists(_names))
            {

                StreamReader reader = new StreamReader(_names);
                a = reader.ReadToEnd();
                reader.Close();
            }
            else
                a = "";
            return a;
        }
        private void InitGBSettingsNameControls()
        {
            string _names = GetNames();
            _names = _names.Replace('[', ' ');
            _names = _names.Replace(']', ' ');
            char[] delim = { ',' };

            foreach (string item in _names.Remove(0, 1).Split(delim, StringSplitOptions.RemoveEmptyEntries))
            {
                cbb_add_names.Items.Add(item);
                cbb_search_days.Items.Add(item);
            }
        }
        private void ClearGBSettingsNameControls()
        {
            cbb_add_names.Items.Clear();
            cbb_search_days.Items.Clear();
            listBox1.Items.Clear();
        }
        private void InitUI()
        {

            dataGridView1.Rows.Insert(0, "");
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;


            //MaximizeBox = false;
            string[] days = new string[]
            { "Δευτέρα", "Τρίτη", "Τετάρτη","Πέμπτη","Παρασκευή","Σάββατο","Κυριακή"};
            string names = GetNames();
            InitDB(days, names);
            if (names != "")
            {
                names = names.Replace('[', ' ');
                names = names.Replace(']', ' ');
                char[] delim = { ',' };

                foreach (string item in names.Remove(0, 1).Split(delim, StringSplitOptions.RemoveEmptyEntries))
                {
                    cbb_add_names.Items.Add(item);
                    cbb_search_days.Items.Add(item);
                }
            }
            int _w = 0;
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].HeaderText = days[i];
                dataGridView1.Columns[i].Width = 100;
                _w += dataGridView1.Columns[i].Width;
            }


            tb_latest.Enabled = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            lb_start.Font = lb_latest.Font =
            lb_add.Font =
                new Font
                (
                lb_add.Font,
                FontStyle.Underline | FontStyle.Bold
                );
            lb_search.Font =
               new Font
               (
               lb_search.Font,
               FontStyle.Underline | FontStyle.Bold
               );
            lb_ipiresiesResult.Text = "";
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;

            cbb_add_names.DropDownStyle = cbb_search_days.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_search_name.Visible = false;
            tb_add_name.Visible = false;
            cb_reset.Checked = false;
            cb_reset.Location = new Point(btn_Reset.Location.X - cb_reset.Width - viewMargin,
                                        cb_reset.Location.Y);
            btn_Reset.Text = "(Απενεργοποιημένο)";
            btn_Reset.Enabled = false;
            btn_Reset.BackColor = Color.LightGray;
            WindowState = FormWindowState.Normal;
            dataGridView1.Width = _w + 2 + dataGridView1.RowHeadersWidth;
            Width = dataGridView1.Location.X + dataGridView1.Width + 30;
            dataGridView1.Height = gb_toolbox.Height - btn_add.Height - 7 - viewMargin - gb_notes.Height - viewMargin - cb_showNotes.Height; //allign the bottom of DataGridView with the bottom of gb_toolbox
            //btn_Reset.Location.X = dataGridView1.Location.X - btn_Reset.Width;
            cb_reset.Location = new Point(btn_Reset.Location.X, btn_Reset.Location.Y + btn_Reset.Height);
            services();
            tb_search_name.CharacterCasing = CharacterCasing.Upper;
            tb_add_name.CharacterCasing = CharacterCasing.Upper;
            Text = "3ΛΠ-Ελασσόνα";
            BackgroundImage = Image.FromFile(_camoDir);
            cb_reset.BackColor = lb_latest.BackColor = lb_start.BackColor = gb_toolbox.BackColor = Color.Transparent;
                cb_reset.ForeColor = lb_latest.ForeColor = lb_start.ForeColor =
                lb_ipiresies.ForeColor = lb_ipiresiesResult.ForeColor =
                cb_manualsearch.ForeColor = label1.ForeColor = lb_search.ForeColor =
                groupBox3.ForeColor = lb_add.ForeColor = cb_manualAdd.ForeColor =
                lb_names.ForeColor = gb_toolbox.ForeColor = Color.White;
            MaximizeBox = false;
            btn_search.ForeColor = btn_add.ForeColor = btn_addRow.ForeColor =   
                btn_editNames.ForeColor = Color.Black;
            cb_showNotes.Checked = true;
            cb_showNotes.ForeColor = Color.White;
            cb_showNotes.BackColor = Color.Transparent;

            Bitmap b = (Bitmap)Image.FromFile(_iconDir);
            IntPtr pIcon = b.GetHicon();
            Icon z = Icon.FromHandle(pIcon);
            Icon = z;

        }


        private void InitDB(string[] _days, string _names)
        {
            int column, row;

            StreamWriter _writer;
            StreamReader _reader, _readerTimestamp;

            if (File.Exists(_timeStampCurrent))
            {
                _reader = new StreamReader(_timeStampCurrent);
                tb_latest.Text = _reader.ReadLine();
                _reader.Close();
            }

            //Read the start time if exist and update the textbox
            if (File.Exists(_timeStampFirst))
            {
                _readerTimestamp = new StreamReader(_timeStampFirst);
                tb_start.Text = _readerTimestamp.ReadLine().Remove(0, 10); //10 chars -> StartTime
                _readerTimestamp.Close();
            }


            if (!File.Exists(_database))
            {
                _writer = new StreamWriter(_database);
                _writer.WriteLine("[NAMES]\n" + _names);
                _writer.Close();
            }
            else
            {
                _reader = new StreamReader(_database);
                column = Convert.ToInt32(_reader.ReadLine().Split(':')[1]);
                row = Convert.ToInt32(_reader.ReadLine().Split(':')[1]);
                for (int p = 0; p < row - 1; p++)
                    dataGridView1.Rows.Add();
                string[,] _table = new string[column, row];
                string[] _line;
                int i = 0;
                int j = 0;
                do
                {
                    i = 0;
                    _line = _reader.ReadLine().Split(',');

                    foreach (string item in _line)
                    {
                        if (i <= _line.Length - 2)
                        {
                            dataGridView1[i, j].Value = item;
                            i++;
                        }
                    }
                    j++;
                } while (!_reader.EndOfStream);

                _reader.Close();
            }

            if ( File.Exists (_notesDB))
            {
                _reader = new StreamReader(_notesDB);
                tb_notes.Text = _reader.ReadToEnd();
                _reader.Close();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitUI();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!cb_manualAdd.Checked)
            {
                if (cbb_add_names.SelectedIndex == -1)
                {
                    MessageBox.Show("Δεν έχετε επιλέξει όνομα.");
                    return;
                }
                else
                    foreach (DataGridViewCell _c in dataGridView1.SelectedCells)
                        _c.Value = cbb_add_names.Text;
            }
            else
            {
                if (tb_add_name.Text == "")
                {
                    MessageBox.Show("Δεν έχετε επιλέξει όνομα.");
                    return;
                }
                foreach (DataGridViewCell _c in dataGridView1.SelectedCells)
                    _c.Value = tb_add_name.Text;
            }



            if (File.Exists(_timeStampCurrent)) File.Delete(_timeStampCurrent);
            StreamWriter _writeCurrentTime = new StreamWriter(_timeStampCurrent);
            DateTime date = DateTime.Now;
            _writeCurrentTime.WriteLine(date);
            tb_latest.Text = date + "";
            _writeCurrentTime.Close();

        }



        private void btn_addRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            dataGridView1.Rows.Insert(0);
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_reset)
                return;


            if (File.Exists(_timeStampFirst))
                File.Delete(_timeStampFirst);
            StreamWriter _writerTimestamp = new StreamWriter(_timeStampFirst);
            _writerTimestamp.WriteLine("StartTime:" + tb_start.Text);
            _writerTimestamp.Close();


            StreamWriter _writer = new StreamWriter(_database);
            _writer.WriteLine("Columns:" + dataGridView1.Columns.Count);
            _writer.WriteLine("Rows:" + dataGridView1.Rows.Count);
            string _grid;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                _grid = "";
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    _grid += dataGridView1[j, i].Value + ",";
                }

                _writer.WriteLine(_grid);
            }
            _writer.Close();

            //Manage the unsaved notes
            if (File.Exists(_notesDB))
            {
                string tmpNotes;
                StreamReader _reader = new StreamReader(_notesDB);
                tmpNotes = _reader.ReadToEnd();
                _reader.Close();
                if (tmpNotes != tb_notes.Text)
                {
                    DialogResult _dg = MessageBox.Show(
                    "Υπάρχουν σημειώσεις που δεν έχουν αποθηκευτεί.\r\nΝα γίνει αποθήκευση;",

                    "Αποθήκευση αλλαγών.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                    if (_dg == DialogResult.Yes)
                    {
                        File.Delete(_notesDB);
                        StreamWriter _tmpwriter = new StreamWriter(_notesDB);
                        _tmpwriter.Write(tb_notes.Text);
                        _tmpwriter.Close();
                    }
                }
            }
            else
            {
                if (tb_notes.Text != "")
                {
                    DialogResult _dg = MessageBox.Show(
                       "Υπάρχουν σημειώσεις που δεν έχουν αποθηκευτεί.\r\nΝα γίνει αποθήκευση;",

                       "Αποθήκευση αλλαγών.",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (_dg == DialogResult.Yes)
                    {
                        SaveNotes();
                    }
                }
            }
        }

        private void SaveNotes()
        {
            StreamWriter _tmpwriter = new StreamWriter(_notesDB);
            _tmpwriter.Write(tb_notes.Text);
            _tmpwriter.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            services_select();
        }

        private void cb_manualsearch_CheckedChanged(object sender, EventArgs e)
        {
            tb_search_name.Visible = cb_manualsearch.Checked;
            tb_search_name.Text = "";
            cbb_search_days.Visible = !cb_manualsearch.Checked;
            if (cb_manualsearch.Checked) {
                cbb_search_days.Text = "";
            }
            else tb_search_name.Text = "";
        }

        private void cb_manualAdd_CheckedChanged(object sender, EventArgs e)
        {
            tb_add_name.Visible = cb_manualAdd.Checked;
            cbb_add_names.Visible = !cb_manualAdd.Checked;
            if (cb_manualAdd.Checked)
            {
                cbb_add_names.Text = "";
            }
            else tb_add_name.Text = "";
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            int _w = 0;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
                _w += item.Width;
            dataGridView1.Width = _w + 2 + dataGridView1.RowHeadersWidth;
            Width = dataGridView1.Location.X + dataGridView1.Width + 30;
            btn_Reset.Location = new Point((dataGridView1.Location.X + dataGridView1.Width) - btn_Reset.Width, btn_Reset.Location.Y);
            btn_SaveNotes.Location = new Point((dataGridView1.Location.X + dataGridView1.Width) - btn_Reset.Width, btn_SaveNotes.Location.Y);
            cb_reset.Location = new Point(btn_Reset.Location.X, btn_Reset.Location.Y + btn_Reset.Height);
            gb_notes.Width = dataGridView1.Width;
            tb_notes.Width = dataGridView1.Width-15;
        }

        private void services()
        {
            int[] _soldiers = new int[cbb_add_names.Items.Count];
            string[,] _values = new string[dataGridView1.Columns.Count, dataGridView1.Rows.Count];
            listBox1.Items.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value == null)
                    {
                        _values[j, i] = "";
                    }
                    else
                    {
                        _values[j, i] = dataGridView1[j, i].Value.ToString();
                    }
                }

            for (int p = 0; p < cbb_add_names.Items.Count; p++)
            {
                for (int i = 0; i < _values.GetLength(0); i++)
                    for (int j = 0; j < _values.GetLength(1); j++)
                    {
                        if (_values[i, j] == cbb_add_names.Items[p].ToString())
                        {
                            _soldiers[p]++;
                        }
                    }
                object _o = cbb_add_names.Items[p] + ": " + _soldiers[p];
                listBox1.Items.Add(_o);
            }
        }
        private void services_select()
        {
            if ( (cbb_search_days.Text == "" || cbb_search_days.Text == null) && (tb_search_name.Text == "" || tb_search_name.Text == null))
            {
                MessageBox.Show("Παρακαλώ επιλέξτε όνομα προς αναζήτηση.");
                return;
            }

            if (cb_days.Text == "" || cb_days.Text == null)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ημέρα.");
                return;
            }
            counterDuties = 0;

            int whichDay = cb_days.SelectedIndex;
            int rows = dataGridView1.Rows.Count;
            string s = "";
            for (int i = 0; i < rows; i++)
            {

                try
                {
                    if (cb_manualsearch.Checked) s = tb_search_name.Text;
                    else s = cbb_search_days.Text;

                    if (dataGridView1.Rows[i].Cells[whichDay].Value.ToString() == s)
                    {
                        counterDuties++;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e + "");
                }
            }

            lb_ipiresiesResult.Text = "" + counterDuties + ", την ημέρα : " + cb_days.Text;

        }

        private void services_select(string _s1)
        {

            counterDuties = 0;
            foreach (DataGridViewCell item in dataGridView1.SelectedCells)
            {
                item.Selected = false;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string _s = "";
                    try
                    {
                        _s = dataGridView1[j, i].Value.ToString();
                    }
                    catch { }
                    if (_s == _s1)
                    {
                        dataGridView1[j, i].Selected = true;
                        counterDuties++;
                    }

                }
            lb_ipiresiesResult.Text = "" + counterDuties;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            services();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] _s = listBox1.SelectedItem.ToString().Split(':');
            services_select(_s[0]);

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            DialogResult _dg = MessageBox.Show(
                "Η επιλογή θα διαγράψει όλα τα δεδομένα που έχετε καταχωρήσει,\n" +
                "Η διαδικασία δεν είναι αναστρέψιμη.\n" +
                "Είστε σίγουροι πως θέλετε να συνεχίσετε τη διαγραφή ;",

                "Διαγραφη δεδομένων",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (_dg == DialogResult.Yes)
            {
                if (File.Exists(_database)) File.Delete(_database);
                if (File.Exists(_timeStampCurrent)) File.Delete(_timeStampCurrent);
                if (File.Exists(_timeStampFirst)) File.Delete(_timeStampFirst);

                //handle note deletation
                DialogResult dg = MessageBox.Show(
                    "Να πραγματοποιηθεί διαγραφή σημειώσεων;",
                    "Διαγραφή σημειώσεων.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dg == DialogResult.Yes)
                    if (File.Exists(_notesDB))
                        File.Delete(_notesDB);
                
                
             
                _reset = true;
                MessageBox.Show("" +
                    "Θα γίνει επανεκκίνηση της εφαρμογής για να ολοκληρωθεί\n" +
                    "η διαδικασία διαγραφής δεδομένων", "Διαγραφή δεδομένων",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Application.Restart();
            }
            else
                MessageBox.Show("Η διαδικασία διαγραφής δεδομένων ακυρώθηκε.", "Διαγραφή δεδομένων", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode.ToString() == "Delete")
            {
                foreach (DataGridViewCell item in dataGridView1.SelectedCells)
                {
                    item.Value = "";
                    item.Selected = false;
                }
            }
        }

        private void cb_reset_CheckedChanged(object sender, EventArgs e)
        {
            btn_Reset.Enabled = cb_reset.Checked;
            btn_Reset.BackColor = (btn_Reset.Enabled) ? Color.FromArgb(255, 51, 51) : Color.LightGray;
            btn_Reset.Text = (btn_Reset.Enabled) ? "ΕΠΑΝΑΦΟΡΑ" : "(Απενεργοποιημένο)";
        }

        private void tb_search_name_TextChanged(object sender, EventArgs e)
        {

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("el-GR"));
            if (tb_search_name.Text.ToCharArray().Any(element => char.IsDigit(element)))
            {
                tb_search_name.Text = tb_search_name.Text.Substring(0, tb_search_name.Text.Length - 1);
                tb_search_name.SelectionStart = tb_search_name.Text.Length;
            }

        }

        private void tb_add_name_TextChanged(object sender, EventArgs e)
        {

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("el-GR"));

            if (tb_add_name.Text.ToCharArray().Any(element => char.IsDigit(element)))
            {
                tb_add_name.Text = tb_add_name.Text.Substring(0, tb_add_name.Text.Length - 1);
                tb_add_name.SelectionStart = tb_add_name.Text.Length;
            }

            foreach (string item in cbb_add_names.Items)
                if (item.Contains(tb_add_name.Text))
                    cbb_add_names.SelectedItem = item;

        }

        private void tb_add_name_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("el-GR"));
        }

        private void tb_search_name_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("el-GR"));
        }

        private void cb_showNotes_CheckedChanged(object sender, EventArgs e)
        {
            gb_notes.Visible = cb_showNotes.Checked;
            btn_SaveNotes.Visible = cb_showNotes.Checked;
            if (cb_showNotes.Checked)
            {
                dataGridView1.Height = gb_toolbox.Height - btn_add.Height - 7 - viewMargin - gb_notes.Height - viewMargin - cb_showNotes.Height; //allign the bottom of DataGridView with the bottom of gb_toolbox
                cb_showNotes.Location = new Point(cb_showNotes.Location.X, dataGridView1.Location.Y + dataGridView1.Height + 5);
            }
            else
            {
                dataGridView1.Height = gb_toolbox.Height - btn_add.Height - 7 - viewMargin - cb_showNotes.Height; //allign the bottom of DataGridView with the bottom of gb_toolbox
                cb_showNotes.Location = new Point(cb_showNotes.Location.X, dataGridView1.Location.Y + dataGridView1.Height);
            }
        }

        private void btn_SaveNotes_Click(object sender, EventArgs e)
        {
            SaveNotes();
            MessageBox.Show(
                "Οι σημειώσεις αποθηκεύτηκαν επιτυχώς.", 
                "Αποθήκευση σημειώσεων",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void btn_editNames_Click(object sender, EventArgs e)
        {
            EditNames _editNames = new EditNames(_names);
            DialogResult _dg = _editNames.ShowDialog();
            if (_dg == DialogResult.Yes)
            {
                ClearGBSettingsNameControls();
                InitGBSettingsNameControls();
                services();
            }
        }

       
    }
}
