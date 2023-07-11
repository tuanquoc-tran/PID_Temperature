namespace Usart
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbmCom = new System.Windows.Forms.ComboBox();
            this.cbmBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSenSor = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSendSetPoint = new System.Windows.Forms.Button();
            this.txtSetPoint = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GraphTemp = new ZedGraph.ZedGraphControl();
            this.TimerGraph = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmCom
            // 
            this.cbmCom.FormattingEnabled = true;
            this.cbmCom.Location = new System.Drawing.Point(74, 31);
            this.cbmCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbmCom.Name = "cbmCom";
            this.cbmCom.Size = new System.Drawing.Size(114, 28);
            this.cbmCom.TabIndex = 0;
            // 
            // cbmBaud
            // 
            this.cbmBaud.FormattingEnabled = true;
            this.cbmBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbmBaud.Location = new System.Drawing.Point(74, 69);
            this.cbmBaud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbmBaud.Name = "cbmBaud";
            this.cbmBaud.Size = new System.Drawing.Size(114, 28);
            this.cbmBaud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(195, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 66);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSenSor
            // 
            this.txtSenSor.Location = new System.Drawing.Point(99, 40);
            this.txtSenSor.Name = "txtSenSor";
            this.txtSenSor.Size = new System.Drawing.Size(214, 26);
            this.txtSenSor.TabIndex = 4;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbmBaud);
            this.groupBox1.Controls.Add(this.cbmCom);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SETUP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "COM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 584);
            this.panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnSendSetPoint);
            this.groupBox2.Controls.Add(this.txtSetPoint);
            this.groupBox2.Controls.Add(this.txtSenSor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 459);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TEMPERATURE";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(171, 131);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 38);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnSendSetPoint
            // 
            this.btnSendSetPoint.Location = new System.Drawing.Point(10, 131);
            this.btnSendSetPoint.Name = "btnSendSetPoint";
            this.btnSendSetPoint.Size = new System.Drawing.Size(141, 38);
            this.btnSendSetPoint.TabIndex = 5;
            this.btnSendSetPoint.Text = "Send Set Point";
            this.btnSendSetPoint.UseVisualStyleBackColor = true;
            this.btnSendSetPoint.Click += new System.EventHandler(this.btnSendSetPoint_Click);
            this.btnSendSetPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSetPoint_KeyDown);
            // 
            // txtSetPoint
            // 
            this.txtSetPoint.Location = new System.Drawing.Point(99, 86);
            this.txtSetPoint.Name = "txtSetPoint";
            this.txtSetPoint.Size = new System.Drawing.Size(214, 26);
            this.txtSetPoint.TabIndex = 4;
            this.txtSetPoint.Text = "25";
            this.txtSetPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSetPoint_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "SENSOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "SET POINT";
            // 
            // GraphTemp
            // 
            this.GraphTemp.Location = new System.Drawing.Point(347, 14);
            this.GraphTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GraphTemp.Name = "GraphTemp";
            this.GraphTemp.ScrollGrace = 0D;
            this.GraphTemp.ScrollMaxX = 0D;
            this.GraphTemp.ScrollMaxY = 0D;
            this.GraphTemp.ScrollMaxY2 = 0D;
            this.GraphTemp.ScrollMinX = 0D;
            this.GraphTemp.ScrollMinY = 0D;
            this.GraphTemp.ScrollMinY2 = 0D;
            this.GraphTemp.Size = new System.Drawing.Size(978, 556);
            this.GraphTemp.TabIndex = 8;
            this.GraphTemp.UseExtendedPrintDialog = true;
            // 
            // TimerGraph
            // 
            this.TimerGraph.Tick += new System.EventHandler(this.TimerGraph_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1338, 584);
            this.Controls.Add(this.GraphTemp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PID TEMPERATURE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmCom;
        private System.Windows.Forms.ComboBox cbmBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtSenSor;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendSetPoint;
        private System.Windows.Forms.TextBox txtSetPoint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private ZedGraph.ZedGraphControl GraphTemp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer TimerGraph;
        private System.Windows.Forms.Button btnReset;
    }
}

