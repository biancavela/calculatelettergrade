using System.Web;

namespace calculate_letter_grade
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

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double score = Convert.ToDouble(txtNumberGrade.Text);
            if (score >= 90)
                txtLetterGrade.Text = "A";
            else if (score >= 80)
                txtLetterGrade.Text = "B";
            else if (score >= 70)
                txtLetterGrade.Text = "C";
            else if (score >= 60)
                txtLetterGrade.Text = "D";
            else
                txtLetterGrade.Text = "F";    
            }
        }
    }
