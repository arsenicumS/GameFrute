using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int[] arrNams = { 0, 10, 15, 50, 100, 500, 10, 15, 10, 50, 0, 15, 10, 100, 0 };

        object[] arrImege =
        {
            Properties.Resources.banana, Properties.Resources.peach, Properties.Resources.lemon, Properties.Resources.grape, Properties.Resources.melon, Properties.Resources.pear, Properties.Resources.strawberry,Properties.Resources.apple, Properties.Resources.orange, Properties.Resources.kiwi
        };

        Random randomNams = new Random();
        
         Dictionary<int,Image> vales = new Dictionary<int, Image>()
            {
            {0, Properties.Resources._0},
            {10, Properties.Resources._10 },
            {15, Properties.Resources._15},
            {50, Properties.Resources._50 },
            {100, Properties.Resources._100 },
            {500, Properties.Resources._500 }
            };


        int NamRandge()
        {
            int nam = arrNams[randomNams.Next(arrNams.Length)];
            if (nam == 0)
            {
                pointFire.Text = point.Text;
                point.Text = "0";
            }
            else point.Text =
                    Convert.ToString(nam + Convert.ToInt32(point.Text));
            return nam;


        }

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is Panel)
                {
                    Panel pb = (Panel)Controls[i];
                    pb.MouseClick += Click_Picture;
                    pb.MouseEnter += MouseEnter;
                    pb.MouseLeave += MouseLeave;
                    pb.BackgroundImageChanged += BackChanged;

                }
            }


        } 

            // Изменение размера при наведении курсора

        private void MouseLeave(object? sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.Transparent;          
        }
        private void MouseEnter(object? sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.White;
        }

/////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// присвоение тегу индекс №1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackChanged(object? sender, EventArgs e)
        {
            ((Panel)sender).Tag = "1";
        }
        /// <summary>
        /// при клике по многоугольнику меняется фон с рандомным числом 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Click_Picture(object sender, EventArgs e)
        { 
            if ((string)((Panel)sender).Tag == "0")
            {
                int nams = NamRandge();
                ((Panel)sender).BackgroundImage = vales[nams];
                
                if (nams == 0 && (String)pointTeam1.Tag == "1") 
                    NextTeam(pointTeam1, pointTeam2);
                else if (nams == 0 && (String)pointTeam2.Tag == "1") 
                    NextTeam(pointTeam2, pointTeam1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is Panel)
                {
                    Panel pb = (Panel)Controls[i];

                    pb.BackgroundImage = (Image)arrImege[randomNams.Next(arrImege.Length)];
                    pb.Tag = "0";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((String)pointTeam1.Tag == "1") NextTeam(pointTeam1, pointTeam2);            
            else if ((String)pointTeam2.Tag == "1") NextTeam(pointTeam2, pointTeam1);
            
            point.Text = "0";
            
            
        }
        private void NextTeam(object team1 , object team2) 
        {
            ((Label)team1).BackColor = Color.Transparent;
            ((Label)team2).BackColor = Color.White;
            ((Label)team1).Tag = "0";
            ((Label)team2).Tag = "1";
            ((Label)team1).Text = Convert.ToString(Convert.ToInt32(((Label)team1).Text) + Convert.ToInt32(point.Text));
        }
       /* private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Size = new Size(Size.Width * Controls[i].Size.Width / oldFormSize.Width, Size.Height * Controls[i].Size.Height / oldFormSize.Height);
            }
        }
      */
    }
}
