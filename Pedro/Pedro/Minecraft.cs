using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media
    ;

namespace Pedro
{
    public partial class Minecraft : Form
    {
        
        int  zombiesepeed, zombiespeed2, zombiespeed3X,
        zombiespeed3Y, ZombieSpeed4, zombiespeed6, zombiespeed5, zombiespeed7, cr1, cr2, cr3, cr4, cr5, es1, es2;

        public Minecraft()
        {
            InitializeComponent();
            resetGame();
        }
        private void Minecraft_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            pictureBox64.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //zombie1
            zombie1.Top += zombiesepeed;
            if (zombie1.Bounds.IntersectsWith(pictureBox16.Bounds) || zombie1.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                zombiesepeed = -zombiesepeed;
            }
            //zombie2
            zombie2.Left += zombiespeed2;
            if (zombie2.Bounds.IntersectsWith(pictureBox2.Bounds) || zombie2.Bounds.IntersectsWith(pictureBox19.Bounds))
            {
                zombiespeed2 = -zombiespeed2;
            }
            //zombie3
            zombie3.Left -= zombiespeed3X;
            zombie3.Top -= zombiespeed3Y;
            if (zombie3.Top < 20 || zombie3.Top > 270)
            {
                zombiespeed3Y = -zombiespeed3Y;
            }
            if (zombie3.Left > 510 || zombie3.Left < 60)
            {
                zombiespeed3X = -zombiespeed3X;
            }
            //zombie4
            zombie4.Top -= ZombieSpeed4;
            if (zombie4.Top < 20 || zombie4.Top > 270)
            {
                ZombieSpeed4 = -ZombieSpeed4;
            }
            //Zombie5
            zombie5.Left -= zombiespeed5;
            zombie5.Top -= zombiespeed5;
            if (zombie5.Top < 20 || zombie5.Top > 270)
            {
                zombiespeed5 = -zombiespeed5;
            }
            if (zombie5.Left > 510 || zombie5.Left < 60)
            {
                zombiespeed5 = -zombiespeed5;
            }
            //zombie6
            zombie6.Top -= zombiespeed6;
            if (zombie6.Top < 20 || zombie6.Top > 270)
            {
                zombiespeed6 = -zombiespeed6;
            }
            zombie7.Left -= zombiespeed7;
            if (zombie7.Left < 60 || zombie7.Left > 510)
            {
                zombiespeed7 = -zombiespeed7;
            }
            //Creepers
            Creeper1.Left += cr1;
            if (Creeper1.Bounds.IntersectsWith(pictureBox46.Bounds) || Creeper1.Bounds.IntersectsWith(pictureBox22.Bounds))
            {
                cr1 = -cr1;

            }
            Creeper2.Left -= cr2;
            if (Creeper2.Bounds.IntersectsWith(pictureBox56.Bounds) || Creeper2.Bounds.IntersectsWith(pictureBox19.Bounds) &&
                Creeper2.Bounds.IntersectsWith(pictureBox19.Bounds) || Creeper2.Bounds.IntersectsWith(pictureBox61.Bounds))
            {
                cr2 = -cr2;
            }
            Creeper3.Top -= cr3;
            if (Creeper3.Bounds.IntersectsWith(pictureBox53.Bounds) || Creeper3.Bounds.IntersectsWith(pictureBox16.Bounds) &&
                Creeper3.Bounds.IntersectsWith(pictureBox16.Bounds) || Creeper3.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                cr3 = -cr3;
            }
            creeper4.Left -= cr4;
            if (creeper4.Bounds.IntersectsWith(pictureBox25.Bounds) || creeper4.Bounds.IntersectsWith(pictureBox70.Bounds))
            {
                cr4 = -cr4;
            }
            creeper5.Left -= cr5;
            if (creeper5.Bounds.IntersectsWith(pictureBox58.Bounds) || creeper5.Bounds.IntersectsWith(pictureBox61.Bounds) &&
                creeper5.Bounds.IntersectsWith(pictureBox61.Bounds) || creeper5.Bounds.IntersectsWith(pictureBox17.Bounds))
            {
                cr5 = -cr5;
            }
            //monstuos chocan contra ti0 
            if (zombie1.Bounds.IntersectsWith(pictureBox13.Bounds) || zombie2.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                zombie3.Bounds.IntersectsWith(pictureBox13.Bounds) || zombie4.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                zombie5.Bounds.IntersectsWith(pictureBox13.Bounds) || zombie6.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                zombie7.Bounds.IntersectsWith(pictureBox13.Bounds) || esqueleto1.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                esqueleto2.Bounds.IntersectsWith(pictureBox13.Bounds) || esqueleto3.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                esqueleto4.Bounds.IntersectsWith(pictureBox13.Bounds) || esqueleto5.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                pictureBox13.Left = 12;
                pictureBox13.Top = 160;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;  
            }
            if (Creeper1.Bounds.IntersectsWith(pictureBox13.Bounds) || Creeper2.Bounds.IntersectsWith(pictureBox13.Bounds) || 
                Creeper3.Bounds.IntersectsWith(pictureBox13.Bounds) || creeper5.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                pictureBox13.Left = 12;
                pictureBox13.Top = 160;
                SoundPlayer exp = new SoundPlayer();
                exp.SoundLocation = "C:/Users/Jesus/Source/Repos/Pedro/Pedro/Musica/explosion.WAV";
                exp.Play();
                label2.Visible = false;
                label3.Visible = false;
            }
            esqueleto1.Top += es1;
            esqueleto2.Top += es1;
            if (esqueleto1.Bounds.IntersectsWith(pictureBox18.Bounds) && esqueleto2.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                esqueleto1.Top= 342;
                esqueleto2.Top = 342;
            }
            esqueleto3.Top -= es2;
            esqueleto4.Top -= es2;
            esqueleto5.Top -= es2;
            if (esqueleto3.Bounds.IntersectsWith(pictureBox15.Bounds) && esqueleto4.Bounds.IntersectsWith(pictureBox15.Bounds) && 
                esqueleto5.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                esqueleto3.Top = 557;
                esqueleto4.Top = 557;
                esqueleto5.Top = 557;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pictureBox13.Top -= 5;
            }
            if (e.KeyCode == Keys.Left)
            {
                pictureBox13.Left -= 5;
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox13.Left += 5;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox13.Top += 5;
            }
            if (pictureBox13.Bounds.IntersectsWith(entrada1.Bounds))
            {
                label1.Visible = true;
                label2.Visible = false;
            }
            if (pictureBox13.Bounds.IntersectsWith(salida1.Bounds) || pictureBox13.Bounds.IntersectsWith(salida2.Bounds) || 
                pictureBox13.Bounds.IntersectsWith(salida3.Bounds))
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox13.Left = 60;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox78.Bounds))
            {
                pictureBox13.Top = 397;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox79.Bounds))
            {
                pictureBox13.Top = 505;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                pictureBox13.Top = 280;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                pictureBox13.Top = 165;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox13.Top = 150;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                pictureBox13.Top = 20;
            }
            if (pictureBox13.Left < 0)
            {
                pictureBox13.Left = 0;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox19.Bounds))
            {
                pictureBox13.Left = 510;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                pictureBox13.Left = 510;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox13.Left = 580;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox7.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox64.Bounds) ||
                pictureBox13.Bounds.IntersectsWith(pictureBox52.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox87.Bounds))
            {
                pictureBox13.Top = 140;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox46.Bounds))
            {
                pictureBox13.Left = 570;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                pictureBox13.Top = 280;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox51.Bounds))
            {
                pictureBox13.Left = 60;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox11.Bounds) ||
                pictureBox13.Bounds.IntersectsWith(pictureBox44.Bounds))
            {
                pictureBox13.Top = 260;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox47.Bounds))
            {
                pictureBox13.Top = 220;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox48.Bounds))
            {
                pictureBox13.Left = 630;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox62.Bounds))
            {
                pictureBox56.Left = 1500;
                pictureBox63.Left = 1500;
                pictureBox53.Left = 1500;
                pictureBox64.Visible = true;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox5.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox13.Left = 715;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox43.Bounds))
            {
                pictureBox13.Left = 650;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox24.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox69.Bounds))
            {
                pictureBox13.Top = 200;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox70.Bounds))
            {
                pictureBox13.Left = 560;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox23.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox54.Bounds))
            {
                pictureBox13.Left = 784;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox71.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox68.Bounds))
            {
                pictureBox13.Left = 763;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox49.Bounds))
            {
                pictureBox13.Top = 160;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox67.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox25.Bounds))
            {
                pictureBox13.Left = 693;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox45.Bounds) ||
                pictureBox13.Bounds.IntersectsWith(pictureBox65.Bounds))
            {
                pictureBox13.Top = 105;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox42.Bounds))
            {
                pictureBox13.Top = 80;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox75.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox76.Bounds))
            {
                pictureBox13.Left = 826;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox61.Bounds))
            {
                pictureBox13.Left = 842;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox57.Bounds))
            {
                pictureBox13.Top = 160;
            }
            if (pictureBox13.Bounds.IntersectsWith(palanca.Bounds))
            {
                pictureBox57.Left = 1500;
                pictureBox58.Left = 1500;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                pictureBox13.Top = 219;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox22.Bounds))
            {
                pictureBox13.Left = 962;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox74.Bounds))
            {
                pictureBox13.Left = 945;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox59.Bounds))
            {
                pictureBox13.Top = 40;
            }
            if (pictureBox13.Bounds.IntersectsWith(entrada2.Bounds))
            {
                label2.Visible = true;
                label3.Visible = true;
            }
            if (pictureBox13.Bounds.IntersectsWith(salida2.Bounds))
            {
                label2.Visible = false;
                label3.Visible = false;
            }
            if (pictureBox13.Bounds.IntersectsWith(entrada3.Bounds))
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox37.Bounds))
            {
                pictureBox13.Left = 892;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox17.Bounds))
            {
                pictureBox13.Left = 1021;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox81.Bounds) || pictureBox13.Bounds.IntersectsWith(pictureBox85.Bounds))
            {
                pictureBox13.Left = 1004;
            }
            if (pictureBox13.Bounds.IntersectsWith(entrada4.Bounds))
            {
                label7.Visible = true;
                label8.Visible = true;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox82.Bounds))
            {
                pictureBox13.Left = 612;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox83.Bounds))
            {
                pictureBox13.Top = 352;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox84.Bounds))
            {
                pictureBox13.Top = 47;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox86.Bounds))
            {
                pictureBox13.Top = 169;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox88.Bounds))
            {
                pictureBox13.Top = 325;
            }
            if (pictureBox13.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                pictureBox13.Top = 581;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {

        }


        private void resetGame()
        {
            zombiesepeed = 5;
            zombiespeed2 = 5;
            zombiespeed3X = 5;
            zombiespeed3Y = 5;
            ZombieSpeed4 = 5;
            zombiespeed5 = 5;
            cr1 = 5;
            cr2 = 5;
            cr3 = 5;
            cr4 = 5;
            cr5 = 5;
            es1 = 10;
            es2 = 10;
            zombiespeed6 = 5;
            zombiespeed7 = 5;
            
       
            foreach (Control x in this.Controls)
            {
                x.Visible = true;
            }
        }
        private void gameOver(string message)
        {

        }
    }
}
