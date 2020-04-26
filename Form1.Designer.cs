namespace calculator
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
            this.button_Equals = new System.Windows.Forms.Button();
            this.button_MC = new System.Windows.Forms.Button();
            this.button_MPlus = new System.Windows.Forms.Button();
            this.button_MR = new System.Windows.Forms.Button();
            this.button_Div = new System.Windows.Forms.Button();
            this.button_Mult = new System.Windows.Forms.Button();
            this.button_Sub = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.button_ABS_IABS = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_Editing = new System.Windows.Forms.GroupBox();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Backspace = new System.Windows.Forms.Button();
            this.button_RBracket = new System.Windows.Forms.Button();
            this.button_LBracket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.textBox_Expression = new System.Windows.Forms.TextBox();
            this.groupBox_Editing.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Equals
            // 
            this.button_Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Equals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Equals.Location = new System.Drawing.Point(281, 345);
            this.button_Equals.Name = "button_Equals";
            this.button_Equals.Size = new System.Drawing.Size(75, 44);
            this.button_Equals.TabIndex = 49;
            this.button_Equals.Text = "=";
            this.button_Equals.UseVisualStyleBackColor = true;
            this.button_Equals.Click += new System.EventHandler(this.button_Equals_Click);
            // 
            // button_MC
            // 
            this.button_MC.Location = new System.Drawing.Point(281, 294);
            this.button_MC.Name = "button_MC";
            this.button_MC.Size = new System.Drawing.Size(75, 44);
            this.button_MC.TabIndex = 48;
            this.button_MC.Text = "MC";
            this.button_MC.UseVisualStyleBackColor = true;
            this.button_MC.Click += new System.EventHandler(this.memoryDigit_Click);
            // 
            // button_MPlus
            // 
            this.button_MPlus.Location = new System.Drawing.Point(281, 244);
            this.button_MPlus.Name = "button_MPlus";
            this.button_MPlus.Size = new System.Drawing.Size(75, 44);
            this.button_MPlus.TabIndex = 47;
            this.button_MPlus.Text = "M+";
            this.button_MPlus.UseVisualStyleBackColor = true;
            this.button_MPlus.Click += new System.EventHandler(this.memoryDigit_Click);
            // 
            // button_MR
            // 
            this.button_MR.Location = new System.Drawing.Point(281, 195);
            this.button_MR.Name = "button_MR";
            this.button_MR.Size = new System.Drawing.Size(75, 44);
            this.button_MR.TabIndex = 46;
            this.button_MR.Text = "MR";
            this.button_MR.UseVisualStyleBackColor = true;
            this.button_MR.Click += new System.EventHandler(this.memoryDigit_Click);
            // 
            // button_Div
            // 
            this.button_Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Div.Location = new System.Drawing.Point(182, 195);
            this.button_Div.Margin = new System.Windows.Forms.Padding(2);
            this.button_Div.Name = "button_Div";
            this.button_Div.Size = new System.Drawing.Size(49, 44);
            this.button_Div.TabIndex = 45;
            this.button_Div.Text = "/";
            this.button_Div.UseVisualStyleBackColor = true;
            this.button_Div.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_Mult
            // 
            this.button_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Mult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Mult.Location = new System.Drawing.Point(182, 244);
            this.button_Mult.Margin = new System.Windows.Forms.Padding(2);
            this.button_Mult.Name = "button_Mult";
            this.button_Mult.Size = new System.Drawing.Size(49, 44);
            this.button_Mult.TabIndex = 44;
            this.button_Mult.Text = "*";
            this.button_Mult.UseVisualStyleBackColor = true;
            this.button_Mult.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_Sub
            // 
            this.button_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Sub.Location = new System.Drawing.Point(182, 294);
            this.button_Sub.Margin = new System.Windows.Forms.Padding(2);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(49, 44);
            this.button_Sub.TabIndex = 43;
            this.button_Sub.Text = "-";
            this.button_Sub.UseVisualStyleBackColor = true;
            this.button_Sub.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Add.Location = new System.Drawing.Point(182, 345);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(49, 44);
            this.button_Add.TabIndex = 42;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_mod
            // 
            this.button_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_mod.Location = new System.Drawing.Point(129, 345);
            this.button_mod.Margin = new System.Windows.Forms.Padding(2);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(49, 44);
            this.button_mod.TabIndex = 41;
            this.button_mod.Text = "mod";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_ABS_IABS
            // 
            this.button_ABS_IABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ABS_IABS.Location = new System.Drawing.Point(23, 345);
            this.button_ABS_IABS.Margin = new System.Windows.Forms.Padding(2);
            this.button_ABS_IABS.Name = "button_ABS_IABS";
            this.button_ABS_IABS.Size = new System.Drawing.Size(49, 44);
            this.button_ABS_IABS.TabIndex = 40;
            this.button_ABS_IABS.Text = "+/-";
            this.button_ABS_IABS.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(76, 345);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(49, 44);
            this.button0.TabIndex = 39;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(129, 294);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 44);
            this.button9.TabIndex = 38;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(76, 294);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 44);
            this.button8.TabIndex = 37;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 294);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 44);
            this.button7.TabIndex = 36;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(129, 244);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 44);
            this.button6.TabIndex = 35;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(76, 244);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 44);
            this.button5.TabIndex = 34;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 244);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 44);
            this.button4.TabIndex = 33;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 195);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 46);
            this.button3.TabIndex = 32;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 45);
            this.button2.TabIndex = 31;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 44);
            this.button1.TabIndex = 30;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // groupBox_Editing
            // 
            this.groupBox_Editing.Controls.Add(this.button_C);
            this.groupBox_Editing.Controls.Add(this.button_Backspace);
            this.groupBox_Editing.Controls.Add(this.button_RBracket);
            this.groupBox_Editing.Controls.Add(this.button_LBracket);
            this.groupBox_Editing.Location = new System.Drawing.Point(16, 104);
            this.groupBox_Editing.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Editing.Name = "groupBox_Editing";
            this.groupBox_Editing.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Editing.Size = new System.Drawing.Size(353, 68);
            this.groupBox_Editing.TabIndex = 29;
            this.groupBox_Editing.TabStop = false;
            this.groupBox_Editing.Text = "Editing";
            // 
            // button_C
            // 
            this.button_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_C.Location = new System.Drawing.Point(265, 17);
            this.button_C.Margin = new System.Windows.Forms.Padding(2);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(75, 39);
            this.button_C.TabIndex = 3;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_Backspace
            // 
            this.button_Backspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Backspace.Location = new System.Drawing.Point(150, 17);
            this.button_Backspace.Margin = new System.Windows.Forms.Padding(2);
            this.button_Backspace.Name = "button_Backspace";
            this.button_Backspace.Size = new System.Drawing.Size(111, 39);
            this.button_Backspace.TabIndex = 2;
            this.button_Backspace.Text = "Backspace";
            this.button_Backspace.UseVisualStyleBackColor = true;
            this.button_Backspace.Click += new System.EventHandler(this.ButtonBackSpace_Click);
            // 
            // button_RBracket
            // 
            this.button_RBracket.Location = new System.Drawing.Point(57, 17);
            this.button_RBracket.Margin = new System.Windows.Forms.Padding(2);
            this.button_RBracket.Name = "button_RBracket";
            this.button_RBracket.Size = new System.Drawing.Size(47, 39);
            this.button_RBracket.TabIndex = 1;
            this.button_RBracket.Text = ")";
            this.button_RBracket.UseVisualStyleBackColor = true;
            this.button_RBracket.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_LBracket
            // 
            this.button_LBracket.Location = new System.Drawing.Point(6, 17);
            this.button_LBracket.Margin = new System.Windows.Forms.Padding(2);
            this.button_LBracket.Name = "button_LBracket";
            this.button_LBracket.Size = new System.Drawing.Size(47, 39);
            this.button_LBracket.TabIndex = 0;
            this.button_LBracket.Text = "(";
            this.button_LBracket.UseVisualStyleBackColor = true;
            this.button_LBracket.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Expression";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Result.Location = new System.Drawing.Point(91, 67);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(276, 37);
            this.textBox_Result.TabIndex = 26;
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Expression
            // 
            this.textBox_Expression.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Expression.Location = new System.Drawing.Point(91, 15);
            this.textBox_Expression.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Expression.Multiline = true;
            this.textBox_Expression.Name = "textBox_Expression";
            this.textBox_Expression.Size = new System.Drawing.Size(278, 37);
            this.textBox_Expression.TabIndex = 25;
            this.textBox_Expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 414);
            this.Controls.Add(this.textBox_Expression);
            this.Controls.Add(this.button_Equals);
            this.Controls.Add(this.button_MC);
            this.Controls.Add(this.button_MPlus);
            this.Controls.Add(this.button_MR);
            this.Controls.Add(this.button_Div);
            this.Controls.Add(this.button_Mult);
            this.Controls.Add(this.button_Sub);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button_ABS_IABS);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_Editing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Result);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(392, 453);
            this.MinimumSize = new System.Drawing.Size(392, 453);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox_Editing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Equals;
        private System.Windows.Forms.Button button_MC;
        private System.Windows.Forms.Button button_MPlus;
        private System.Windows.Forms.Button button_MR;
        private System.Windows.Forms.Button button_Div;
        private System.Windows.Forms.Button button_Mult;
        private System.Windows.Forms.Button button_Sub;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Button button_ABS_IABS;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_Editing;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_Backspace;
        private System.Windows.Forms.Button button_RBracket;
        private System.Windows.Forms.Button button_LBracket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_Expression;
    }
}

