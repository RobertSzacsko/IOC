using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;

namespace IOC
{
    public partial class GamePage : Form
    {
        int nrCorrect = 0;
        int timeLeft = 15;
        Dictionary<PictureBox, int> listObjects = new Dictionary<PictureBox, int>();
        SoundPlayer sp = new SoundPlayer();

        int[] paharP = new int[4];
        int[] newsPapaerH = new int[4];
        int[] paharS = new int[4];
        int[] sucP = new int[4];
        int[] sticlaNS = new int[4];
        int[] cerealeH = new int[4];
        int[] masinaP = new int[4];
        int[] oglindaS = new int[4];
        int[] lebadaH = new int[4];

        public GamePage()
        {
            InitializeComponent();
            timeLabel.Text = timeLeft.ToString();

//          starea 0 inseamna ca nu ii selectat dar ii afisat
//          starea 1 inseamna ca obiectul ii selectat
//          starea 2 insemana ca obiectul ii pus la cosul corect si nu mai apare

            listObjects.Add(paharPlastic, 0);
            listObjects.Add(paharSticla, 0);
            listObjects.Add(newsPapaerHartie, 0);
            listObjects.Add(sucPlastic, 0);
            listObjects.Add(sticlaNeagra, 0);
            listObjects.Add(cerealeBoxHartie, 0);
            listObjects.Add(masinaPlastic, 0);
            listObjects.Add(oglindaSticla, 0);
            listObjects.Add(lebadaHartie, 0);
        }

        private void GamePage_Load(object sender, EventArgs e)
        {

        }

        private void pictureStartGame_Click(object sender, EventArgs e)
        {
            timerGame.Enabled = true;
            setEnabled(true);
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft.ToString();
            }
            else
            {
                timerGame.Stop();
                sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\recs\\gataMesaj.wav";
                sp.Play();
                timeLabel.Text = "TIMP TERMINAT";
                timeLabel.ForeColor = Color.Red;
                setEnabled(false);
                pictureStartGame.Enabled = false;
                //pictureRepeta.Visible = true;
            }
        }

        private void pictureStartGame_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureStartGame_MouseLeave(object sender, EventArgs e)
        {

        }

        private void paharPlastic_Click(object sender, EventArgs e)
        {
            listObjects[paharPlastic] = 1;
            paharP = new int[4] { paharPlastic.Location.X, paharPlastic.Location.Y, paharPlastic.Width, paharPlastic.Height };
            paharPlastic.SetBounds(paharP[0] - 5, paharP[1] - 5, paharP[2] + 10, paharP[3] + 10);

            listObjects[newsPapaerHartie] = 0;
            listObjects[paharSticla] = 0;
            listObjects[sucPlastic] = 0;
            listObjects[sticlaNeagra] = 0;
            listObjects[cerealeBoxHartie] = 0;
            listObjects[masinaPlastic] = 0;
            listObjects[oglindaSticla] = 0;
            listObjects[lebadaHartie] = 0;
        }

        private void pictureCosPlastic_Click(object sender, EventArgs e)
        {
            if (listObjects[paharPlastic] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[paharPlastic] = 2;
                paharPlastic.BackgroundImage = null;
                paharPlastic.Enabled = false;
                nrCorrect++;
            } else if (listObjects[sucPlastic] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[sucPlastic] = 2;
                sucPlastic.BackgroundImage = null;
                sucPlastic.Enabled = false;
                nrCorrect++;
            } else if (listObjects[masinaPlastic] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[masinaPlastic] = 2;
                masinaPlastic.BackgroundImage = null;
                masinaPlastic.Enabled = false;
                nrCorrect++;
            }
            else {
                sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"..\..\recs\wrong.wav";
                sp.Play();
            }
            if (nrCorrect == 9)
            {
                timerGame.Stop();
                sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"..\..\recs\finalJoc.wav";
                sp.Play();
                setEnabled(false);
                pictureRepeta.Show();
            }
        }

        private void newsPapaerHartie_Click(object sender, EventArgs e)
        {
            listObjects[newsPapaerHartie] = 1;
            newsPapaerH = new int[4] { newsPapaerHartie.Location.X, newsPapaerHartie.Location.Y, newsPapaerHartie.Width, newsPapaerHartie.Height };
            newsPapaerHartie.SetBounds(newsPapaerH[0] - 5, newsPapaerH[1] - 5, newsPapaerH[2] + 10, newsPapaerH[3] + 10);

            listObjects[paharPlastic] = 0;
            listObjects[sucPlastic] = 0;
            listObjects[paharSticla] = 0;
            listObjects[sticlaNeagra] = 0;
            listObjects[cerealeBoxHartie] = 0;
            listObjects[masinaPlastic] = 0;
            listObjects[oglindaSticla] = 0;
            listObjects[lebadaHartie] = 0;
        }

