using System.Windows.Forms.VisualStyles;

namespace weekdayscpound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Label[] days;

        private static readonly int[] DaysInMonthList = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

        private void Form1_Load(object sender, EventArgs e)
        {
            //default to current
            dudDOTW.SelectedIndex = (int)DateTime.Now.DayOfWeek;
            dudMonth.SelectedIndex = DateTime.Now.Month - 1;
            nudYear.Value = DateTime.Now.Year;

            //organize labels for output
            days = [lbl1st, lbl2nd, lbl3rd, lbl4th];
        }

        private void LoadDays(object sender, EventArgs e)
        {
            int first = FirstDOTW(dudMonth.SelectedIndex+1, (int)nudYear.Value, dudDOTW.SelectedIndex);
            lbl1st.Text = first.ToString();
            lbl2nd.Text = (first+7).ToString();
            lbl3rd.Text = (first+14).ToString();
            lbl4th.Text = (first+21).ToString();
        }
        
        private static int FirstDOTW(int month, int year, int dotw)
        {
            //first algorithm

            /*
            int a = (14-month) / 12;
            int y = year - a;
            int m = month + (12 * a) - 2;
            int q = y / 4;
            int r = y / 100;
            int s = y / 400;
            int t = (31*m)/12;
            return (dotw - t - s + r - q - y)%7 + 7;
            */


            //second algorithm
            
            //fix for starting the windows form
            if (month == 0) return 1;
            
            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            int y = month < 3 ? year - 1 : year;
            int q = y / 4;
            int r = y / 100;
            int s = y / 400;
            return (dotw - t[month-1] - s + r - q - y) % 7 + 7;


            //third algorithm

            /*
            int m;
            if (month < 3)
            {
                m = month + 10;
                year--;
            }
            else m = month - 2;
            int c = year / 100;
            int y = year % 100;
            int q = (int)Math.Floor((2.6 * m) - 0.2);
            int r = 2 * c;
            int s = y / 4;
            int t = c / 4;
            return (dotw - t - s - y + r - q) % 7 + 7;
            */

        }
    }
}
