namespace Quadratic_Equation
{
    partial class frmEquation
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
            label1 = new Label();
            lblInputA = new Label();
            lblInputB = new Label();
            lblInputC = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            lblResult1 = new Label();
            txtResult1 = new TextBox();
            btnSolve = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 36);
            label1.Name = "label1";
            label1.Size = new Size(316, 28);
            label1.TabIndex = 0;
            label1.Text = "PHƯƠNG TRÌNH Ax^2+Bx+C=0";
            // 
            // lblInputA
            // 
            lblInputA.AutoSize = true;
            lblInputA.Location = new Point(166, 104);
            lblInputA.Name = "lblInputA";
            lblInputA.Size = new Size(59, 20);
            lblInputA.TabIndex = 1;
            lblInputA.Text = "Nhập A";
            // 
            // lblInputB
            // 
            lblInputB.AutoSize = true;
            lblInputB.Location = new Point(166, 173);
            lblInputB.Name = "lblInputB";
            lblInputB.Size = new Size(58, 20);
            lblInputB.TabIndex = 2;
            lblInputB.Text = "Nhập B";
            // 
            // lblInputC
            // 
            lblInputC.AutoSize = true;
            lblInputC.Location = new Point(166, 242);
            lblInputC.Name = "lblInputC";
            lblInputC.Size = new Size(58, 20);
            lblInputC.TabIndex = 3;
            lblInputC.Text = "Nhập C";
            // 
            // txtA
            // 
            txtA.Location = new Point(278, 101);
            txtA.Name = "txtA";
            txtA.Size = new Size(316, 27);
            txtA.TabIndex = 4;
            txtA.KeyPress += txtA_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(278, 170);
            txtB.Name = "txtB";
            txtB.Size = new Size(316, 27);
            txtB.TabIndex = 5;
            txtB.KeyPress += txtB_KeyPress;
            // 
            // txtC
            // 
            txtC.Location = new Point(278, 239);
            txtC.Name = "txtC";
            txtC.Size = new Size(316, 27);
            txtC.TabIndex = 6;
            txtC.KeyPress += txtC_KeyPress;
            // 
            // lblResult1
            // 
            lblResult1.AutoSize = true;
            lblResult1.Location = new Point(154, 320);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(82, 20);
            lblResult1.TabIndex = 7;
            lblResult1.Text = "Nghiệm PT";
            // 
            // txtResult1
            // 
            txtResult1.Location = new Point(278, 298);
            txtResult1.Multiline = true;
            txtResult1.Name = "txtResult1";
            txtResult1.ReadOnly = true;
            txtResult1.ScrollBars = ScrollBars.Vertical;
            txtResult1.Size = new Size(316, 71);
            txtResult1.TabIndex = 9;
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(239, 415);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(118, 39);
            btnSolve.TabIndex = 11;
            btnSolve.Text = "Solve";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(508, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 39);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmEquation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 475);
            Controls.Add(btnClear);
            Controls.Add(btnSolve);
            Controls.Add(txtResult1);
            Controls.Add(lblResult1);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblInputC);
            Controls.Add(lblInputB);
            Controls.Add(lblInputA);
            Controls.Add(label1);
            Name = "frmEquation";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblInputA;
        private Label lblInputB;
        private Label lblInputC;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label lblResult1;
        private TextBox txtResult1;
        private Button btnSolve;
        private Button btnClear;
    }
}
