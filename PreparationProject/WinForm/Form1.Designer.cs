namespace WinForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnReadConfigKeyValue = new System.Windows.Forms.Button();
            this.cmbSelectConfigKey = new System.Windows.Forms.ComboBox();
            this.lblSelectConfigKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(229, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(146, 109);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(57, 22);
            this.txtB.TabIndex = 16;
            this.txtB.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "+";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(31, 109);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(57, 22);
            this.txtA.TabIndex = 14;
            this.txtA.Text = "2";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(28, 257);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 16);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status :";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(88, 257);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(622, 22);
            this.txtStatus.TabIndex = 12;
            // 
            // btnReadConfigKeyValue
            // 
            this.btnReadConfigKeyValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadConfigKeyValue.Location = new System.Drawing.Point(229, 54);
            this.btnReadConfigKeyValue.Name = "btnReadConfigKeyValue";
            this.btnReadConfigKeyValue.Size = new System.Drawing.Size(184, 23);
            this.btnReadConfigKeyValue.TabIndex = 11;
            this.btnReadConfigKeyValue.Text = "ReadConfigKeyValue";
            this.btnReadConfigKeyValue.UseVisualStyleBackColor = true;
            this.btnReadConfigKeyValue.Click += new System.EventHandler(this.btnReadConfigKeyValue_Click);
            // 
            // cmbSelectConfigKey
            // 
            this.cmbSelectConfigKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectConfigKey.FormattingEnabled = true;
            this.cmbSelectConfigKey.Items.AddRange(new object[] {
            "Key1",
            "Key2"});
            this.cmbSelectConfigKey.Location = new System.Drawing.Point(146, 55);
            this.cmbSelectConfigKey.Name = "cmbSelectConfigKey";
            this.cmbSelectConfigKey.Size = new System.Drawing.Size(77, 24);
            this.cmbSelectConfigKey.TabIndex = 10;
            this.cmbSelectConfigKey.Text = "Key1";
            // 
            // lblSelectConfigKey
            // 
            this.lblSelectConfigKey.AutoSize = true;
            this.lblSelectConfigKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectConfigKey.Location = new System.Drawing.Point(28, 57);
            this.lblSelectConfigKey.Name = "lblSelectConfigKey";
            this.lblSelectConfigKey.Size = new System.Drawing.Size(116, 16);
            this.lblSelectConfigKey.TabIndex = 9;
            this.lblSelectConfigKey.Text = "Select config key :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 332);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnReadConfigKeyValue);
            this.Controls.Add(this.cmbSelectConfigKey);
            this.Controls.Add(this.lblSelectConfigKey);
            this.Name = "Form1";
            this.Text = "Windows Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnReadConfigKeyValue;
        private System.Windows.Forms.ComboBox cmbSelectConfigKey;
        private System.Windows.Forms.Label lblSelectConfigKey;
    }
}

