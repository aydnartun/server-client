using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class frm_client : Form
    {
        Thread t;
        TcpClient baglantikur;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;
        public delegate void ricdegis(string text);

        public frm_client()
        {
            InitializeComponent();
        }

        public void okumayabasla()
        {
            ag = baglantikur.GetStream();
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch
                {
                    return;
                }
            }
        }

        public void ekranabas(string s)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, s);
            }
            else
            {
                s = "Sunucu: " + s;
                richTextBox1.AppendText(s + "\n");
            }
        }

        public void baglanti_kur()
        {
            try
            {
                baglantikur = new TcpClient(txt_ip.Text, 1024);
                t = new Thread(new ThreadStart(okumayabasla));
                t.Start();
                richTextBox1.AppendText(DateTime.Now.ToLongTimeString() + " Sohbet Başlatıldı..." + "\n");
            }
            catch (Exception)
            {
                MessageBox.Show("Sohbet Başlatılırken Bir Hata Oluştu Lütfen Bir Daha Deneyiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_client_Load(object sender, EventArgs e)
        {
            txt_ip.Text = "Örn İp : 192.168.1.1";
        }
        private void txt_ip_Enter(object sender, EventArgs e)
        {
            if (txt_ip.Text == "Örn İp : 192.168.1.1")
            {
                txt_ip.Text = "";
            }
        }
        private void txt_ip_Leave(object sender, EventArgs e)
        {
            if (txt_ip.Text == "")
            {
                txt_ip.Text = "Örn İp : 192.168.1.1";
            }
        } 
        private void kapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void asagı_al_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool dragging;
        Point offset;

        private void ust_bar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void ust_bar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void ust_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            baglanti_kur();
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            baglantikur.Client.Close();
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if (txt_mesaj.Text == "")
                return;
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(txt_mesaj.Text);
                yaz.Flush();
                richTextBox1.AppendText("İstemci: " + txt_mesaj.Text + "\n");
                txt_mesaj.Text = "";
            }  
        } 
    }
}
