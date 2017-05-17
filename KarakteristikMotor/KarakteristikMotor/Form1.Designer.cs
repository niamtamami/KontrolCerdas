namespace KarakteristikMotor
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
            this.textBoxPWM = new System.Windows.Forms.TextBox();
            this.textBoxKecepatan = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRekam = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonKurang = new System.Windows.Forms.Button();
            this.textBoxCOM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // textBoxPWM
            // 
            this.textBoxPWM.Location = new System.Drawing.Point(74, 69);
            this.textBoxPWM.Name = "textBoxPWM";
            this.textBoxPWM.Size = new System.Drawing.Size(100, 20);
            this.textBoxPWM.TabIndex = 0;
            this.textBoxPWM.Text = "0";
            // 
            // textBoxKecepatan
            // 
            this.textBoxKecepatan.Location = new System.Drawing.Point(74, 118);
            this.textBoxKecepatan.Name = "textBoxKecepatan";
            this.textBoxKecepatan.Size = new System.Drawing.Size(100, 20);
            this.textBoxKecepatan.TabIndex = 1;
            this.textBoxKecepatan.Text = "0";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(209, 59);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 47);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PWM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kecepatan";
            // 
            // buttonRekam
            // 
            this.buttonRekam.Location = new System.Drawing.Point(209, 115);
            this.buttonRekam.Name = "buttonRekam";
            this.buttonRekam.Size = new System.Drawing.Size(75, 23);
            this.buttonRekam.TabIndex = 5;
            this.buttonRekam.Text = "Rekam";
            this.buttonRekam.UseVisualStyleBackColor = true;
            this.buttonRekam.Click += new System.EventHandler(this.buttonRekam_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(128, 30);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(209, 30);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(179, 59);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(24, 23);
            this.buttonTambah.TabIndex = 8;
            this.buttonTambah.Text = "+";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonKurang
            // 
            this.buttonKurang.Location = new System.Drawing.Point(179, 88);
            this.buttonKurang.Name = "buttonKurang";
            this.buttonKurang.Size = new System.Drawing.Size(24, 23);
            this.buttonKurang.TabIndex = 9;
            this.buttonKurang.Text = "-";
            this.buttonKurang.UseVisualStyleBackColor = true;
            this.buttonKurang.Click += new System.EventHandler(this.buttonKurang_Click);
            // 
            // textBoxCOM
            // 
            this.textBoxCOM.Location = new System.Drawing.Point(74, 30);
            this.textBoxCOM.Name = "textBoxCOM";
            this.textBoxCOM.Size = new System.Drawing.Size(42, 20);
            this.textBoxCOM.TabIndex = 10;
            this.textBoxCOM.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "COM";
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM100";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCOM);
            this.Controls.Add(this.buttonKurang);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonRekam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxKecepatan);
            this.Controls.Add(this.textBoxPWM);
            this.Name = "Form1";
            this.Text = "Karakteristik Motor DC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPWM;
        private System.Windows.Forms.TextBox textBoxKecepatan;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRekam;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonKurang;
        private System.Windows.Forms.TextBox textBoxCOM;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort;
    }
}

