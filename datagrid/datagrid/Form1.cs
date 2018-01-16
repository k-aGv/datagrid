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
        public Form1()
        {
            InitializeComponent();
        }
        string _database = Directory.GetCurrentDirectory() + "/db.txt";
        int remainingRows = 0;
        int counterDuties = 0;
        private void InitUI()
        {
            string[] days = new string[]
            { "Δευτέρα", "Τρίτη", "Τετάρτη","Πέμπτη","Παρασκευή","Σάββατο","Κυριακή"};
            string names = "[ΧΡΙΣΤΟΔΟΥΛΟΣ,ΓΚΙΟΥΡΣΑΝΗΣ,ΠΑΠΑΓΕΩΡΓΙΟΥ,ΛΙΑΚΟΣ,ΠΟΥΡΝΑΡΑΣ,ΑΝΑΤΟΛΙΤΗΣ,ΒΑΛΑΤΣΟΣ,ΚΑΤΣΑΡΑΣ,ΤΣΙΤΣΙΒΑΣ,ΓΚΟΥΨΖΑΡΑΣ]";

            InitDB(days, names);

            names = names.Replace('[', ' ');
            names = names.Replace(']', ' ');
            char[] delim = { ',' };
            foreach (string item in names.Remove(0, 1).Split(delim, StringSplitOptions.RemoveEmptyEntries))
            {
                cbb_add_names.Items.Add(item);
                cbb_search_days.Items.Add(item);
            }
            

            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].HeaderText = days[i];
                dataGridView1.Columns[i].Width = 150;
            }


            tb_latest.ReadOnly = true;
            tb_start.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.Both;
            lb_add.Font =
                new Font
                (
                lb_add.Font,
                FontStyle.Underline
                );
            lb_ipiresiesResult.Text =  "";
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
        }


        private void InitDB(string[] _days, string _names)
        {
            int column, row;

            StreamWriter _writer;
            StreamReader _reader;
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

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitUI();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbb_add_names.SelectedIndex == -1)
            {
                MessageBox.Show("Δεν έχετε επιλέξει όνομα.");
                return;
            }

            foreach (DataGridViewCell _c in dataGridView1.SelectedCells)
                _c.Value = cbb_add_names.Text;
        }

        private void tb_add_name_TextChanged(object sender, EventArgs e)
        {
            foreach (string item in cbb_add_names.Items)
                if (item.Contains(tb_add_name.Text))
                    cbb_add_names.SelectedItem = item;
        }
        
        private void btn_addRow_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows[dataGridView1.Rows.Count - 1 - remainingRows].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Rows.Insert(0, "");
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
            remainingRows++;
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
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
                    if (tb_search_name.Text != "")
                    {
                       
                        if (_s == tb_search_name.Text)
                        {
                            dataGridView1[j, i].Selected = true;
                            counterDuties++;
                        }
                    }
                    else
                    {
                        if (_s == cbb_search_days.Text)
                        {
                            dataGridView1[j, i].Selected = true;
                            counterDuties++;
                        }
                    }
                }
            lb_ipiresiesResult.Text = ""+ counterDuties;
        }
    }
}
