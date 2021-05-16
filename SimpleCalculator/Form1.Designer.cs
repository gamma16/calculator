namespace SimpleCalculator
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
            this.display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.on = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(4, 32);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(433, 41);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.operator_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(175, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "9";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(93, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 70);
            this.button3.TabIndex = 1;
            this.button3.Text = "8";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(7, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 70);
            this.button4.TabIndex = 1;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Plum;
            this.button5.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(261, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 70);
            this.button5.TabIndex = 1;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.operator_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(175, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 70);
            this.button6.TabIndex = 1;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(93, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 70);
            this.button7.TabIndex = 1;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button8.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(7, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 70);
            this.button8.TabIndex = 1;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Plum;
            this.button9.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(261, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 70);
            this.button9.TabIndex = 1;
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.operator_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button10.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(177, 262);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 70);
            this.button10.TabIndex = 1;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button11.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(93, 262);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 70);
            this.button11.TabIndex = 1;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button12.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(7, 262);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 70);
            this.button12.TabIndex = 1;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Plum;
            this.button13.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(261, 338);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 70);
            this.button13.TabIndex = 1;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.operator_click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Aqua;
            this.button14.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(177, 338);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 70);
            this.button14.TabIndex = 1;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.equal_click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Aqua;
            this.button15.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(93, 338);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 70);
            this.button15.TabIndex = 1;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button16.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(7, 338);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 70);
            this.button16.TabIndex = 1;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button_click);
            // 
            // on
            // 
            this.on.BackColor = System.Drawing.Color.Green;
            this.on.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.on.Location = new System.Drawing.Point(348, 110);
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(80, 70);
            this.on.TabIndex = 3;
            this.on.Text = "ON";
            this.on.UseVisualStyleBackColor = false;
            this.on.Click += new System.EventHandler(this.button19_Click);
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.Color.Red;
            this.off.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.off.Location = new System.Drawing.Point(348, 187);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(80, 70);
            this.off.TabIndex = 4;
            this.off.Text = "OFF";
            this.off.UseVisualStyleBackColor = false;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Yellow;
            this.button21.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(348, 264);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(80, 144);
            this.button21.TabIndex = 5;
            this.button21.Text = "C";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(449, 434);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.off);
            this.Controls.Add(this.on);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.clear_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button on;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button button21;
    }
}

