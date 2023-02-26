
namespace MyCalcApp
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
            this.ResultScreen = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultScreen
            // 
            this.ResultScreen.BackColor = System.Drawing.Color.Wheat;
            this.ResultScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultScreen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ResultScreen.Location = new System.Drawing.Point(0, 0);
            this.ResultScreen.Name = "ResultScreen";
            this.ResultScreen.ReadOnly = true;
            this.ResultScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResultScreen.Size = new System.Drawing.Size(498, 53);
            this.ResultScreen.TabIndex = 0;
            this.ResultScreen.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnNine);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 179);
            this.panel1.TabIndex = 1;
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Gray;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFive.Location = new System.Drawing.Point(3, 144);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(69, 32);
            this.btnFive.TabIndex = 2;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Gray;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTwo.Location = new System.Drawing.Point(4, 76);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(69, 35);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Gray;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNine.Location = new System.Drawing.Point(3, 16);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(69, 35);
            this.btnNine.TabIndex = 0;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSeven);
            this.panel2.Controls.Add(this.btnEight);
            this.panel2.Controls.Add(this.btnThree);
            this.panel2.Location = new System.Drawing.Point(79, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 176);
            this.panel2.TabIndex = 3;
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Gray;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeven.Location = new System.Drawing.Point(3, 141);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(69, 32);
            this.btnSeven.TabIndex = 2;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Gray;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEight.Location = new System.Drawing.Point(4, 73);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(69, 35);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Gray;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThree.Location = new System.Drawing.Point(4, 13);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(69, 35);
            this.btnThree.TabIndex = 0;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOne);
            this.panel3.Controls.Add(this.btnFour);
            this.panel3.Controls.Add(this.btnSix);
            this.panel3.Location = new System.Drawing.Point(158, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 179);
            this.panel3.TabIndex = 4;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Gray;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOne.Location = new System.Drawing.Point(3, 144);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(69, 32);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Gray;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFour.Location = new System.Drawing.Point(4, 76);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(69, 35);
            this.btnFour.TabIndex = 1;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Gray;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSix.Location = new System.Drawing.Point(3, 16);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(69, 35);
            this.btnSix.TabIndex = 0;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnZero);
            this.panel4.Controls.Add(this.btnRem);
            this.panel4.Controls.Add(this.btndot);
            this.panel4.Location = new System.Drawing.Point(5, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 41);
            this.panel4.TabIndex = 5;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Gray;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEqual.Location = new System.Drawing.Point(0, 215);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(69, 35);
            this.btnEqual.TabIndex = 6;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Gray;
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZero.Location = new System.Drawing.Point(156, 4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(69, 35);
            this.btnZero.TabIndex = 4;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnRem
            // 
            this.btnRem.BackColor = System.Drawing.Color.Gray;
            this.btnRem.FlatAppearance.BorderSize = 0;
            this.btnRem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRem.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRem.Location = new System.Drawing.Point(-1, 3);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(69, 35);
            this.btnRem.TabIndex = 2;
            this.btnRem.Text = "%";
            this.btnRem.UseVisualStyleBackColor = false;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnEqual);
            this.panel5.Controls.Add(this.btnMulti);
            this.panel5.Controls.Add(this.btnSubtract);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnDivide);
            this.panel5.Location = new System.Drawing.Point(426, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(72, 273);
            this.panel5.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Limelight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(0, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "clr";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.Gray;
            this.btnMulti.FlatAppearance.BorderSize = 0;
            this.btnMulti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.Font = new System.Drawing.Font("Limelight", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMulti.Location = new System.Drawing.Point(0, 51);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(69, 35);
            this.btnMulti.TabIndex = 3;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Gray;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Limelight", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubtract.Location = new System.Drawing.Point(0, 174);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(69, 35);
            this.btnSubtract.TabIndex = 2;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Limelight", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(0, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Gray;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Limelight", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivide.Location = new System.Drawing.Point(0, 92);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(69, 35);
            this.btnDivide.TabIndex = 0;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Gray;
            this.btndot.FlatAppearance.BorderSize = 0;
            this.btndot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btndot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndot.Font = new System.Drawing.Font("Limelight", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndot.Location = new System.Drawing.Point(78, 3);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(69, 35);
            this.btndot.TabIndex = 10;
            this.btndot.Text = ".";
            this.btndot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(498, 341);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResultScreen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beez Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btndot;
    }
}

