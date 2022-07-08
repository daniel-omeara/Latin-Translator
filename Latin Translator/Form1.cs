namespace Latin_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMiddle_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = "Center";
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = "Left";
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = "Right";
        }
    }
}