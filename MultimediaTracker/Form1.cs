namespace MultimediaTracker
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

        private void movieButton_Click(object sender, EventArgs e)
        {
            Movies mov = new Movies();
            mov.ShowDialog();
            this.Close();
        }

        private void tvButton_Click(object sender, EventArgs e)
        {

        }

        private void novelButton_Click(object sender, EventArgs e)
        {

        }

        private void comicButton_Click(object sender, EventArgs e)
        {

        }
    }
}