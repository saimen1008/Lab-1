namespace Lab_1
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
            this.lblCases = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtCases = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Location = new System.Drawing.Point(41, 49);
            this.lblCases.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(46, 20);
            this.lblCases.TabIndex = 0;
            this.lblCases.Text = "Cases";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(141, 46);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(132, 27);
            this.txtInput.TabIndex = 1;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(326, 49);
            this.lblDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(17, 20);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "1";
            // 
            // txtCases
            // 
            this.txtCases.Location = new System.Drawing.Point(45, 105);
            this.txtCases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCases.Multiline = true;
            this.txtCases.Name = "txtCases";
            this.txtCases.Size = new System.Drawing.Size(328, 186);
            this.txtCases.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(45, 326);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.MinimumSize = new System.Drawing.Size(330, 50);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(330, 50);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(45, 418);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 35);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(157, 418);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(275, 418);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Day";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(412, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtCases);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblCases);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Average Weekly Cases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtCases;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}