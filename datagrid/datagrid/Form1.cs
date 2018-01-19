﻿using System;
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
            if (!Directory.Exists(Directory.GetCurrentDirectory()+"/_stamps"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/_stamps");
            }
            WindowState = FormWindowState.Maximized;
            
        }
        int viewMargin = 10;
        string _database = Directory.GetCurrentDirectory() + "/_stamps/db.txt";
        string _timeStampFirst = Directory.GetCurrentDirectory() + "/_stamps/timestamp.txt";
        string _timeStampCurrent = Directory.GetCurrentDirectory() + "/_stamps/timestampCurrent.txt";
        int counterDuties = 0;
        private void InitUI()
        {
            //MaximizeBox = false;
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

            int _w = 0;
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].HeaderText = days[i];
                dataGridView1.Columns[i].Width = 150;
                _w += dataGridView1.Columns[i].Width;
            }


            tb_latest.Enabled = false;
            tb_start.Enabled = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            lb_add.Font =
                new Font
                (
                lb_add.Font,
                FontStyle.Underline
                );
            lb_ipiresiesResult.Text =  "";
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
            int w = Size.Width - gb_toolbox.Width - gb_toolbox.Location.X - (dataGridView1.Location.X - gb_toolbox.Width) - viewMargin ;
            int h = Size.Height - dataGridView1.Location.Y - viewMargin - 50;
            //-50 for bars and shit
            dataGridView1.Width = w;
            dataGridView1.Height = h; 
            cbb_add_names.DropDownStyle = cbb_search_days.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_search_name.Visible = false;
            tb_add_name.Visible = false;



            WindowState = FormWindowState.Normal;
            dataGridView1.Width = _w + 2 + dataGridView1.RowHeadersWidth;
            Width = dataGridView1.Location.X + dataGridView1.Width + 30;
            dataGridView1.Height = gb_toolbox.Height - 7; //allign the bottom of DataGridView with the bottom of gb_toolbox
            
        }


        private void InitDB(string[] _days, string _names)
        {
            int column, row;

            StreamWriter _writer, _writerTimestamp;
            StreamReader _reader, _readerTimestamp;
            
            if (File.Exists(_timeStampCurrent))
            {
                _reader = new StreamReader(_timeStampCurrent);
                tb_latest.Text = _reader.ReadLine();
                _reader.Close();
            }
               
            
            if (!File.Exists(_timeStampFirst))
            {
                _writerTimestamp = new StreamWriter(_timeStampFirst);
                _writerTimestamp.WriteLine("StartTime:"+DateTime.Now);
                tb_start.Text = DateTime.Now +"";
                _writerTimestamp.Close();
            }
            else
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

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitUI();
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
                if(tb_add_name.Text=="")
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

        private void tb_add_name_TextChanged(object sender, EventArgs e)
        {
            foreach (string item in cbb_add_names.Items)
                if (item.Contains(tb_add_name.Text))
                    cbb_add_names.SelectedItem = item;
        }
        
        private void btn_addRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            dataGridView1.Rows.Insert(0, "");
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;

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

        private void cb_manualsearch_CheckedChanged(object sender, EventArgs e)
        {
            tb_search_name.Visible = cb_manualsearch.Checked;
            cbb_search_days.Visible = !cb_manualsearch.Checked;
        }

        private void cb_manualAdd_CheckedChanged(object sender, EventArgs e)
        {
            tb_add_name.Visible = cb_manualAdd.Checked;
            cbb_add_names.Visible = !cb_manualAdd.Checked;
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            int _w = 0;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
                _w += item.Width;
            dataGridView1.Width = _w + 2 + dataGridView1.RowHeadersWidth;
            Width = dataGridView1.Location.X + dataGridView1.Width + 30;
        }
    }
}
