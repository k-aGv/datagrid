using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitUI()
        {
            string[] days = new string[]
            { "deftera", "triti", "tetarti","pempti","paraskevi","savato","kiriaki"};

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
            lb_ipiresiesResult.Text = 5 +"";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitUI();
        }

      
    }
}
