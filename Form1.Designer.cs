namespace GKLab3
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBoxReducted = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonReduct = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxReduction = new System.Windows.Forms.GroupBox();
            this.checkBoxH = new System.Windows.Forms.CheckBox();
            this.checkBoxS = new System.Windows.Forms.CheckBox();
            this.checkBoxL = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReducted)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxReduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureBoxOrigin);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pictureBoxReducted);
            this.splitContainer.Size = new System.Drawing.Size(1076, 585);
            this.splitContainer.SplitterDistance = 533;
            this.splitContainer.TabIndex = 0;
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOrigin.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(533, 585);
            this.pictureBoxOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrigin.TabIndex = 0;
            this.pictureBoxOrigin.TabStop = false;
            // 
            // pictureBoxReducted
            // 
            this.pictureBoxReducted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxReducted.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxReducted.Name = "pictureBoxReducted";
            this.pictureBoxReducted.Size = new System.Drawing.Size(539, 585);
            this.pictureBoxReducted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReducted.TabIndex = 0;
            this.pictureBoxReducted.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.buttonReduct);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxReduction);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 526);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1074, 61);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonReduct
            // 
            this.buttonReduct.Location = new System.Drawing.Point(3, 3);
            this.buttonReduct.Name = "buttonReduct";
            this.buttonReduct.Size = new System.Drawing.Size(82, 53);
            this.buttonReduct.TabIndex = 0;
            this.buttonReduct.Text = "Do it!";
            this.buttonReduct.UseVisualStyleBackColor = true;
            this.buttonReduct.Click += new System.EventHandler(this.buttonReduct_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // groupBoxReduction
            // 
            this.groupBoxReduction.Controls.Add(this.checkBoxL);
            this.groupBoxReduction.Controls.Add(this.checkBoxS);
            this.groupBoxReduction.Controls.Add(this.checkBoxH);
            this.groupBoxReduction.Location = new System.Drawing.Point(91, 3);
            this.groupBoxReduction.Name = "groupBoxReduction";
            this.groupBoxReduction.Size = new System.Drawing.Size(375, 44);
            this.groupBoxReduction.TabIndex = 1;
            this.groupBoxReduction.TabStop = false;
            this.groupBoxReduction.Text = "Reduction";
            // 
            // checkBoxH
            // 
            this.checkBoxH.AutoSize = true;
            this.checkBoxH.Checked = true;
            this.checkBoxH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxH.Location = new System.Drawing.Point(6, 17);
            this.checkBoxH.Name = "checkBoxH";
            this.checkBoxH.Size = new System.Drawing.Size(40, 21);
            this.checkBoxH.TabIndex = 0;
            this.checkBoxH.Text = "H";
            this.checkBoxH.UseVisualStyleBackColor = true;
            // 
            // checkBoxS
            // 
            this.checkBoxS.AutoSize = true;
            this.checkBoxS.Checked = true;
            this.checkBoxS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxS.Location = new System.Drawing.Point(110, 17);
            this.checkBoxS.Name = "checkBoxS";
            this.checkBoxS.Size = new System.Drawing.Size(39, 21);
            this.checkBoxS.TabIndex = 1;
            this.checkBoxS.Text = "S";
            this.checkBoxS.UseVisualStyleBackColor = true;
            // 
            // checkBoxL
            // 
            this.checkBoxL.AutoSize = true;
            this.checkBoxL.Checked = true;
            this.checkBoxL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxL.Location = new System.Drawing.Point(214, 17);
            this.checkBoxL.Name = "checkBoxL";
            this.checkBoxL.Size = new System.Drawing.Size(38, 21);
            this.checkBoxL.TabIndex = 2;
            this.checkBoxL.Text = "L";
            this.checkBoxL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 585);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReducted)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxReduction.ResumeLayout(false);
            this.groupBoxReduction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.PictureBox pictureBoxReducted;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonReduct;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.GroupBox groupBoxReduction;
        private System.Windows.Forms.CheckBox checkBoxL;
        private System.Windows.Forms.CheckBox checkBoxS;
        private System.Windows.Forms.CheckBox checkBoxH;
    }
}

