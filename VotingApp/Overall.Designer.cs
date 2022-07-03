namespace VotingApp
{
    partial class Overall
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
            this.components = new System.ComponentModel.Container();
            this.btnDemoAdd = new System.Windows.Forms.Button();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblU1 = new System.Windows.Forms.Label();
            this.lblU2 = new System.Windows.Forms.Label();
            this.lblU3 = new System.Windows.Forms.Label();
            this.lblU4 = new System.Windows.Forms.Label();
            this.lblU5 = new System.Windows.Forms.Label();
            this.lblU6 = new System.Windows.Forms.Label();
            this.lblNumParties = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDemoAdd
            // 
            this.btnDemoAdd.Location = new System.Drawing.Point(31, 212);
            this.btnDemoAdd.Name = "btnDemoAdd";
            this.btnDemoAdd.Size = new System.Drawing.Size(235, 23);
            this.btnDemoAdd.TabIndex = 1;
            this.btnDemoAdd.Text = "Add";
            this.btnDemoAdd.UseVisualStyleBackColor = true;
            this.btnDemoAdd.Click += new System.EventHandler(this.btnDemoAdd_Click);
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbUnit.Location = new System.Drawing.Point(31, 94);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(121, 24);
            this.cbUnit.TabIndex = 2;
            this.cbUnit.Validating += new System.ComponentModel.CancelEventHandler(this.cbUnit_Validating);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(31, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(235, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(31, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(235, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblU1
            // 
            this.lblU1.AutoSize = true;
            this.lblU1.Location = new System.Drawing.Point(550, 179);
            this.lblU1.Name = "lblU1";
            this.lblU1.Size = new System.Drawing.Size(54, 16);
            this.lblU1.TabIndex = 3;
            this.lblU1.Text = "Unit Info";
            this.lblU1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblU2
            // 
            this.lblU2.AutoSize = true;
            this.lblU2.Location = new System.Drawing.Point(715, 179);
            this.lblU2.Name = "lblU2";
            this.lblU2.Size = new System.Drawing.Size(54, 16);
            this.lblU2.TabIndex = 4;
            this.lblU2.Text = "Unit Info";
            // 
            // lblU3
            // 
            this.lblU3.AutoSize = true;
            this.lblU3.Location = new System.Drawing.Point(550, 287);
            this.lblU3.Name = "lblU3";
            this.lblU3.Size = new System.Drawing.Size(54, 16);
            this.lblU3.TabIndex = 5;
            this.lblU3.Text = "Unit Info";
            // 
            // lblU4
            // 
            this.lblU4.AutoSize = true;
            this.lblU4.Location = new System.Drawing.Point(715, 287);
            this.lblU4.Name = "lblU4";
            this.lblU4.Size = new System.Drawing.Size(54, 16);
            this.lblU4.TabIndex = 6;
            this.lblU4.Text = "Unit Info";
            // 
            // lblU5
            // 
            this.lblU5.AutoSize = true;
            this.lblU5.Location = new System.Drawing.Point(550, 399);
            this.lblU5.Name = "lblU5";
            this.lblU5.Size = new System.Drawing.Size(54, 16);
            this.lblU5.TabIndex = 7;
            this.lblU5.Text = "Unit Info";
            // 
            // lblU6
            // 
            this.lblU6.AutoSize = true;
            this.lblU6.Location = new System.Drawing.Point(715, 399);
            this.lblU6.Name = "lblU6";
            this.lblU6.Size = new System.Drawing.Size(54, 16);
            this.lblU6.TabIndex = 8;
            this.lblU6.Text = "Unit Info";
            // 
            // lblNumParties
            // 
            this.lblNumParties.AutoSize = true;
            this.lblNumParties.Location = new System.Drawing.Point(55, 411);
            this.lblNumParties.Name = "lblNumParties";
            this.lblNumParties.Size = new System.Drawing.Size(0, 16);
            this.lblNumParties.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select voting unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "INFO ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Number of parties :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Overall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumParties);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblU6);
            this.Controls.Add(this.lblU5);
            this.Controls.Add(this.lblU4);
            this.Controls.Add(this.lblU3);
            this.Controls.Add(this.lblU2);
            this.Controls.Add(this.lblU1);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.btnDemoAdd);
            this.Name = "Overall";
            this.Text = "DemoForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDemoAdd;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblU1;
        private System.Windows.Forms.Label lblU2;
        private System.Windows.Forms.Label lblU3;
        private System.Windows.Forms.Label lblU4;
        private System.Windows.Forms.Label lblU5;
        private System.Windows.Forms.Label lblU6;
        private System.Windows.Forms.Label lblNumParties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}