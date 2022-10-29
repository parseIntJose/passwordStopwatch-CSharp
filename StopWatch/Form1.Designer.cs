namespace StropWatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_counter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_pswd = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.pictureBox_hint = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label_min = new System.Windows.Forms.Label();
            this.numericUpDown_min = new System.Windows.Forms.NumericUpDown();
            this.button_setMin = new System.Windows.Forms.Button();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.button_changePass = new System.Windows.Forms.Button();
            this.button_newPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).BeginInit();
            this.SuspendLayout();
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Font = new System.Drawing.Font("October Crow", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_counter.ForeColor = System.Drawing.Color.Red;
            this.label_counter.Location = new System.Drawing.Point(688, 386);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(521, 209);
            this.label_counter.TabIndex = 0;
            this.label_counter.Text = "20:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1625, -79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 328);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-49, 905);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 188);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Black;
            this.button_start.Font = new System.Drawing.Font("October Crow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_start.ForeColor = System.Drawing.Color.Red;
            this.button_start.Location = new System.Drawing.Point(748, 646);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(349, 60);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_pswd
            // 
            this.textBox_pswd.BackColor = System.Drawing.Color.Black;
            this.textBox_pswd.Font = new System.Drawing.Font("October Crow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_pswd.ForeColor = System.Drawing.Color.White;
            this.textBox_pswd.Location = new System.Drawing.Point(703, 633);
            this.textBox_pswd.Name = "textBox_pswd";
            this.textBox_pswd.Size = new System.Drawing.Size(328, 39);
            this.textBox_pswd.TabIndex = 4;
            this.textBox_pswd.Text = "DIGITE A SENHA AQUI";
            this.textBox_pswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_pswd.Visible = false;
            this.textBox_pswd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_pswd_MouseClick);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.DarkRed;
            this.button_ok.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ok.Location = new System.Drawing.Point(1048, 633);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(90, 39);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "↩";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Visible = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // pictureBox_hint
            // 
            this.pictureBox_hint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_hint.BackgroundImage")));
            this.pictureBox_hint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_hint.Location = new System.Drawing.Point(80, 2);
            this.pictureBox_hint.Name = "pictureBox_hint";
            this.pictureBox_hint.Size = new System.Drawing.Size(1774, 1007);
            this.pictureBox_hint.TabIndex = 6;
            this.pictureBox_hint.TabStop = false;
            this.pictureBox_hint.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-89, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 188);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(1252, 789);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(382, 405);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(462, -141);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(176, 291);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(1790, 484);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(176, 188);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(-243, 575);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(330, 280);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(576, 985);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(93, 82);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_min.Location = new System.Drawing.Point(12, 14);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(51, 15);
            this.label_min.TabIndex = 14;
            this.label_min.Text = "Minutos";
            // 
            // numericUpDown_min
            // 
            this.numericUpDown_min.BackColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown_min.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.numericUpDown_min.Location = new System.Drawing.Point(68, 12);
            this.numericUpDown_min.Name = "numericUpDown_min";
            this.numericUpDown_min.Size = new System.Drawing.Size(45, 23);
            this.numericUpDown_min.TabIndex = 15;
            this.numericUpDown_min.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // button_setMin
            // 
            this.button_setMin.Location = new System.Drawing.Point(119, 10);
            this.button_setMin.Name = "button_setMin";
            this.button_setMin.Size = new System.Drawing.Size(34, 25);
            this.button_setMin.TabIndex = 16;
            this.button_setMin.Text = "OK";
            this.button_setMin.UseVisualStyleBackColor = true;
            this.button_setMin.Click += new System.EventHandler(this.button_setMin_Click);
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_newPass.Location = new System.Drawing.Point(95, 52);
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.Size = new System.Drawing.Size(78, 23);
            this.textBox_newPass.TabIndex = 18;
            this.textBox_newPass.Text = "472120360";
            this.textBox_newPass.Visible = false;
            // 
            // button_changePass
            // 
            this.button_changePass.Location = new System.Drawing.Point(8, 50);
            this.button_changePass.Name = "button_changePass";
            this.button_changePass.Size = new System.Drawing.Size(81, 25);
            this.button_changePass.TabIndex = 19;
            this.button_changePass.Text = "Trocar senha";
            this.button_changePass.UseVisualStyleBackColor = true;
            this.button_changePass.Click += new System.EventHandler(this.button_changePass_Click);
            // 
            // button_newPass
            // 
            this.button_newPass.Enabled = false;
            this.button_newPass.Location = new System.Drawing.Point(179, 50);
            this.button_newPass.Name = "button_newPass";
            this.button_newPass.Size = new System.Drawing.Size(34, 25);
            this.button_newPass.TabIndex = 20;
            this.button_newPass.Text = "OK";
            this.button_newPass.UseVisualStyleBackColor = true;
            this.button_newPass.Visible = false;
            this.button_newPass.Click += new System.EventHandler(this.button_newPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button_newPass);
            this.Controls.Add(this.button_changePass);
            this.Controls.Add(this.textBox_newPass);
            this.Controls.Add(this.button_setMin);
            this.Controls.Add(this.numericUpDown_min);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox_hint);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_pswd);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_counter);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Halloween Stopwatch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_counter;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button_start;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox_pswd;
        private Button button_ok;
        private PictureBox pictureBox_hint;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label label_min;
        private NumericUpDown numericUpDown_min;
        private Button button_setMin;
        private TextBox textBox_newPass;
        private Button button_changePass;
        private Button button_newPass;
    }
}