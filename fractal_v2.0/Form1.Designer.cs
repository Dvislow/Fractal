namespace fractal_v2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fractPicture = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.A_box = new System.Windows.Forms.TextBox();
            this.qi = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.forX0 = new System.Windows.Forms.TextBox();
            this.B_box = new System.Windows.Forms.TextBox();
            this.C_box = new System.Windows.Forms.TextBox();
            this.D_box = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StarterButton = new System.Windows.Forms.Button();
            this.BigFuckigZoom = new System.Windows.Forms.TrackBar();
            this.rander = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.skip = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BigFuckigZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // fractPicture
            // 
            this.fractPicture.AccumBits = ((byte)(0));
            this.fractPicture.AutoCheckErrors = false;
            this.fractPicture.AutoFinish = false;
            this.fractPicture.AutoMakeCurrent = true;
            this.fractPicture.AutoSwapBuffers = true;
            this.fractPicture.BackColor = System.Drawing.Color.White;
            this.fractPicture.ColorBits = ((byte)(32));
            this.fractPicture.DepthBits = ((byte)(16));
            this.fractPicture.Location = new System.Drawing.Point(13, 13);
            this.fractPicture.Name = "fractPicture";
            this.fractPicture.Size = new System.Drawing.Size(500, 500);
            this.fractPicture.StencilBits = ((byte)(0));
            this.fractPicture.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(633, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "X0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "A";
            // 
            // A_box
            // 
            this.A_box.Location = new System.Drawing.Point(653, 25);
            this.A_box.Name = "A_box";
            this.A_box.Size = new System.Drawing.Size(75, 20);
            this.A_box.TabIndex = 8;
            this.A_box.Text = "0 0";
            // 
            // qi
            // 
            this.qi.Location = new System.Drawing.Point(653, 181);
            this.qi.Name = "qi";
            this.qi.Size = new System.Drawing.Size(75, 20);
            this.qi.TabIndex = 9;
            this.qi.Text = "1/2";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(653, 155);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(75, 20);
            this.count.TabIndex = 10;
            this.count.Text = "10000";
            // 
            // forX0
            // 
            this.forX0.Location = new System.Drawing.Point(653, 129);
            this.forX0.Name = "forX0";
            this.forX0.Size = new System.Drawing.Size(75, 20);
            this.forX0.TabIndex = 11;
            this.forX0.Text = "0,5 0,5";
            // 
            // B_box
            // 
            this.B_box.Location = new System.Drawing.Point(653, 51);
            this.B_box.Name = "B_box";
            this.B_box.Size = new System.Drawing.Size(75, 20);
            this.B_box.TabIndex = 12;
            this.B_box.Text = "0 1";
            // 
            // C_box
            // 
            this.C_box.Location = new System.Drawing.Point(653, 77);
            this.C_box.Name = "C_box";
            this.C_box.Size = new System.Drawing.Size(75, 20);
            this.C_box.TabIndex = 13;
            this.C_box.Text = "1 0";
            // 
            // D_box
            // 
            this.D_box.Location = new System.Drawing.Point(653, 103);
            this.D_box.Name = "D_box";
            this.D_box.Size = new System.Drawing.Size(75, 20);
            this.D_box.TabIndex = 14;
            this.D_box.Text = "1 1";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(570, 475);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 38);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить картинку";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StarterButton
            // 
            this.StarterButton.Location = new System.Drawing.Point(610, 207);
            this.StarterButton.Name = "StarterButton";
            this.StarterButton.Size = new System.Drawing.Size(124, 66);
            this.StarterButton.TabIndex = 6;
            this.StarterButton.Text = "Сгенерировать последовательность";
            this.StarterButton.UseVisualStyleBackColor = true;
            this.StarterButton.Click += new System.EventHandler(this.StarterButton_Click);
            // 
            // BigFuckigZoom
            // 
            this.BigFuckigZoom.Location = new System.Drawing.Point(754, 13);
            this.BigFuckigZoom.Maximum = 10000;
            this.BigFuckigZoom.Name = "BigFuckigZoom";
            this.BigFuckigZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BigFuckigZoom.Size = new System.Drawing.Size(45, 514);
            this.BigFuckigZoom.TabIndex = 22;
            this.BigFuckigZoom.Value = 500;
            this.BigFuckigZoom.Scroll += new System.EventHandler(this.BigFuckigZoom_Scroll);
            // 
            // rander
            // 
            this.rander.Enabled = true;
            this.rander.Interval = 10;
            this.rander.Tick += new System.EventHandler(this.rander_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(5, 520);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Minimum = -5000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(508, 45);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(519, 13);
            this.trackBar2.Maximum = 5000;
            this.trackBar2.Minimum = -5000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 500);
            this.trackBar2.TabIndex = 24;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // skip
            // 
            this.skip.Location = new System.Drawing.Point(560, 207);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(44, 66);
            this.skip.TabIndex = 25;
            this.skip.Text = "Skip";
            this.skip.UseVisualStyleBackColor = true;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(653, 315);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(21, 23);
            this.up.TabIndex = 26;
            this.up.Text = "↑";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(630, 344);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(21, 23);
            this.left.TabIndex = 26;
            this.left.Text = "←";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(676, 344);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(21, 23);
            this.right.TabIndex = 26;
            this.right.Text = "→";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(653, 373);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(21, 23);
            this.down.TabIndex = 26;
            this.down.Text = "↓";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(583, 322);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(21, 23);
            this.plus.TabIndex = 26;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(583, 373);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(21, 23);
            this.minus.TabIndex = 26;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 558);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.down);
            this.Controls.Add(this.right);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.left);
            this.Controls.Add(this.up);
            this.Controls.Add(this.skip);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BigFuckigZoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A_box);
            this.Controls.Add(this.qi);
            this.Controls.Add(this.count);
            this.Controls.Add(this.forX0);
            this.Controls.Add(this.B_box);
            this.Controls.Add(this.C_box);
            this.Controls.Add(this.D_box);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StarterButton);
            this.Controls.Add(this.fractPicture);
            this.Name = "Form1";
            this.Text = "BestProgramForever";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BigFuckigZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl fractPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox A_box;
        private System.Windows.Forms.TextBox qi;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox forX0;
        private System.Windows.Forms.TextBox B_box;
        private System.Windows.Forms.TextBox C_box;
        private System.Windows.Forms.TextBox D_box;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button StarterButton;
        private System.Windows.Forms.TrackBar BigFuckigZoom;
        private System.Windows.Forms.Timer rander;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button skip;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
    }
}

