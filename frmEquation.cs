namespace Quadratic_Equation
{
    public partial class frmEquation : Form
    {
        public frmEquation()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);

            var equation = new Solver(a, b, c);
            var (x1, x2) = equation.Solve();


            if (a == 0)
            {
                MessageBox.Show("Phương trình không phải là phương trình bậc 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResult1.Text = $"Nghiệm x = {x1.ToString()}";
            }
            else if (x1 == null)
            {
                MessageBox.Show("Phương trình vô nghiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResult1.Text = "N/A";
            }
            else if (x2 == null)
            {
                MessageBox.Show("Phương trình có nghiệm kép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResult1.Text = $"Nghiệm x1 = x2 = {x1.ToString()}";
            }
            else
            {
                MessageBox.Show("Phương trình có hai nghiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResult1.Text = $"Nghiệm x1 = {x1.ToString()} " + $"Nghiệm x2 = {x2.ToString()}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtResult1.Clear();
        }

        private void txtA_Enter(object sender, EventArgs e)
        {
            this.txtB.Focus();
        }
    }
}
