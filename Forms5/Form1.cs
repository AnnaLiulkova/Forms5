using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Forms5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void Rhomb_Click(object sender, EventArgs e)
        {
            Figure rhomb = new Rhomb(90, 80, 100, 50);
            rhomb.MoveRight();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            Figure square = new Square(100, 100, 80);
            square.MoveRight();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            Figure circle = new Circle(100, 100, 50);
            circle.MoveRight();
        }
    }
}
