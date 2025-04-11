namespace Schedulink
{
    public partial class Form1 : Form
    {
        //Form Dimensions
        int x;
        int y;

        Student s = new Student("Andreas", "Dimopoulos", "p22038", "ant1805", "p22038@unipi.gr");
        List<Student> students = new List<Student>();

        TextBox txt = new TextBox();
        Button b = new Button();

        public Form1()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            students.Add(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generation();
            monthCalendar1.AddBoldedDate(DateTime.Today.AddDays(2));
            monthCalendar1.AddBoldedDate(DateTime.Today.AddDays(3));
        }

        private void bClick(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < monthCalendar1.BoldedDates.Length; i++)
            {
                MessageBox.Show(monthCalendar1.BoldedDates[i].ToString());
            }
        }

        private void generation()
        {
            //Making the log-in textbox

            txt.Text = "I am Text";
            txt.Size = new Size(x / 4, y / 7);
            txt.Font = new Font("Arial", 11f);
            txt.Location = new Point(3 * x / 8, y / 2);
            txt.Visible = true;
            Controls.Add(txt);

            //Making advance button

            b.Text = "Advance";
            b.Font = new Font("Arial", 11f);
            b.BackColor = Color.White;
            b.Size = new Size(x / 6, y / 6);
            b.Location = new Point(5 * x / 12, y / 2 + 50);
            b.Click += new EventHandler(bClick);
            b.Visible = true;
            Controls.Add(b);
        }
    }
}
