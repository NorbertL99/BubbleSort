namespace Bubble_Sort
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.upSidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.delayTextBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.numberSix = new System.Windows.Forms.Label();
            this.numberFive = new System.Windows.Forms.Label();
            this.numberFour = new System.Windows.Forms.Label();
            this.numberThree = new System.Windows.Forms.Label();
            this.numberTwo = new System.Windows.Forms.Label();
            this.numberOne = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upSidePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upSidePanel
            // 
            this.upSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upSidePanel.Controls.Add(this.label1);
            this.upSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upSidePanel.Location = new System.Drawing.Point(0, 0);
            this.upSidePanel.Name = "upSidePanel";
            this.upSidePanel.Size = new System.Drawing.Size(784, 100);
            this.upSidePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(261, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bubble Sort";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Gray;
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.delayTextBox);
            this.mainPanel.Controls.Add(this.sortButton);
            this.mainPanel.Controls.Add(this.generateButton);
            this.mainPanel.Controls.Add(this.numberSix);
            this.mainPanel.Controls.Add(this.numberFive);
            this.mainPanel.Controls.Add(this.numberFour);
            this.mainPanel.Controls.Add(this.numberThree);
            this.mainPanel.Controls.Add(this.numberTwo);
            this.mainPanel.Controls.Add(this.numberOne);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 325);
            this.mainPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(411, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sort delay bettwen every step (ms)";
            // 
            // delayTextBox
            // 
            this.delayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delayTextBox.Location = new System.Drawing.Point(495, 106);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(187, 26);
            this.delayTextBox.TabIndex = 12;
            this.delayTextBox.Text = "1000";
            // 
            // sortButton
            // 
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sortButton.Location = new System.Drawing.Point(416, 17);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(334, 48);
            this.sortButton.TabIndex = 11;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.generateButton.Location = new System.Drawing.Point(42, 17);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(334, 48);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate numbers";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // numberSix
            // 
            this.numberSix.AutoSize = true;
            this.numberSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberSix.ForeColor = System.Drawing.Color.Blue;
            this.numberSix.Location = new System.Drawing.Point(664, 187);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(86, 55);
            this.numberSix.TabIndex = 9;
            this.numberSix.Text = "N6";
            // 
            // numberFive
            // 
            this.numberFive.AutoSize = true;
            this.numberFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberFive.ForeColor = System.Drawing.Color.Blue;
            this.numberFive.Location = new System.Drawing.Point(540, 187);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(86, 55);
            this.numberFive.TabIndex = 5;
            this.numberFive.Text = "N5";
            // 
            // numberFour
            // 
            this.numberFour.AutoSize = true;
            this.numberFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberFour.ForeColor = System.Drawing.Color.Blue;
            this.numberFour.Location = new System.Drawing.Point(406, 187);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(86, 55);
            this.numberFour.TabIndex = 4;
            this.numberFour.Text = "N4";
            // 
            // numberThree
            // 
            this.numberThree.AutoSize = true;
            this.numberThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberThree.ForeColor = System.Drawing.Color.Blue;
            this.numberThree.Location = new System.Drawing.Point(290, 187);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(86, 55);
            this.numberThree.TabIndex = 3;
            this.numberThree.Text = "N3";
            // 
            // numberTwo
            // 
            this.numberTwo.AutoSize = true;
            this.numberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberTwo.ForeColor = System.Drawing.Color.Blue;
            this.numberTwo.Location = new System.Drawing.Point(165, 187);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(86, 55);
            this.numberTwo.TabIndex = 2;
            this.numberTwo.Text = "N2";
            // 
            // numberOne
            // 
            this.numberOne.AutoSize = true;
            this.numberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOne.ForeColor = System.Drawing.Color.Blue;
            this.numberOne.Location = new System.Drawing.Point(32, 187);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(86, 55);
            this.numberOne.TabIndex = 1;
            this.numberOne.Text = "N1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Created by: Norbert Lubaszka     Contact: norbert.lubaszka@gmail.com";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 425);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.upSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Bubble Sort";
            this.upSidePanel.ResumeLayout(false);
            this.upSidePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upSidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label numberSix;
        private System.Windows.Forms.Label numberFive;
        private System.Windows.Forms.Label numberFour;
        private System.Windows.Forms.Label numberThree;
        private System.Windows.Forms.Label numberTwo;
        private System.Windows.Forms.Label numberOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delayTextBox;
        private System.Windows.Forms.Label label3;
    }
}