        private void pictureCosHartie_Click(object sender, EventArgs e)
        {
            if (listObjects[newsPapaerHartie] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[newsPapaerHartie] = 2;
                newsPapaerHartie.BackgroundImage = null;
                newsPapaerHartie.Enabled = false;
                nrCorrect++;
            } else if (listObjects[cerealeBoxHartie] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[cerealeBoxHartie] = 2;
                cerealeBoxHartie.BackgroundImage = null;
                cerealeBoxHartie.Enabled = false;
                nrCorrect++;
            } else if (listObjects[lebadaHartie] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[lebadaHartie] = 2;
                lebadaHartie.BackgroundImage = null;
                lebadaHartie.Enabled = false;
                nrCorrect++;
            } else
            {
                sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"..\..\recs\wrong.wav";
                sp.Play();
            }
            if (nrCorrect == 9)
            {
                timerGame.Stop();
                sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"..\..\recs\finalJoc.wav";
                sp.Play();
                setEnabled(false);
                pictureRepeta.Show();
            }
        }

        private void paharSticla_Click(object sender, EventArgs e)
        {
            listObjects[paharSticla] = 1;
            paharS = new int[4] { paharSticla.Location.X, paharSticla.Location.Y, paharSticla.Width, paharSticla.Height };
            paharSticla.SetBounds(paharS[0] - 5, paharS[1] - 5, paharS[2] + 10, paharS[3] + 10);

            listObjects[newsPapaerHartie] = 0;
            listObjects[paharPlastic] = 0;
            listObjects[sucPlastic] = 0;
            listObjects[sticlaNeagra] = 0;
            listObjects[cerealeBoxHartie] = 0;
            listObjects[masinaPlastic] = 0;
            listObjects[oglindaSticla] = 0;
            listObjects[lebadaHartie] = 0;
        }

        private void pictureCosSticla_Click(object sender, EventArgs e)
        {
            if (listObjects[paharSticla] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[paharSticla] = 2;
                paharSticla.BackgroundImage = null;
                paharSticla.Enabled = false;
                nrCorrect++;
            } else if (listObjects[sticlaNeagra] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[sticlaNeagra] = 2;
                sticlaNeagra.BackgroundImage = null;
                sticlaNeagra.Enabled = false;
                nrCorrect++;
            } else if (listObjects[oglindaSticla] == 1)
            {
                sound.RunWorkerAsync(@"..\..\recs\correct.wav");
                listObjects[oglindaSticla] = 2;
                oglindaSticla.BackgroundImage = null;
                oglindaSticla.Enabled = false;
                nrCorrect++;
            } else
            {
                sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"..\..\recs\wrong.wav";
                sp.Play();
            }
            if (nrCorrect == 9)
            {
                timerGame.Stop();
                sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"..\..\recs\finalJoc.wav";
                sp.Play();
                setEnabled(false);
                pictureRepeta.Show();
            }
        }

        private void sucPlastic_Click(object sender, EventArgs e)
        {
            listObjects[sucPlastic] = 1;
            sucP = new int[4] { sucPlastic.Location.X, sucPlastic.Location.Y, sucPlastic.Width, sucPlastic.Height };
            sucPlastic.SetBounds(sucP[0] - 5, sucP[1] - 5, sucP[2] + 10, sucP[3] + 10);

            listObjects[paharPlastic] = 0;
            listObjects[paharSticla] = 0;
            listObjects[newsPapaerHartie] = 0;
            listObjects[sticlaNeagra] = 0;
            listObjects[cerealeBoxHartie] = 0;
            listObjects[masinaPlastic] = 0;
            listObjects[oglindaSticla] = 0;
            listObjects[lebadaHartie] = 0;
        }

        private void sticlaNeagra_Click(object sender, EventArgs e)
        {
            listObjects[sticlaNeagra] = 1;
            sticlaNS = new int[4] { sticlaNeagra.Location.X, sticlaNeagra.Location.Y, sticlaNeagra.Width, sticlaNeagra.Height };
            sticlaNeagra.SetBounds(sticlaNS[0] - 5, sticlaNS[1] - 5, sticlaNS[2] + 10, sticlaNS[3] + 10);

            listObjects[sucPlastic] = 0;
            listObjects[paharPlastic] = 0;
            listObjects[paharSticla] = 0;
            listObjects[newsPapaerHartie] = 0;
            listObjects[cerealeBoxHartie] = 0;
            listObjects[masinaPlastic] = 0;
            listObjects[oglindaSticla] = 0;
            listObjects[lebadaHartie] = 0;
        }

