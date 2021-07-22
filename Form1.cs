using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace WebhookSmasher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ImageBox_TextChanged(object sender, EventArgs e)
        {
        }

        // fetches the image and shows it in the box
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var request = WebRequest.Create(ImageBox.Text);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    ImagePictureBox1.Image = Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete.DeleteWebhook(WebhookBox.Text);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Send.SendWebhook(WebhookBox.Text, MessageBox.Text, SenderBox.Text, ImageBox.Text);
        }

        private void SpamWebhook_CheckedChanged(object sender, EventArgs e)
        {
            int delay = Convert.ToInt32(DelayBox.Text);

            if (SpamWebhook.Checked)
                Timer.Start();
            else
                Timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Interval = Convert.ToInt32(DelayBox.Text);
            Spam.SpamWebhook(WebhookBox.Text, MessageBox.Text, SenderBox.Text, ImageBox.Text);
        }
    }
}