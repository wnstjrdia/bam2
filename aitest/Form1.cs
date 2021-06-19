using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aitest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(500, 360);

            pictureBox1.Location = new Point(20, 40);
            pictureBox1.Size = new Size(200, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;


        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image, 200, 50);
            //Bitmap img = (Bitmap)pictureBox1.Image;
            int height = img.Height;
            int width = img.Width;
            int count = 0;
            int hitcount = 0;
            int[] hit = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[,] numtest = new int[10, 6];
            int heightcount = 0;
            bool hitcheck = false;
            int[,,] imgtest = new int[50, 50, 10];

            //Bitmap one = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\one1.png"), 50, 50);

            /*Bitmap two = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\two.png"), 50, 50);
            Bitmap two1 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\two1.png"), 50, 50);//
            Bitmap two2 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\two2.png"), 50, 50);//
            Bitmap two3 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\two3.png"), 50, 50);//
            Bitmap two4 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\two4.png"), 50, 50);//

            Bitmap three = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\three1.png"), 50, 50);
            */

            /*
            Bitmap five = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\five1.png"), 50, 50);
            Bitmap six = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\six1.png"), 50, 50);
            Bitmap seven = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\seven1.png"), 50, 50);
            Bitmap eight = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\eight1.png"), 50, 50);
            Bitmap nine = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\nine1.png"), 50, 50);
            Bitmap zero = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\zero1.png"), 50, 50);
            */

            Bitmap four = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\four1.png"), 50, 50);
            Bitmap four1 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\four2.png"), 50, 50);
            Bitmap four2 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\four3.png"), 50, 50);
            Bitmap four3 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\four4.png"), 50, 50);
            Bitmap four4 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\four5.png"), 50, 50);

            Bitmap plus = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\plus1.png"), 50, 50);
            Bitmap plus1 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\plus2.png"), 50, 50);
            Bitmap plus2 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\plus3.png"), 50, 50);
            Bitmap plus3 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\plus4.png"), 50, 50);
            Bitmap plus4 = new Bitmap(Image.FromFile(@"C:\Users\dlaxo\source\repos\aitest\img\plus5.png"), 50, 50);
            /*int[] learn_one = new int[50* 50];
            int[] learn_two = new int[50* 50];
            int[] learn_two2 = new int[50 * 50];//
            int[] learn_two3 = new int[50 * 50];//
            int[] learn_two4 = new int[50 * 50];//
            int[] learn_two5 = new int[50 * 50];//
            int[] learn_three = new int[50* 50];*/

            /*int[] learn_five = new int[50* 50];
            int[] learn_six = new int[50* 50];
            int[] learn_seven = new int[50* 50];
            int[] learn_eight = new int[50* 50];
            int[] learn_nine = new int[50* 50];
            int[] learn_zero = new int[50* 50];*/

            int[] learn_four = new int[50 * 50];
            int[] learn_four2 = new int[50 * 50];
            int[] learn_four3 = new int[50 * 50];
            int[] learn_four4 = new int[50 * 50];
            int[] learn_four5 = new int[50 * 50];

            int[] learn_plus = new int[50 * 50];
            int[] learn_plus2 = new int[50 * 50];
            int[] learn_plus3 = new int[50 * 50];
            int[] learn_plus4 = new int[50 * 50];
            int[] learn_plus5 = new int[50 * 50];
            int[,] w = new int[6, 50 * 50];
            for (int j = 0; j < 50; j++)//이미지 초기화
            {
                for (int i = 0; i < 50; i++)
                {
                    Color imgcolor;/* = one.GetPixel(j, i);
                    learn_one[(j*50)+ i] = imgcolor.R == 255 ? -1 : 1;

                    imgcolor = two.GetPixel(j, i);
                    learn_two[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = two1.GetPixel(j, i);
                    learn_two2[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;//
                    imgcolor = two2.GetPixel(j, i);
                    learn_two3[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;//
                    imgcolor = two3.GetPixel(j, i);
                    learn_two4[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;//
                    imgcolor = two4.GetPixel(j, i);
                    learn_two5[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;//

                    imgcolor = three.GetPixel(j, i);
                    learn_three[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;*/


                    /*imgcolor = five.GetPixel(j, i);
                    learn_five[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = six.GetPixel(j, i);
                    learn_six[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = seven.GetPixel(j, i);
                    learn_seven[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = eight.GetPixel(j, i);
                    learn_eight[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = nine.GetPixel(j, i);
                    learn_nine[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = zero.GetPixel(j, i);
                    learn_zero[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;*/

                    imgcolor = four.GetPixel(j, i);
                    learn_four[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = four1.GetPixel(j, i);
                    learn_four2[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = four2.GetPixel(j, i);
                    learn_four3[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = four3.GetPixel(j, i);
                    learn_four4[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = four4.GetPixel(j, i);
                    learn_four5[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;

                    imgcolor = plus.GetPixel(j, i);
                    learn_plus[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = plus1.GetPixel(j, i);
                    learn_plus2[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = plus2.GetPixel(j, i);
                    learn_plus3[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = plus3.GetPixel(j, i);
                    learn_plus4[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                    imgcolor = plus4.GetPixel(j, i);
                    learn_plus5[(j * 50) + i] = imgcolor.R == 255 ? -1 : 1;
                }
            }
            string onepp = (Convert.ToString('1', 2));
            int[] onep = new int[6];
            string twopp = (Convert.ToString('2', 2));
            int[] twop = new int[6];
            string threepp = (Convert.ToString('3', 2));
            int[] threep = new int[6];
            //string fourpp = (Convert.ToString('4', 2));
            //int[] fourp = new int[6];
            string fivepp = (Convert.ToString('5', 2));
            int[] fivep = new int[6];
            string sixpp = (Convert.ToString('6', 2));
            int[] sixp = new int[6];
            string sevenpp = (Convert.ToString('7', 2));
            int[] sevenp = new int[6];
            string eightpp = (Convert.ToString('8', 2));
            int[] eightp = new int[6];
            string ninepp = (Convert.ToString('9', 2));
            int[] ninep = new int[6];
            string zeropp = (Convert.ToString('0', 2));
            int[] zerop = new int[6];
            string fourpp = (Convert.ToString('4', 2));
            int[] fourp = new int[6];
            string pluspp = (Convert.ToString('+', 2));
            int[] plusp = new int[6];
            for (int i = 0; i < 6; i++)//숫자들 패턴화
            {
                if (onepp[i] == '0')
                {
                    onep[i] = -1;
                }
                else
                {
                    onep[i] = 1;
                }
                if (twopp[i] == '0')
                {
                    twop[i] = -1;
                }
                else
                {
                    twop[i] = 1;
                }
                if (threepp[i] == '0')
                {
                    threep[i] = -1;
                }
                else
                {
                    threep[i] = 1;
                }
                if (fourpp[i] == '0')
                {
                    fourp[i] = -1;
                }
                else
                {
                    fourp[i] = 1;
                }
                if (fivepp[i] == '0')
                {
                    fivep[i] = -1;
                }
                else
                {
                    fivep[i] = 1;
                }
                if (sixpp[i] == '0')
                {
                    sixp[i] = -1;
                }
                else
                {
                    sixp[i] = 1;
                }
                if (sevenpp[i] == '0')
                {
                    sevenp[i] = -1;
                }
                else
                {
                    sevenp[i] = 1;
                }
                if (eightpp[i] == '0')
                {
                    eightp[i] = -1;
                }
                else
                {
                    eightp[i] = 1;
                }
                if (ninepp[i] == '0')
                {
                    ninep[i] = -1;
                }
                else
                {
                    ninep[i] = 1;
                }
                if (zeropp[i] == '0')
                {
                    zerop[i] = -1;
                }
                else
                {
                    zerop[i] = 1;
                }
                if (pluspp[i] == '0')
                {
                    plusp[i] = -1;
                }
                else
                {
                    plusp[i] = 1;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 50; j++)//w값
                {
                    for (int z = 0; z < 50; z++)
                    {
                        //w[i, (j * 50) + z] += onep[i] * learn_one[(j * 50) + z];
                        /*w[i, (z * 50) + j] += twop[i] * learn_two[(j * 50) + z];
                        w[i, (z * 50) + j] += twop[i] * learn_two2[(j * 50) + z];
                        w[i, (z * 50) + j] += twop[i] * learn_two3[(j * 50) + z];
                        w[i, (z * 50) + j] += twop[i] * learn_two4[(j * 50) + z];
                        w[i, (z * 50) + j] += twop[i] * learn_two5[(j * 50) + z];*/
                        //w[i, (z * 50) + j] += threep[i] * learn_three[(j * 50) + z];

                        //w[i, (z * 50) + j] += fivep[i] * learn_five[(j * 50) + z];
                        //w[i, j, z] += sixp[i] * learn_six[j, z];
                        //w[i, j, z] += sevenp[i] * learn_seven[j, z];
                        //w[i, j, z] += eightp[i] * learn_eight[j, z];
                        //w[i, j, z] += ninep[i] * learn_nine[j, z];
                        //w[i, j, z] += zerop[i] * learn_zero[j, z];
                        w[i, (z * 50) + j] += fourp[i] * learn_four[(j * 50) + z];
                        w[i, (z * 50) + j] += fourp[i] * learn_four2[(j * 50) + z];
                        w[i, (z * 50) + j] += fourp[i] * learn_four3[(j * 50) + z];
                        w[i, (z * 50) + j] += fourp[i] * learn_four4[(j * 50) + z];
                        w[i, (z * 50) + j] += fourp[i] * learn_four5[(j * 50) + z];

                        w[i, (z * 50) + j] += plusp[i] * learn_plus[(j * 50) + z];
                        w[i, (z * 50) + j] += plusp[i] * learn_plus2[(j * 50) + z];
                        w[i, (z * 50) + j] += plusp[i] * learn_plus3[(j * 50) + z];
                        w[i, (z * 50) + j] += plusp[i] * learn_plus4[(j * 50) + z];
                        w[i, (z * 50) + j] += plusp[i] * learn_plus5[(j * 50) + z];
                    }
                }
            }


            int[,] learn_img = new int[width, height];
            for (int i = 0; i < height; i++)//이미지 초기화
            {
                for (int j = 0; j < width; j++)
                {
                    Color imgcolor = img.GetPixel(j, i);
                    learn_img[j, i] = imgcolor.R == 255 ? -1 : 1;
                }
            }
            //textBox1.Text = Convert.ToString(height);

            for (int i = 0; i < width; i++)//분해작업
            {
                for (int j = 0; j < height; j++)
                {
                    if (learn_img[i, j] == -1)//50
                    {
                        heightcount++;
                    }

                    if (hit[hitcount] != 0 && heightcount == 50 && hitcheck)//첫글자를 찾아내고 끝마쳤을때
                    {
                        for (int q = 0; q < count; q++)
                        {
                            for (int a = 0; a < height; a++)
                            {
                                if (q < 50)//(hit[hitcount] + q) < width &&
                                {
                                    imgtest[q, a, hitcount] = learn_img[q + hit[hitcount], a];
                                }
                            }
                        }

                        hitcount++;
                        hitcheck = false;
                        count = 0;
                    }
                }
                if (heightcount != 50)//글자의 첫부분 발견
                {
                    if (hit[hitcount] == 0)
                    {
                        hit[hitcount] = i;
                        hitcheck = true;
                    }
                    count++;
                }
                heightcount = 0;
            }

            for (int hi = 0; hit[hi] != 0; hi++)//글자수만큼 실행
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        for (int z = 0; z < 50; z++)
                        {
                            numtest[hi, i] += w[i, (z * 50) + j] * imgtest[j, z, hi];
                        }
                    }
                }
                for (int z = 0; z < 6; z++)
                {
                    if (numtest[hi, z] < 0)
                    {
                        numtest[hi, z] = 0;
                    }
                    else if (numtest[hi, z] > 0)
                    {
                        numtest[hi, z] = 1;
                    }
                }

            }
            
            int sum = 0;
            string qq = "";
            string p = "";
            for (int i = 0; i < hitcount; i++)//글자넣기
            {
                for (int j = 0; j < 6; j++)
                {
                    qq = qq + Convert.ToString(numtest[i, j]);
                }
                p = p + (char)Convert.ToInt32(qq, 2); ;
                qq = "";
            }
            textBox1.Text = p;

            string[] num = p.Split(new char[] { '+' });
            sum = Convert.ToInt32(num[0]) + Convert.ToInt32(num[1]);
            textBox2.Text = Convert.ToString(sum);
        }
    }
}
