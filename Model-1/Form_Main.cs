namespace Model_1
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

        }


        private void buttonMastFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MastFunc form2 = new Model_1.Form_MastFunc();
            form2.ShowDialog();
            this.Show();
            textBoxOrigExpression.Text = form2.expression;
        }
    }
}