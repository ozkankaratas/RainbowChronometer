using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace saat
{
    public partial class Form1 : Form
    {

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        Stopwatch stopWatch;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public Form1()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
            random = new Random();
            circularButton2.Enabled = false;
            circularButton3.Enabled = false;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = color;
                    circularButton2.ForeColor = color;
                    circularButton1.ForeColor = color;
                    currentButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    panel2.BackColor = color;
                    listBox1.BackColor = ThemeColor.ChangeColorBrightness(color, -0.4);
                    panel3.BackColor = ThemeColor.ChangeColorBrightness(color, -0.4);
                    panel1.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in button1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = Color.FromArgb(175, 68, 72);
                    previousBtn.Font = new System.Drawing.Font("MoeumT R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                }
            }
        }

        // SURUKLENEBILIRILIK


        private void button1_Click(object sender, EventArgs e)  // Shotdown
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e) // Minimize
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void circularButton1_Click(object sender, EventArgs e) // Basla - Durdur
        {
            stopWatch.Start();
            circularButton2.Enabled = true;
            circularButton3.Enabled = true;
            circularButton1.Text = "DUR";
            circularButton1.Click -= circularButton1_Click;
            circularButton1.Click += circularButton1_SecondClick;
            ActivateButton(sender);
        }
        private void circularButton1_SecondClick(object sender, EventArgs e) // Basla - Durdur
        {
            circularButton2.Enabled = false;
            circularButton1.Text = "BAŞLA";
            stopWatch.Stop();
            circularButton1.Click -= circularButton1_SecondClick;
            circularButton1.Click += circularButton1_Click;
        }

        private void circularButton2_Click(object sender, EventArgs e) // Tur-Trip
        {
            ActivateButton(sender);
            listBox1.Items.Add(listBox1.Items.Count + 1 + ".  " + label2.Text);
        }

        private void circularButton3_Click(object sender, EventArgs e) // sifirla
        {
            circularButton1.Text = "BAŞLA";
            circularButton2.Enabled = false;
            circularButton3.Enabled = false;
            listBox1.Items.Clear();
            stopWatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", stopWatch.Elapsed);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        new int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }


    }
}

