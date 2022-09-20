namespace WindowsFormsApp1
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
            this.NetId = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxIsConnected = new System.Windows.Forms.CheckBox();
            this.labelMainCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NetId
            // 
            this.NetId.AutoSize = true;
            this.NetId.Location = new System.Drawing.Point(58, 43);
            this.NetId.Name = "NetId";
            this.NetId.Size = new System.Drawing.Size(33, 13);
            this.NetId.TabIndex = 0;
            this.NetId.Text = "NetId";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(58, 99);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(26, 13);
            this.Port.TabIndex = 1;
            this.Port.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(138, 96);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(100, 20);
            this.PortBox.TabIndex = 3;
            this.PortBox.Text = "851";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 403);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(138, 154);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 5;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "main.ncaouter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "main.xboolTest";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "TurnOn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Turn Off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxIsConnected
            // 
            this.checkBoxIsConnected.AutoCheck = false;
            this.checkBoxIsConnected.AutoSize = true;
            this.checkBoxIsConnected.Location = new System.Drawing.Point(253, 159);
            this.checkBoxIsConnected.Name = "checkBoxIsConnected";
            this.checkBoxIsConnected.Size = new System.Drawing.Size(88, 17);
            this.checkBoxIsConnected.TabIndex = 10;
            this.checkBoxIsConnected.Text = "is Connected";
            this.checkBoxIsConnected.UseVisualStyleBackColor = true;
            // 
            // labelMainCounter
            // 
            this.labelMainCounter.AutoSize = true;
            this.labelMainCounter.Location = new System.Drawing.Point(219, 409);
            this.labelMainCounter.Name = "labelMainCounter";
            this.labelMainCounter.Size = new System.Drawing.Size(74, 13);
            this.labelMainCounter.TabIndex = 11;
            this.labelMainCounter.Text = "main.ncaouter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMainCounter);
            this.Controls.Add(this.checkBoxIsConnected);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.NetId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NetId;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxIsConnected;
        private System.Windows.Forms.Label labelMainCounter;
    }
}