        private void cerealeBoxHartie_Click(object sender, EventArgs e)
        {
            listObjects[cerealeBoxHartie] = 1;
            cerealeH = new int[4] { cerealeBoxHartie.Location.X, cerealeBoxHartie.Location.Y, cerealeBoxHartie.Width, cerealeBoxHartie.Height };
            cerealeBoxHartie.SetBounds(cerealeH[0] - 5, cerealeH[1] - 5, cerealeH[2] + 10, cerealeH[3] + 10);

            listObjects[sucPlastic] = 0;
            listObjects[paharPlastic] = 0;
            listObjects[sticlaNeagra] = 0;
            listObjects[paharSticla] = 0;
            listObjects[newsPapaerHartie] = 0;
            listObjects[masinaPlastic] = 0;
            listObjects[oglindaSticla] = 0;
            listObjects[lebadaHartie] = 0;
        }

        private void masinaPlastic_Click(object sender, EventArgs e)
        {
            listObjects[masinaPlastic] = 1;
            masinaP = new int[4] { masinaPlastic.Location.X, masinaPlastic.Location.Y, masinaPlastic.Width, masinaPlastic.Height };
            masinaPlastic.SetBounds(masinaP[0] - 5, masinaP[1] - 5, masinaP[2] + 10, masinaP[3] + 10);

            listObjects[sucPlastic] = 0;
            listObjects[paharPlastic] = 0;
            listObjects[sticlaNeagra] = 0;
            listObjects[paharSticla] = 0;
            listObjects[newsPapaerHartie] = 0;
            listObjects[cerealeBoxHartie] = 0;
            listObjects[oglindaSticla] = 0;
            listObjects[lebadaHartie] = 0;
        }

        private void oglindaSticla_Click(object sender, EventArgs e)
        {
            listObjects[oglindaSticla] = 1;
            oglindaS = new int[4] { oglindaSticla.Location.X, oglindaSticla.Location.Y, oglindaSticla.Width, oglindaSticla.Height };
            oglindaSticla.SetBounds(oglindaS[0] - 5, oglindaS[1] - 5, oglindaS[2] + 10, oglindaS[3] + 10);

            listObjects[masinaPlastic] = 0;
            listObjects[sucPlastic] = 0;
            listObjects[paharPlastic] = 0;
            listObjects[sticlaNeagra] = 0;
            listObjects[paharSticla] = 0;
            listObjects[newsPapaerHartie] = 0;
            listObjects[cerealeBoxHartie] = 0;
            listObjects[lebadaHartie] = 0;
        }

        private void lebadaHartie_Click(object sender, EventArgs e)
        {
            listObjects[lebadaHartie] = 1;
            lebadaH = new int[4] { lebadaHartie.Location.X, lebadaHartie.Location.Y, lebadaHartie.Width, lebadaHartie.Height };
            lebadaHartie.SetBounds(lebadaH[0] - 5, lebadaH[1] - 5, lebadaH[2] + 10, lebadaH[3] + 10);

            listObjects[oglindaSticla] = 0;
            listObjects[masinaPlastic] = 0;
            listObjects[sucPlastic] = 0;
            listObjects[paharPlastic] = 0;
            listObjects[sticlaNeagra] = 0;
            listObjects[paharSticla] = 0;
            listObjects[newsPapaerHartie] = 0;
            listObjects[cerealeBoxHartie] = 0;
        }

        private void setEnabled(bool var)
        {
            setEnabledItems(var);
            setEnabledCosuri(var);
        }

        private void setEnabledCosuri(bool var)
        {
            pictureCosHartie.Enabled = var;
            pictureCosPlastic.Enabled = var;
            pictureCosSticla.Enabled = var;
        }

        private void setEnabledItems(bool var)
        {
            paharPlastic.Enabled = var;
            paharSticla.Enabled = var;
            newsPapaerHartie.Enabled = var;
            sucPlastic.Enabled = var;
            sticlaNeagra.Enabled = var;
            cerealeBoxHartie.Enabled = var;
            masinaPlastic.Enabled = var;
            oglindaSticla.Enabled = var;
            lebadaHartie.Enabled = var;
        }

