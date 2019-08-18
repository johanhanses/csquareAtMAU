namespace Assignment3G
{
    partial class MainForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.rbtnUsUnit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResultWeightCategory = new System.Windows.Forms.Label();
            this.lblResultYourBMI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(401, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(19, 54);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(66, 15);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height(cm)";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(161, 45);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(54, 23);
            this.txtHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 4;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(22, 89);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(66, 15);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "Weight(kg)";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(161, 89);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(54, 23);
            this.txtWeight.TabIndex = 8;
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(7, 22);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(129, 19);
            this.rbtnMetric.TabIndex = 9;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric Unit (kg cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // rbtnUsUnit
            // 
            this.rbtnUsUnit.AutoSize = true;
            this.rbtnUsUnit.Location = new System.Drawing.Point(7, 48);
            this.rbtnUsUnit.Name = "rbtnUsUnit";
            this.rbtnUsUnit.Size = new System.Drawing.Size(121, 19);
            this.rbtnUsUnit.TabIndex = 10;
            this.rbtnUsUnit.TabStop = true;
            this.rbtnUsUnit.Text = "US Unit (foot, lbs)";
            this.rbtnUsUnit.UseVisualStyleBackColor = true;
            this.rbtnUsUnit.CheckedChanged += new System.EventHandler(this.RbtnUsUnit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMetric);
            this.groupBox1.Controls.Add(this.rbtnUsUnit);
            this.groupBox1.Location = new System.Drawing.Point(329, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Location = new System.Drawing.Point(193, 176);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(182, 41);
            this.btnCalculateBMI.TabIndex = 12;
            this.btnCalculateBMI.Text = "Calculate";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.BtnCalculateBMI_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblResultWeightCategory);
            this.grpResults.Controls.Add(this.lblResultYourBMI);
            this.grpResults.Controls.Add(this.label2);
            this.grpResults.Controls.Add(this.label7);
            this.grpResults.Controls.Add(this.label6);
            this.grpResults.Location = new System.Drawing.Point(25, 277);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(537, 157);
            this.grpResults.TabIndex = 13;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results for";
            // 
            // lblResultWeightCategory
            // 
            this.lblResultWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultWeightCategory.Location = new System.Drawing.Point(220, 69);
            this.lblResultWeightCategory.Name = "lblResultWeightCategory";
            this.lblResultWeightCategory.Size = new System.Drawing.Size(296, 23);
            this.lblResultWeightCategory.TabIndex = 6;
            this.lblResultWeightCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultYourBMI
            // 
            this.lblResultYourBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultYourBMI.Location = new System.Drawing.Point(396, 35);
            this.lblResultYourBMI.Name = "lblResultYourBMI";
            this.lblResultYourBMI.Size = new System.Drawing.Size(120, 24);
            this.lblResultYourBMI.TabIndex = 5;
            this.lblResultYourBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Normal BMI is between  18.50 and 24.90";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Weight Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Your BMI";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 470);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.RadioButton rbtnUsUnit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultYourBMI;
        private System.Windows.Forms.Label lblResultWeightCategory;
    }
}

