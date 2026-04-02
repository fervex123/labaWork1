namespace labaWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void program_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вишняков Вячеслав Павлович\nГруппа:6102-09.03.01D\nВариант:38","О программе");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeWork homeWork = new HomeWork();
            homeWork.ShowDialog();
        }
    }
}
