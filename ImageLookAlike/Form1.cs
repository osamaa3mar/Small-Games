using ImageLookAlike.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLookAlike
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int Error = 0;
        int NumberOfMainPicuters = 0;
        int result = 0;
        
        public Form1()
        {
            InitializeComponent();

            CreateRandomPics();
        }
        int NumberOfMainPic()
        {
            int Counter = 0;
            for (int i = 0; i < 16; i++)
            {
                if (pics[i].Tag.ToString() == pictureBox1.Tag.ToString())
                {
                    Counter++;
                }
            }
            return Counter;
        }
        PictureBox RandomImage()
        {
            PictureBox p = new PictureBox();
            int  w= random.Next(1, 4);
            switch (w)
            {
                case 1:
                    p.Image= Resources.apple;
                    p.Tag = 1;
                    break;

                case 2:
                    p.Image = Resources.kiwi;
                    p.Tag = 2;
                    break;
                case 3:
                    p.Image = Resources.dragon;
                    p.Tag = 3;
                    break;
                default:
                    p.Image = Resources.apple;
                    p.Tag = 1;
                    break;
            }
            return p;
        }
        PictureBox[] pics = new PictureBox[16];
        void CreateRandomPics()
        {
            RandomPictures();
            pictureBox1.Tag = RandomImage().Tag;
            if (pictureBox1.Tag.ToString() == "1")
            {
                pictureBox1.Image = Resources.apple;
            }
            if (pictureBox1.Tag.ToString() == "2")
            {
                pictureBox1.Image = Resources.kiwi;
            }
            if (pictureBox1.Tag.ToString() == "3")
            {
                pictureBox1.Image = Resources.dragon;
            }
            NumberOfMainPicuters=NumberOfMainPic();
            label2.Text = NumberOfMainPicuters.ToString();
        }
        
        void RandomPictures()
        {
            for (int i = 0; i < 16; i++)
            {
                pics[i] = RandomImage();
            }
            pictureBox2.Image = pics[0].Image;
            pictureBox2.Tag = pics[0].Tag;
            pictureBox3.Image = pics[1].Image;
            pictureBox3.Tag = pics[1].Tag;
            pictureBox4.Image = pics[2].Image;
            pictureBox4.Tag = pics[2].Tag;
            pictureBox5.Image = pics[3].Image;
            pictureBox5.Tag = pics[3].Tag;
            pictureBox6.Image = pics[4].Image;
            pictureBox6.Tag = pics[4].Tag;
            pictureBox7.Image = pics[5].Image;
            pictureBox7.Tag = pics[5].Tag;
            pictureBox8.Image = pics[6].Image;
            pictureBox8.Tag = pics[6].Tag;
            pictureBox9.Image = pics[7].Image;
            pictureBox9.Tag = pics[7].Tag;
            pictureBox10.Image = pics[8].Image;
            pictureBox10.Tag = pics[8].Tag;
            pictureBox11.Image = pics[9].Image;
            pictureBox11.Tag = pics[9].Tag;
            pictureBox12.Image = pics[10].Image;
            pictureBox12.Tag = pics[10].Tag;
            pictureBox13.Image = pics[11].Image;
            pictureBox13.Tag = pics[11].Tag;
            pictureBox14.Image = pics[12].Image;
            pictureBox14.Tag = pics[12].Tag;
            pictureBox15.Image = pics[13].Image;
            pictureBox15.Tag = pics[13].Tag;
            pictureBox16.Image = pics[14].Image;
            pictureBox16.Tag = pics[14].Tag;
            pictureBox17.Image = pics[15].Image;
            pictureBox17.Tag = pics[15].Tag; 

        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
           
            if (((PictureBox)sender).Tag.ToString() == "1")
            {
                ((PictureBox)sender).Image = Resources.apple;
            }
            if (((PictureBox)sender).Tag.ToString() == "2")
            {
                ((PictureBox)sender).Image = Resources.kiwi;
            }
            if (((PictureBox)sender).Tag.ToString() == "3")
            {
                ((PictureBox)sender).Image = Resources.dragon;
            }
            if (!WrongClick(sender))
            {
                Error++;
                label1.Text = Error.ToString();
                if (Error >=3)
                {
                    if (MessageBox.Show("You Lost ","More than 3 Errors") == DialogResult.OK)
                    {
                        Reset();
                    }
                }
            }
            if (WrongClick(sender))
            {
                ((PictureBox)sender).Enabled = false;
                byte label2c = Convert.ToByte(label2.Text);
                label2c--;
                label2.Text = label2c.ToString();

                result++;
                if (result == NumberOfMainPicuters)
                {
                    
                    if(MessageBox.Show("You WOn") == DialogResult.OK)
                    {
                        Reset();
                    }
                }
                
            }
        }
        bool WrongClick(object sender)
        {
            if ((((PictureBox)sender).Tag.ToString() == "1" && pictureBox1.Tag.ToString() == "1")
                || (((PictureBox)sender).Tag.ToString() == "2" && pictureBox1.Tag.ToString() == "2")
                || (((PictureBox)sender).Tag.ToString() == "3" && pictureBox1.Tag.ToString() == "3"))
            {
                
                return true;
            }
            return false;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            if (WrongClick(sender))
            {
                return;
            }
            else
            {
                ((PictureBox)sender).Image = Resources.Orange_question_mark_svg;
              
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            ClearPics();
        }
        void ClearPics()
        {
            pictureBox2.Image  = Resources.Orange_question_mark_svg;
            pictureBox3.Image  = Resources.Orange_question_mark_svg;
            pictureBox4.Image  = Resources.Orange_question_mark_svg;
            pictureBox5.Image  = Resources.Orange_question_mark_svg;
            pictureBox6.Image  = Resources.Orange_question_mark_svg;
            pictureBox7.Image  = Resources.Orange_question_mark_svg;
            pictureBox8.Image  = Resources.Orange_question_mark_svg;
            pictureBox9.Image  = Resources.Orange_question_mark_svg;
            pictureBox10.Image = Resources.Orange_question_mark_svg;
            pictureBox11.Image = Resources.Orange_question_mark_svg;
            pictureBox12.Image = Resources.Orange_question_mark_svg;
            pictureBox13.Image = Resources.Orange_question_mark_svg;
            pictureBox14.Image = Resources.Orange_question_mark_svg;
            pictureBox15.Image = Resources.Orange_question_mark_svg;
            pictureBox16.Image = Resources.Orange_question_mark_svg;
            pictureBox17.Image = Resources.Orange_question_mark_svg;
            
        }
        void Reset()
        {
            CreateRandomPics();//random pics and show them

            Error = 0;
            label1.Text = "0";
            result = 0;
            panel1.Enabled = false;
            foreach (Control c in panel1.Controls)
            {
                c.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
