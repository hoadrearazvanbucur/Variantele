using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Interfata_Variante_1_10
{
    public class ControlView :Form
    {

        private Panel main = new Panel();
        private Panel picture1 = new Panel();
        private Panel picture2 = new Panel();

        public ControlView()
        {
            viewHome();
            layoutPanels();
            layoutVariante();
        }

        public void viewHome()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 600);
            this.Controls.Add(main);
        }

        public void layoutPanels()
        {
            this.main.Size = new Size(330, this.Height - 60);
            this.main.Location = new Point(10, 10);
            this.main.BorderStyle = BorderStyle.FixedSingle;
            
            this.picture1.Size = new Size((this.Width - 350) / 2-20, this.Height - 60);
            this.picture1.Location = new Point(350, 10);
            this.picture1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(picture1);

            this.picture2.Size = new Size((this.Width - 350) / 2 - 20, this.Height - 60);
            this.picture2.Location = new Point(350+ (this.Width - 350) / 2, 10);
            this.picture2.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(picture2);
        }

        public void layoutVariante()
        {
            Label titlul = new Label();
            layoutTitlul(titlul);
            this.main.Controls.Add(titlul);

            Button varianta1 = new Button();
            layoutVarianta1(varianta1);
            this.main.Controls.Add(varianta1);

            Button varianta2 = new Button();
            layoutVarianta2(varianta2);
            this.main.Controls.Add(varianta2);

            Button varianta3 = new Button();
            layoutVarianta3(varianta3);
            this.main.Controls.Add(varianta3);

            Button varianta4 = new Button();
            layoutVarianta4(varianta4);
            this.main.Controls.Add(varianta4);

            Button varianta5 = new Button();
            layoutVarianta5(varianta5);
            this.main.Controls.Add(varianta5);

            Button varianta6 = new Button();
            layoutVarianta6(varianta6);
            this.main.Controls.Add(varianta6);

            Button varianta7 = new Button();
            layoutVarianta7(varianta7);
            this.main.Controls.Add(varianta7);

            Button varianta8 = new Button();
            layoutVarianta8(varianta8);
            this.main.Controls.Add(varianta8);

            Button varianta9 = new Button();
            layoutVarianta9(varianta9);
            this.main.Controls.Add(varianta9);

            Button varianta10 = new Button();
            layoutVarianta10(varianta10);
            this.main.Controls.Add(varianta10);
        }

        public void layoutTitlul(Label titlul)
        {
            titlul.Text = "Variante";
            titlul.AutoSize = false;
            titlul.Size = new Size(300, 40);
            titlul.Location = new Point(20, 20);
            titlul.TextAlign = ContentAlignment.MiddleCenter;
            titlul.Font = new Font("Calibri", 30, FontStyle.Bold);
        }

        public void layoutVarianta1(Button varianta)
        {
            varianta.Text = "Varianta 1";
            varianta.Size = new Size(150,50);
            varianta.Location = new Point(10, 150);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta1_Click);
        }

        public void layoutVarianta2(Button varianta)
        {
            varianta.Text = "Varianta 2";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(10, 210);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta2_Click);
        }

        public void layoutVarianta3(Button varianta)
        {
            varianta.Text = "Varianta 3";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(10, 270);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta3_Click);
        }

        public void layoutVarianta4(Button varianta)
        {
            varianta.Text = "Varianta 4";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(10, 330);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta4_Click);
        }

        public void layoutVarianta5(Button varianta)
        {
            varianta.Text = "Varianta 5";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(10, 390);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta5_Click);
        }

        public void layoutVarianta6(Button varianta)
        {
            varianta.Text = "Varianta 6";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(170, 150);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta6_Click);
        }

        public void layoutVarianta7(Button varianta)
        {
            varianta.Text = "Varianta 7";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(170, 210);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta7_Click);
        }

        public void layoutVarianta8(Button varianta)
        {
            varianta.Text = "Varianta 8";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(170, 270);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta8_Click);
        }

        public void layoutVarianta9(Button varianta)
        {
            varianta.Text = "Varianta 9";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(170, 330);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta9_Click);
        }

        public void layoutVarianta10(Button varianta)
        {
            varianta.Text = "Varianta 10";
            varianta.Size = new Size(150, 50);
            varianta.Location = new Point(170, 390);
            varianta.Font = new Font("Calibri", 10, FontStyle.Bold | FontStyle.Italic);
            varianta.Click += new EventHandler(varianta10_Click);
        }


        public void varianta1_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta11.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;        
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta12.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);

        }
        public void varianta2_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta21.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta22.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }
        public void varianta3_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta31.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta32.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }
        public void varianta4_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta41.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta42.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }
        public void varianta5_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta51.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta52.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }
        public void varianta6_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta61.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta62.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }
        public void varianta7_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta71.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta72.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }
        public void varianta8_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta81.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta81.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }
        public void varianta9_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta91.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta92.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }
        public void varianta10_Click(object sender, EventArgs e)
        {
            this.picture1.Controls.Clear();
            this.picture2.Controls.Clear();

            PictureBox p = new PictureBox();
            Image im = Image.FromFile(Application.StartupPath + @"\varianta101.png");
            p.Image = im;
            p.Size = picture1.Size;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture1.Controls.Add(p);

            PictureBox p2 = new PictureBox();
            Image im2 = Image.FromFile(Application.StartupPath + @"\varianta102.png");
            p2.Image = im2;
            p2.Size = picture1.Size;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picture2.Controls.Add(p2);
        }

    }
}
