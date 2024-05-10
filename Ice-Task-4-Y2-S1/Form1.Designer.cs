namespace Ice_Task_4_Y2_S1
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
            btnCalculate = new Button();
            rbxDisplay = new RichTextBox();
            panel1 = new Panel();
            txtbxNum2 = new TextBox();
            txtbxNum1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(187, 336);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // rbxDisplay
            // 
            rbxDisplay.Location = new Point(17, 17);
            rbxDisplay.Name = "rbxDisplay";
            rbxDisplay.Size = new Size(430, 260);
            rbxDisplay.TabIndex = 1;
            rbxDisplay.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtbxNum2);
            panel1.Controls.Add(txtbxNum1);
            panel1.Controls.Add(rbxDisplay);
            panel1.Controls.Add(btnCalculate);
            panel1.Location = new Point(44, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 399);
            panel1.TabIndex = 2;
            // 
            // txtbxNum2
            // 
            txtbxNum2.Location = new Point(532, 170);
            txtbxNum2.Name = "txtbxNum2";
            txtbxNum2.Size = new Size(125, 27);
            txtbxNum2.TabIndex = 3;
            txtbxNum2.Text = "Enter Num 2";
            txtbxNum2.MouseClick += txtbxNum2_MouseClick;
            // 
            // txtbxNum1
            // 
            txtbxNum1.Location = new Point(532, 69);
            txtbxNum1.Name = "txtbxNum1";
            txtbxNum1.Size = new Size(125, 27);
            txtbxNum1.TabIndex = 2;
            txtbxNum1.Text = "Enter Num 1";
            txtbxNum1.MouseClick += txtbxNum1_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculate;
        private RichTextBox rbxDisplay;
        private Panel panel1;
        private TextBox txtbxNum2;
        private TextBox txtbxNum1;
    }
}