        private void checkIsDone_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string location = ((String)e.Argument);
            sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + location;
            sp.Play();
            timeLeft += 15;
        }

        private void checkIsDone_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GamePage_Shown(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            workerForTimerIncepeSunetDeInceput.RunWorkerAsync();
            timerIncepeSunetDeIndeput.Stop();
        }

        private void workerForTimerIncepeSunetDeInceput_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            sp.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"..\..\recs\joc1.wav";
            sp.Play();
            System.Threading.Thread.Sleep(19000);
        }

        private void workerForTimerIncepeSunetDeInceput_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            pictureStartGame.Enabled = true;
        }

        private void pictureRepeta_Click(object sender, EventArgs e)
        {
            setEnabled(true);
            nrCorrect = 0;
            setXYWidthHeightToOiginal();
            setDictionaryValues(0);
            setBackgroundImage();
            timeLeft = 15;
            timerGame.Start();
            pictureRepeta.Hide();
        }

        private void setDictionaryValues(int number)
        {
            listObjects[paharPlastic] = number;
            listObjects[sucPlastic] = number;
            listObjects[masinaPlastic] = number;
            listObjects[newsPapaerHartie] = number;
            listObjects[lebadaHartie] = number;
            listObjects[cerealeBoxHartie] = number;
            listObjects[paharSticla] = number;
            listObjects[oglindaSticla] = number;
            listObjects[sticlaNeagra] = number;
        }

        private void setBackgroundImage()
        {
            Image image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\paharPlasticGame.png");
            if (paharPlastic.BackgroundImage == null)
                paharPlastic.BackgroundImage = image;

            image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\sucPlasticGame.png");
            if (sucPlastic.BackgroundImage == null)
            sucPlastic.BackgroundImage = image;

            image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\masinaPlasticGame.png");
            if (masinaPlastic.BackgroundImage == null)
                masinaPlastic.BackgroundImage = image;

            image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\testNewspaper.png");
            if (newsPapaerHartie.BackgroundImage == null)
                newsPapaerHartie.BackgroundImage = image;

            image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\Imagine Hartie.png");
            if (lebadaHartie.BackgroundImage == null)
                lebadaHartie.BackgroundImage = image;

            image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\cerealBoxGame.png");
            if (cerealeBoxHartie.BackgroundImage == null)
                cerealeBoxHartie.BackgroundImage = image;

            image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\paharSticlaGame.png");
            if (paharSticla.BackgroundImage == null)
                paharSticla.BackgroundImage = image;

            image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\oglindaSticlaGame.png");
            if (oglindaSticla.BackgroundImage == null)
                oglindaSticla.BackgroundImage = image;

            image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"..\..\images\sticlaNeagraGame.png");
            if (sticlaNeagra.BackgroundImage == null)
                sticlaNeagra.BackgroundImage = image;
        }

        private void setXYWidthHeightToOiginal()
        {
            if (paharP[0] != paharPlastic.Location.X)
                paharPlastic.SetBounds(paharP[0], paharP[1], paharP[2], paharP[3]);
            if (sucP[0] != sucPlastic.Location.X)
                sucPlastic.SetBounds(sucP[0], sucP[1], sucP[2], sucP[3]);
            if (masinaP[0] != masinaPlastic.Location.X)
                masinaPlastic.SetBounds(masinaP[0], masinaP[1], masinaP[2], masinaP[3]);
            if (newsPapaerH[0] != newsPapaerHartie.Location.X)
                newsPapaerHartie.SetBounds(newsPapaerH[0], newsPapaerH[1], newsPapaerH[2], newsPapaerH[3]);
            if (lebadaH[0] != lebadaHartie.Location.X)
                lebadaHartie.SetBounds(lebadaH[0], lebadaH[1], lebadaH[2], lebadaH[3]);
            if (cerealeH[0] != cerealeBoxHartie.Location.X)
                cerealeBoxHartie.SetBounds(cerealeH[0], cerealeH[1], cerealeH[2], cerealeH[3]);
            if (paharS[0] != paharSticla.Location.X)
                paharSticla.SetBounds(paharS[0], paharS[1], paharS[2], paharS[3]);
            if (oglindaS[0] != oglindaSticla.Location.X)
                oglindaSticla.SetBounds(oglindaS[0], oglindaS[1], oglindaS[2], oglindaS[3]);
            if (sticlaNS[0] != sticlaNeagra.Location.X)
                sticlaNeagra.SetBounds(sticlaNS[0], sticlaNS[1], sticlaNS[2], sticlaNS[3]);
        }
    }
}