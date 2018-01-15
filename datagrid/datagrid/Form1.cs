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
            Timer currentTime = new Timer();
            currentTime.Tick += new EventHandler(curTick);
            label1.Text = "";
            currentTime.Interval = 1000;
            currentTime.Start();
            lb_ipiresies.Visible = lb_ipiresiesResult.Visible = btn_clear.Visible= false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitUI();
        }

        private void curTick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label1.Text += " " + DateTime.Now.Day + "-" + DateTime.Now.ToString("MMM") + "-" + DateTime.Now.Year;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η αναζητηση τελείωσε");
            lb_ipiresies.Visible = lb_ipiresiesResult.Visible = btn_clear.Visible = true;

        }
        bool confirm;
        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Εκκαθάριση;",
                      "", MessageBoxButtons.YesNo);
            confirm = (dr == DialogResult.Yes) ? true : false;
            if(confirm) lb_ipiresies.Visible = lb_ipiresiesResult.Visible = btn_clear.Visible = false;
            confirm = false;
            
        }
    }
}

//tzikas db 7 meres
//se ka8e keli epi8eta/onomata ana mera 
//kai na mporo na kanw stin stili (px deftera) anazitisi ena onoma.posa brike? 
//arxiki teliki imerominia panw apo dateview gia na 3erw apo pote ksekinaw trexw to programma...kai to current date
//na exei ena combobox na vazei default onomata apo textbox(8a m ta dosei).na ta krataei ola afta kai na mporo na sviso kiolas