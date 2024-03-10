namespace CursorTest
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(77, 46);
            button1.TabIndex = 0;
            button1.Text = "Normal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 64);
            button2.Name = "button2";
            button2.Size = new Size(77, 46);
            button2.TabIndex = 1;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(178, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 376);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(12, 116);
            button3.Name = "button3";
            button3.Size = new Size(77, 46);
            button3.TabIndex = 3;
            button3.Text = "Working";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 168);
            button4.Name = "button4";
            button4.Size = new Size(77, 46);
            button4.TabIndex = 4;
            button4.Text = "Busy";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 220);
            button5.Name = "button5";
            button5.Size = new Size(77, 46);
            button5.TabIndex = 5;
            button5.Text = "Precision\r\nSelect";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 272);
            button6.Name = "button6";
            button6.Size = new Size(77, 46);
            button6.TabIndex = 6;
            button6.Text = "Text\r\nSelect";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 324);
            button7.Name = "button7";
            button7.Size = new Size(77, 46);
            button7.TabIndex = 7;
            button7.Text = "No";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(443, 32);
            label1.TabIndex = 8;
            label1.Text = "Move the cursor over this area to test it!";
            // 
            // button8
            // 
            button8.Location = new Point(95, 12);
            button8.Name = "button8";
            button8.Size = new Size(77, 46);
            button8.TabIndex = 9;
            button8.Text = "Vertical\r\nResize";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(95, 64);
            button9.Name = "button9";
            button9.Size = new Size(77, 46);
            button9.TabIndex = 10;
            button9.Text = "Horizontal\r\nResize";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(95, 168);
            button10.Name = "button10";
            button10.Size = new Size(77, 46);
            button10.TabIndex = 12;
            button10.Text = "Diagonal\r\nResize 2";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(95, 116);
            button11.Name = "button11";
            button11.Size = new Size(77, 46);
            button11.TabIndex = 11;
            button11.Text = "Diagonal\r\nResize 1";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(95, 220);
            button12.Name = "button12";
            button12.Size = new Size(77, 46);
            button12.TabIndex = 13;
            button12.Text = "Move";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(95, 272);
            button13.Name = "button13";
            button13.Size = new Size(77, 46);
            button13.TabIndex = 14;
            button13.Text = "Alternate\r\nSelect";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(95, 324);
            button14.Name = "button14";
            button14.Size = new Size(77, 46);
            button14.TabIndex = 15;
            button14.Text = "Link\r\nHand";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            MinimumSize = new Size(639, 416);
            Name = "Form1";
            Text = "Cursor preview tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}
