namespace WinFormsApp1_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dauvao_TextChanged(object sender, EventArgs e)
        {
            daura.Text = dauvao.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radBlue.Checked = true;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            daura.ForeColor = Color.Red;
        }

        private void radYellow_CheckedChanged(object sender, EventArgs e)
        {
            daura.ForeColor = Color.Yellow;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            daura.ForeColor = Color.Blue;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            daura.ForeColor = Color.Green;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            daura.Font = new Font(daura.Font.Name, daura.Font.Size, daura.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            daura.Font = new Font(daura.Font.Name, daura.Font.Size, daura.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            daura.Font = new Font(daura.Font.Name, daura.Font.Size, daura.Font.Style ^ FontStyle.Underline);
        }
    }
}