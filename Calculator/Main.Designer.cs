namespace Calculator
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.diameter = new System.Windows.Forms.TextBox();
            this.surface = new System.Windows.Forms.TextBox();
            this.pet_tooth = new System.Windows.Forms.TextBox();
            this.flute = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rpm = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.skok = new System.Windows.Forms.TextBox();
            this.typ = new System.Windows.Forms.ComboBox();
            this.speed_tap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.feet_speed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surface:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diameter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pet Tooth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Flute Count:";
            // 
            // diameter
            // 
            this.diameter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.diameter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.diameter.Location = new System.Drawing.Point(84, 59);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(100, 20);
            this.diameter.TabIndex = 4;
            this.diameter.Text = "5";
            this.diameter.TextChanged += new System.EventHandler(this.diameter_TextChanged);
            this.diameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diameter_KeyPress);
            // 
            // surface
            // 
            this.surface.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.surface.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.surface.Location = new System.Drawing.Point(84, 92);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(100, 20);
            this.surface.TabIndex = 5;
            this.surface.Text = "300";
            this.surface.TextChanged += new System.EventHandler(this.surface_TextChanged);
            this.surface.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surface_KeyPress);
            // 
            // pet_tooth
            // 
            this.pet_tooth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pet_tooth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.pet_tooth.Location = new System.Drawing.Point(84, 124);
            this.pet_tooth.Name = "pet_tooth";
            this.pet_tooth.Size = new System.Drawing.Size(100, 20);
            this.pet_tooth.TabIndex = 6;
            this.pet_tooth.Text = "0.01";
            this.pet_tooth.TextChanged += new System.EventHandler(this.pet_tooth_TextChanged);
            this.pet_tooth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pet_tooth_KeyPress);
            // 
            // flute
            // 
            this.flute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.flute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.flute.Location = new System.Drawing.Point(84, 155);
            this.flute.Name = "flute";
            this.flute.Size = new System.Drawing.Size(100, 20);
            this.flute.TabIndex = 7;
            this.flute.Text = "5";
            this.flute.TextChanged += new System.EventHandler(this.flute_TextChanged);
            this.flute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.flute_KeyPress);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(44, 202);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(34, 13);
            this.test.TabIndex = 8;
            this.test.Text = "RPM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Feed:";
            // 
            // rpm
            // 
            this.rpm.Location = new System.Drawing.Point(84, 199);
            this.rpm.Name = "rpm";
            this.rpm.ReadOnly = true;
            this.rpm.Size = new System.Drawing.Size(100, 20);
            this.rpm.TabIndex = 10;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(84, 223);
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            this.speed.Size = new System.Drawing.Size(100, 20);
            this.speed.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Parameters Machines";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tap";
            // 
            // skok
            // 
            this.skok.Location = new System.Drawing.Point(323, 59);
            this.skok.Name = "skok";
            this.skok.Size = new System.Drawing.Size(51, 20);
            this.skok.TabIndex = 14;
            this.skok.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // typ
            // 
            this.typ.FormattingEnabled = true;
            this.typ.Items.AddRange(new object[] {
            "Metric",
            "Inches"});
            this.typ.Location = new System.Drawing.Point(399, 59);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(62, 21);
            this.typ.TabIndex = 15;
            this.typ.Text = "Inches";
            this.typ.TextChanged += new System.EventHandler(this.typ_TextChanged);
            // 
            // speed_tap
            // 
            this.speed_tap.Location = new System.Drawing.Point(487, 60);
            this.speed_tap.Name = "speed_tap";
            this.speed_tap.Size = new System.Drawing.Size(52, 20);
            this.speed_tap.TabIndex = 16;
            this.speed_tap.Text = "50";
            this.speed_tap.TextChanged += new System.EventHandler(this.speed_tap_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Skok / Pitch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Typ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(494, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Speed";
            // 
            // feet_speed
            // 
            this.feet_speed.AutoSize = true;
            this.feet_speed.Location = new System.Drawing.Point(376, 95);
            this.feet_speed.Name = "feet_speed";
            this.feet_speed.Size = new System.Drawing.Size(28, 13);
            this.feet_speed.TabIndex = 20;
            this.feet_speed.Text = "Feet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 265);
            this.Controls.Add(this.feet_speed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.speed_tap);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.skok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.rpm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.test);
            this.Controls.Add(this.flute);
            this.Controls.Add(this.pet_tooth);
            this.Controls.Add(this.surface);
            this.Controls.Add(this.diameter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Calculation prameters to HEIDENHAIN ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox diameter;
        private System.Windows.Forms.TextBox surface;
        private System.Windows.Forms.TextBox pet_tooth;
        private System.Windows.Forms.TextBox flute;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rpm;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox skok;
        private System.Windows.Forms.ComboBox typ;
        private System.Windows.Forms.TextBox speed_tap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label feet_speed;
    }
}

