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

namespace obrazkitest
{
    public partial class Form1 : Form
    {
        int czasDoStartu = 3, nrObrazka, iledotychczas = 0;
        /*const*/ int liczbaprob = 10;
        float czas = 0, czassredni = 0, czasrekord = float.PositiveInfinity; //float.maxvalue
        float minRek, srRek;
        Image[] obrazki = new Image[8];
        string nazwaPliku;

        void Restart()
        {
            PokazCzasy();
            nrObrazka = -1;
            labelstart.Location = new Point(196, 178);
            czasDoStartu = 3;
            labelstart.Text = czasDoStartu.ToString();
            labelstart.Visible = true;
            obrazek.BackgroundImage = null;
            czas = 0;
            timer.Stop();
            iledotychczas = 0; czas = 0; czassredni = 0; czasrekord = float.PositiveInfinity;
        }
        void PokazCzasy()
        {
            sredni.Text = "średni: " + (czassredni / liczbaprob).ToString("00.00") + "/" + (srRek/liczbaprob).ToString("00.00");
            minimalny.Text = "rekord: " + czasrekord.ToString("00.00") + "/" + minRek.ToString("00.00");
            licznikczasu.Text = "czas " + czas.ToString("00.00");
        }

        void Losowanie()
        {
            Random los = new Random();
            int poprzedni = nrObrazka;
            do
                nrObrazka = los.Next(0, 8);
            while (nrObrazka == poprzedni);
            obrazek.BackgroundImage = obrazki[nrObrazka];
            timer.Start();
        }

        void Trafienie()
        {
            czassredni += czas;
            iledotychczas++;
            sredni.Text = "średni: " + (czassredni/iledotychczas).ToString("00.00") + "/" + (srRek/liczbaprob).ToString("00.00");
            if (czas <= czasrekord)
            {
                czasrekord = czas;
                minimalny.Text = "rekord: " + czasrekord.ToString("00.00") + "/" + minRek.ToString("00.00"); 
            }
            labelstart.Text = (liczbaprob - iledotychczas).ToString();

            if (iledotychczas == liczbaprob)
            {
                if (czassredni < srRek) srRek = czassredni;
                if (czasrekord < minRek) minRek = czasrekord;

                StreamWriter plik = File.CreateText(nazwaPliku);
                plik.WriteLine(minRek.ToString());
                plik.WriteLine(srRek.ToString());
                plik.Dispose();

                Restart();
                timer.Stop();
            }
            else
            {
                czas = 0;
                Losowanie();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nazwaPliku = AppDomain.CurrentDomain.BaseDirectory + "rekordy.txt";
            if (File.Exists(nazwaPliku))
            {
                StreamReader plik = File.OpenText(nazwaPliku);
                minRek = float.Parse(plik.ReadLine());
                srRek = float.Parse(plik.ReadLine());
                plik.Dispose();
            }
            else
            {
                minRek = float.PositiveInfinity; srRek = float.PositiveInfinity;
            }

            
            Restart();
            obrazki[0] = Properties.Resources.dziura;
            obrazki[1] = Properties.Resources.galaktyka;
            obrazki[2] = Properties.Resources.jowisz;
            obrazki[3] = Properties.Resources.kometa;
            obrazki[4] = Properties.Resources.ziemia;
            obrazki[5] = Properties.Resources.ksiezyc;
            obrazki[6] = Properties.Resources.słońce;
            obrazki[7] = Properties.Resources.zorza;

        }

        private void timerstartu_Tick(object sender, EventArgs e)
        {
            if (--czasDoStartu == 0)
            {
                timerstartu.Stop();
                //labelstart.Visible = false;
                labelstart.Location = new Point(370, 178);
                labelstart.Text = liczbaprob.ToString();
                Losowanie();
                start.Text = "stop";
                start.Visible = true;
            }
            else
            {
                labelstart.Text = czasDoStartu.ToString();
                start.Visible = false;
            }   
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (start.Text == "start") timerstartu.Start();
            else
            {
                Restart();
                start.Text = "start";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            czas += .01f;
            licznikczasu.Text = "czas " + czas.ToString("00.00");
        }

        private void galaktyka_Click(object sender, EventArgs e)
        {
            if (nrObrazka == 1) Trafienie();
        }

        private void jowisz_Click(object sender, EventArgs e)
        {
            if (nrObrazka == 2) Trafienie();
        }

        private void kometa_Click(object sender, EventArgs e)
        {
            if (nrObrazka == 3) Trafienie();
        }

        private void neptun_Click(object sender, EventArgs e)
        {
            if (nrObrazka == 4) Trafienie();
        }

        private void ksiezyc_Click(object sender, EventArgs e)
        {
            if (nrObrazka == 5) Trafienie();
        }

        private void zorza_Click(object sender, EventArgs e)
        {
            if (nrObrazka == 7) Trafienie();
        }

        private void slonce_Click(object sender, EventArgs e)
        {
            if (nrObrazka == 6) Trafienie();
        }

        private void dziura_Click(object sender, EventArgs e)
        {
            if (nrObrazka == 0) Trafienie();
        }

        private void lp8_Click(object sender, EventArgs e)
        {
            liczbaprob = 8;
            lp8.Checked = true;
            lp10.Checked = false;
            lp16.Checked = false;
            lp30.Checked = false;
        }

        private void lp10_Click(object sender, EventArgs e)
        {
            liczbaprob = 10;
            lp8.Checked = false;
            lp10.Checked = true;
            lp16.Checked = false;
            lp30.Checked = false;
        }

        private void lp16_Click(object sender, EventArgs e)
        {
            liczbaprob = 16;
            lp8.Checked = false;
            lp10.Checked = false;
            lp16.Checked = true;
            lp30.Checked = false;
        }

        private void lp30_Click(object sender, EventArgs e)
        {
            liczbaprob = 30;
            lp8.Checked = false;
            lp10.Checked = false;
            lp16.Checked = false;
            lp30.Checked = true;
        }

        private void kasujRekordyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(nazwaPliku);
            czassredni = 0; czasrekord = float.PositiveInfinity;
            minRek = float.PositiveInfinity; srRek = float.PositiveInfinity;
        }

        private void wyjscieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
// https://www.pexels.com/pl-pl/zdjecie/zdjecie-moon-47367/ - księżyc
// https://www.pexels.com/pl-pl/zdjecie/gwiazdy-wszechswiat-astronomia-jowisz-12498752/ - jowisz
// https://www.pexels.com/pl-pl/zdjecie/kosmos-kurz-teleskop-galaxy-4994765/ - galaktyka
// https://www.pexels.com/pl-pl/zdjecie/zolta-kula-ilustracja-39649/ - słońce
// https://www.pexels.com/pl-pl/zdjecie/aurora-lights-1693095/ - zorza polarna
// czarna dziura https://eventhorizontelescope.org/
// https://www.pexels.com/pl-pl/zdjecie/kosmos-teleskop-astronomia-spadajaca-gwiazda-5086477/ - kometa
// https://www.pexels.com/pl-pl/zdjecie/tapeta-ziemi-41953/ - ziemia
// https://www.pexels.com/pl-pl/zdjecie/drewno-krajobraz-natura-niebo-6785277/ - background