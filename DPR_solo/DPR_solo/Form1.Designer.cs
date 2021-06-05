
namespace DPR_solo
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
            this.components = new System.ComponentModel.Container();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnUnsub = new System.Windows.Forms.Button();
            this.txbFN = new System.Windows.Forms.TextBox();
            this.txbLN = new System.Windows.Forms.TextBox();
            this.lblDistributor = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.rbtnIndividual = new System.Windows.Forms.RadioButton();
            this.rbtnOrganization = new System.Windows.Forms.RadioButton();
            this.lblCN = new System.Windows.Forms.Label();
            this.txbCN = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(84, 77);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(100, 37);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "Subscribe";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnUnsub
            // 
            this.btnUnsub.Location = new System.Drawing.Point(329, 77);
            this.btnUnsub.Name = "btnUnsub";
            this.btnUnsub.Size = new System.Drawing.Size(100, 37);
            this.btnUnsub.TabIndex = 2;
            this.btnUnsub.Text = "Unsubscribe";
            this.btnUnsub.UseVisualStyleBackColor = true;
            this.btnUnsub.Click += new System.EventHandler(this.btnUnsub_Click);
            // 
            // txbFN
            // 
            this.txbFN.Location = new System.Drawing.Point(58, 48);
            this.txbFN.Name = "txbFN";
            this.txbFN.Size = new System.Drawing.Size(100, 20);
            this.txbFN.TabIndex = 3;
            this.txbFN.Visible = false;
            // 
            // txbLN
            // 
            this.txbLN.Location = new System.Drawing.Point(223, 48);
            this.txbLN.Name = "txbLN";
            this.txbLN.Size = new System.Drawing.Size(100, 20);
            this.txbLN.TabIndex = 4;
            this.txbLN.Visible = false;
            // 
            // lblDistributor
            // 
            this.lblDistributor.AutoSize = true;
            this.lblDistributor.Location = new System.Drawing.Point(126, 13);
            this.lblDistributor.Name = "lblDistributor";
            this.lblDistributor.Size = new System.Drawing.Size(35, 13);
            this.lblDistributor.TabIndex = 5;
            this.lblDistributor.Text = "label1";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(0, 51);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(55, 13);
            this.lblFN.TabIndex = 6;
            this.lblFN.Text = "Firstname:";
            this.lblFN.Visible = false;
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(164, 51);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(56, 13);
            this.lblLN.TabIndex = 7;
            this.lblLN.Text = "Lastname:";
            this.lblLN.Visible = false;
            // 
            // rbtnIndividual
            // 
            this.rbtnIndividual.AutoSize = true;
            this.rbtnIndividual.Location = new System.Drawing.Point(506, 13);
            this.rbtnIndividual.Name = "rbtnIndividual";
            this.rbtnIndividual.Size = new System.Drawing.Size(70, 17);
            this.rbtnIndividual.TabIndex = 8;
            this.rbtnIndividual.TabStop = true;
            this.rbtnIndividual.Text = "Individual";
            this.rbtnIndividual.UseVisualStyleBackColor = true;
            this.rbtnIndividual.CheckedChanged += new System.EventHandler(this.rbtnIndividual_CheckedChanged);
            // 
            // rbtnOrganization
            // 
            this.rbtnOrganization.AutoSize = true;
            this.rbtnOrganization.Location = new System.Drawing.Point(506, 36);
            this.rbtnOrganization.Name = "rbtnOrganization";
            this.rbtnOrganization.Size = new System.Drawing.Size(84, 17);
            this.rbtnOrganization.TabIndex = 9;
            this.rbtnOrganization.TabStop = true;
            this.rbtnOrganization.Text = "Organization";
            this.rbtnOrganization.UseVisualStyleBackColor = true;
            this.rbtnOrganization.CheckedChanged += new System.EventHandler(this.rbtnOrganization_CheckedChanged);
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Location = new System.Drawing.Point(81, 50);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(80, 13);
            this.lblCN.TabIndex = 10;
            this.lblCN.Text = "Company name";
            this.lblCN.Visible = false;
            // 
            // txbCN
            // 
            this.txbCN.Location = new System.Drawing.Point(183, 47);
            this.txbCN.Name = "txbCN";
            this.txbCN.Size = new System.Drawing.Size(100, 20);
            this.txbCN.TabIndex = 11;
            this.txbCN.Visible = false;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(390, 46);
            this.txbAddress.MaxLength = 6;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(100, 20);
            this.txbAddress.TabIndex = 12;
            this.txbAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Postcode:";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(58, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 108);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 266);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbCN);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.rbtnOrganization);
            this.Controls.Add(this.rbtnIndividual);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblDistributor);
            this.Controls.Add(this.txbLN);
            this.Controls.Add(this.txbFN);
            this.Controls.Add(this.btnUnsub);
            this.Controls.Add(this.btnSub);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnUnsub;
        private System.Windows.Forms.TextBox txbFN;
        private System.Windows.Forms.TextBox txbLN;
        private System.Windows.Forms.Label lblDistributor;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.RadioButton rbtnIndividual;
        private System.Windows.Forms.RadioButton rbtnOrganization;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.TextBox txbCN;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

