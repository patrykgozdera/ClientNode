﻿namespace tsst_client
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.message_tb = new System.Windows.Forms.TextBox();
            this.logs_list = new System.Windows.Forms.ListBox();
            this.send = new System.Windows.Forms.Button();
            this.receive_logs_list = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nb_of_m_tb = new System.Windows.Forms.TextBox();
            this.delay_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_capacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deallocate_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_tb
            // 
            this.message_tb.Location = new System.Drawing.Point(12, 12);
            this.message_tb.Name = "message_tb";
            this.message_tb.Size = new System.Drawing.Size(490, 20);
            this.message_tb.TabIndex = 0;
            // 
            // logs_list
            // 
            this.logs_list.FormattingEnabled = true;
            this.logs_list.HorizontalScrollbar = true;
            this.logs_list.Location = new System.Drawing.Point(12, 135);
            this.logs_list.Name = "logs_list";
            this.logs_list.Size = new System.Drawing.Size(238, 264);
            this.logs_list.TabIndex = 3;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(319, 78);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(90, 34);
            this.send.TabIndex = 4;
            this.send.Text = "SEND MESSAGE(S)";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // receive_logs_list
            // 
            this.receive_logs_list.FormattingEnabled = true;
            this.receive_logs_list.HorizontalScrollbar = true;
            this.receive_logs_list.Location = new System.Drawing.Point(256, 135);
            this.receive_logs_list.Name = "receive_logs_list";
            this.receive_logs_list.Size = new System.Drawing.Size(246, 264);
            this.receive_logs_list.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // nb_of_m_tb
            // 
            this.nb_of_m_tb.Location = new System.Drawing.Point(12, 55);
            this.nb_of_m_tb.Name = "nb_of_m_tb";
            this.nb_of_m_tb.Size = new System.Drawing.Size(80, 20);
            this.nb_of_m_tb.TabIndex = 6;
            this.nb_of_m_tb.Text = "1";
            // 
            // delay_tb
            // 
            this.delay_tb.Location = new System.Drawing.Point(105, 55);
            this.delay_tb.Name = "delay_tb";
            this.delay_tb.Size = new System.Drawing.Size(40, 20);
            this.delay_tb.TabIndex = 7;
            this.delay_tb.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NbOfMessages";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(102, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sent messages:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Received messages:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "SET THE CONNECTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(319, 40);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(72, 20);
            this.destinationTextBox.TabIndex = 19;
            this.destinationTextBox.Text = "Babacki";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Destination";
            // 
            // textBox_capacity
            // 
            this.textBox_capacity.Location = new System.Drawing.Point(151, 55);
            this.textBox_capacity.Name = "textBox_capacity";
            this.textBox_capacity.Size = new System.Drawing.Size(79, 20);
            this.textBox_capacity.TabIndex = 21;
            this.textBox_capacity.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Capacity (Mb/s)";
            // 
            // deallocate_b
            // 
            this.deallocate_b.Location = new System.Drawing.Point(412, 77);
            this.deallocate_b.Name = "deallocate_b";
            this.deallocate_b.Size = new System.Drawing.Size(90, 35);
            this.deallocate_b.TabIndex = 23;
            this.deallocate_b.Text = "DEALLOCATE";
            this.deallocate_b.UseVisualStyleBackColor = true;
            this.deallocate_b.Click += new System.EventHandler(this.deallocate_b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 411);
            this.Controls.Add(this.deallocate_b);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_capacity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delay_tb);
            this.Controls.Add(this.nb_of_m_tb);
            this.Controls.Add(this.receive_logs_list);
            this.Controls.Add(this.send);
            this.Controls.Add(this.logs_list);
            this.Controls.Add(this.message_tb);
            this.Name = "Form1";
            this.Text = "Client Node";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_tb;
        private System.Windows.Forms.ListBox logs_list;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ListBox receive_logs_list;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox nb_of_m_tb;
        private System.Windows.Forms.TextBox delay_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_capacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deallocate_b;
    }
}

