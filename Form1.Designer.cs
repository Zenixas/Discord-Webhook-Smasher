
namespace WebhookSmasher
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
            this.WebhookBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SenderBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ImagePictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SpamWebhook = new System.Windows.Forms.CheckBox();
            this.DelayBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.ImagePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WebhookBox
            // 
            this.WebhookBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebhookBox.Location = new System.Drawing.Point(13, 27);
            this.WebhookBox.Name = "WebhookBox";
            this.WebhookBox.Size = new System.Drawing.Size(404, 20);
            this.WebhookBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Webhook URL";
            // 
            // ImageBox
            // 
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.Location = new System.Drawing.Point(13, 64);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(323, 20);
            this.ImageBox.TabIndex = 3;
            this.ImageBox.TextChanged += new System.EventHandler(this.ImageBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profile Image URL";
            // 
            // SenderBox
            // 
            this.SenderBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SenderBox.Location = new System.Drawing.Point(12, 103);
            this.SenderBox.Name = "SenderBox";
            this.SenderBox.Size = new System.Drawing.Size(405, 20);
            this.SenderBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Webhook Sender Name";
            // 
            // MessageBox
            // 
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageBox.Location = new System.Drawing.Point(13, 142);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(491, 45);
            this.MessageBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message To Send";
            // 
            // ImagePictureBox1
            // 
            this.ImagePictureBox1.Location = new System.Drawing.Point(423, 27);
            this.ImagePictureBox1.Name = "ImagePictureBox1";
            this.ImagePictureBox1.Size = new System.Drawing.Size(75, 75);
            this.ImagePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePictureBox1.TabIndex = 9;
            this.ImagePictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sender\'s image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 193);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(245, 34);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(260, 193);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(244, 34);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SpamWebhook
            // 
            this.SpamWebhook.Location = new System.Drawing.Point(12, 242);
            this.SpamWebhook.Name = "SpamWebhook";
            this.SpamWebhook.Size = new System.Drawing.Size(127, 31);
            this.SpamWebhook.TabIndex = 14;
            this.SpamWebhook.Text = "Spam Webhook";
            this.SpamWebhook.UseVisualStyleBackColor = true;
            this.SpamWebhook.CheckedChanged += new System.EventHandler(this.SpamWebhook_CheckedChanged);
            // 
            // DelayBox
            // 
            this.DelayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelayBox.Location = new System.Drawing.Point(74, 276);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(71, 20);
            this.DelayBox.TabIndex = 15;
            this.DelayBox.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Delay(ms):";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 303);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DelayBox);
            this.Controls.Add(this.SpamWebhook);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ImagePictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SenderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebhookBox);
            this.Name = "Form1";
            this.Text = "Webhook Smasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.ImagePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DelayBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox ImageBox;
        private System.Windows.Forms.PictureBox ImagePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox SenderBox;
        private System.Windows.Forms.CheckBox SpamWebhook;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox WebhookBox;

        #endregion
    }
}

