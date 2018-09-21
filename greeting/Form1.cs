using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace greeting
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen whitePen = new Pen(Color.White, 1);
            SoundPlayer dingPlayer = new SoundPlayer(Properties.Resources.ding);
            SoundPlayer shrekPlayer = new SoundPlayer(Properties.Resources.shrek);
            SoundPlayer nightPlayer = new SoundPlayer(Properties.Resources.night);
            Font drawFont = new Font("Arial", 10, FontStyle.Bold);
            Font drawFont1 = new Font("Oswald", 30, FontStyle.Bold);

            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            Thread.Sleep(500);
            g.Clear(Color.Black);
            g.FillEllipse(whiteBrush, 218, 57, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 161, 133, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 275, 157, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 291, 213, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 291, 235, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 308, 239, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 264, 247, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 289, 261, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 309, 271, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 352, 315, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 441, 376, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);
            g.FillEllipse(whiteBrush, 447, 401, 10, 10);
            dingPlayer.Play();
            Thread.Sleep(1000);

            g.DrawLine(whitePen, 223, 62, 280, 162);
            g.DrawLine(whitePen, 166, 138, 269, 252);
            g.DrawLine(whitePen, 280, 162, 296, 218);
            g.DrawLine(whitePen, 296, 218, 296, 240);
            g.DrawLine(whitePen, 296, 240, 313, 244);
            g.DrawLine(whitePen, 313, 244, 314, 276);
            g.DrawLine(whitePen, 269, 252, 314, 276);
            g.DrawLine(whitePen, 314, 276, 357, 320);
            g.DrawLine(whitePen, 357, 320, 446, 381);
            g.DrawLine(whitePen, 446, 381, 452, 406);
            Thread.Sleep(1500);

            g.DrawString("Taurus", drawFont1, blueBrush, 350, 100);
            Thread.Sleep(2000);
            nightPlayer.Play();
            g.DrawString("Taurus (Latin for 'the Bull') is one of the", drawFont, redBrush, 50, 320);
            Thread.Sleep(2000);
            g.DrawString("constellations of the zodiac, which means it", drawFont, redBrush, 50, 340);
            Thread.Sleep(2000);
            g.DrawString("is crossed by the plane of the ecliptic.", drawFont, redBrush, 50, 360);
            Thread.Sleep(2000);
            g.DrawString("Taurus is a large and prominent constellation", drawFont, redBrush, 50, 380);
            Thread.Sleep(2000);
            g.DrawString("in the northern hemisphere's winter sky. It is", drawFont, redBrush, 50, 400);
            Thread.Sleep(2000);
            g.DrawString("one of the oldest constellations, dating back", drawFont, redBrush, 50, 420);
            Thread.Sleep(2000);
            g.DrawString("to at least the Early Bronze Age when it", drawFont, redBrush, 50, 440);
            Thread.Sleep(2000);
            g.DrawString("marked the location of the Sun during the ", drawFont, redBrush, 50, 460);
            Thread.Sleep(2000);
            g.DrawString("spring equinox. Its importance to the", drawFont, redBrush, 50, 480);
            Thread.Sleep(2000);
            g.DrawString("agricultural calendar influenced various bull", drawFont, redBrush, 50, 500);
            Thread.Sleep(2000);
            g.DrawString("figures in the mythologies of Ancient Sumer,", drawFont, redBrush, 50, 520);
            Thread.Sleep(2000);
            g.DrawString("Akkad, Assyria, Babylon, Egypt, Greece, and Rome.", drawFont, redBrush, 50, 540);
            Thread.Sleep(2000);

            g.Clear(Color.Black);
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            Thread.Sleep(2000);
            shrekPlayer.Play();
        }
    }
}
   