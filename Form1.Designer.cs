
namespace saat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.circularButton3 = new saat.CircularButton();
            this.circularButton2 = new saat.CircularButton();
            this.circularButton1 = new saat.CircularButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 17);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(68)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.minimizebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 29);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizebutton.BackColor = System.Drawing.Color.Brown;
            this.minimizebutton.FlatAppearance.BorderSize = 0;
            this.minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebutton.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minimizebutton.Location = new System.Drawing.Point(485, 1);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(32, 27);
            this.minimizebutton.TabIndex = 5;
            this.minimizebutton.Text = "-";
            this.minimizebutton.UseVisualStyleBackColor = false;
            this.minimizebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MoeumT R", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ZamanBaba";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(521, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "00:00:00.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(68)))), ((int)(((byte)(72)))));
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(393, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 197);
            this.panel3.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(68)))), ((int)(((byte)(72)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 160);
            this.listBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "V1.0-tr";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularButton3
            // 
            this.circularButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton3.BackColor = System.Drawing.Color.Silver;
            this.circularButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.circularButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButton3.FlatAppearance.BorderSize = 0;
            this.circularButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton3.Font = new System.Drawing.Font("MoeumT R", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.circularButton3.ForeColor = System.Drawing.Color.Black;
            this.circularButton3.Location = new System.Drawing.Point(154, 174);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(74, 51);
            this.circularButton3.TabIndex = 8;
            this.circularButton3.Text = "SIFIRLA";
            this.circularButton3.UseVisualStyleBackColor = false;
            this.circularButton3.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton2.BackColor = System.Drawing.Color.Silver;
            this.circularButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.circularButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButton2.FlatAppearance.BorderSize = 0;
            this.circularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(68)))), ((int)(((byte)(72)))));
            this.circularButton2.Location = new System.Drawing.Point(227, 147);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(111, 56);
            this.circularButton2.TabIndex = 5;
            this.circularButton2.Text = "TUR";
            this.circularButton2.UseVisualStyleBackColor = false;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // circularButton1
            // 
            this.circularButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton1.BackColor = System.Drawing.Color.Silver;
            this.circularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.circularButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(68)))), ((int)(((byte)(72)))));
            this.circularButton1.Location = new System.Drawing.Point(44, 147);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(111, 56);
            this.circularButton1.TabIndex = 4;
            this.circularButton1.Text = "BAŞLA";
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.circularButton3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CircularButton circularButton1;
        private CircularButton circularButton2;
        private System.Windows.Forms.Button minimizebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
        private CircularButton circularButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}

