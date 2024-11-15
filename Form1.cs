namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int left = 0;
            int top = 0;
            Button[,] button = new Button[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 50;
                    button[i, j].Height = 50;
                    button[i, j].Top = top;
                    button[i, j].Left = left;
                    left += 50;
                    if (j == 7)
                    {
                        left = 0;
                        top +=50;
                    }
                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;

                    }
                    else {
                        button[i,j].BackColor = Color.White;
                    }

                    this.Controls.Add(button[i, j]);
                }
               
            }
           
            //button.GetUpperBound(1)
        }
    }
}
    
