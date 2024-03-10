namespace CursorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.Arrow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.Help;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.AppStarting;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.WaitCursor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.Cross;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.IBeam;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.No;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.SizeNS;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.SizeWE;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.SizeNWSE;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.SizeNESW;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.SizeAll;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.UpArrow;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.panel1.Cursor = Cursors.Hand;
        }
    }
}
