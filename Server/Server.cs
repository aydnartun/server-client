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

namespace Server
{
    public partial class frm_server : Form
    {
        Thread t;
        IPAddress ipadresimiz;
        TcpListener dinle;
        Socket soket;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;

        public delegate void ricdegis(string text);

        public frm_server()
        {
            InitializeComponent();
        }

        public void okumayabasla()
        {
            soket = dinle.AcceptSocket();
            ag = new NetworkStream(soket);
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
                s = "İstemci: " + s;
                richTextBox1.AppendText(s + "\n");
            }

        }

        private void dinlemeye_basla()
        {
            try
            {

                dinle = new TcpListener(IPAddress.Any, 1024);
                dinle.Start();
                t = new Thread(new ThreadStart(okumayabasla));
                t.Start();
                richTextBox1.AppendText(DateTime.Now.ToLongTimeString() + " Sohbet Başlatıldı..." + "\n");
            }
            catch (Exception)
            {
                MessageBox.Show("Sohbet Başlatılırken Bir Hata Oluştu Lütfen Bir Daha Deneyiniz...","Hata",MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            dinlemeye_basla();
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            ag.Close();
            MessageBox.Show("Sohbet Başarılı Bir Şekilde Sonlandırıldı...");
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
                richTextBox1.AppendText("Sunucu: " + txt_mesaj.Text + "\n");
                txt_mesaj.Text = "";
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

        private void ust_bar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }
    }
}
