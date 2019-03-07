using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace DinoRunTest
{
    public partial class screen : Form
    {
        #region
        bool jump; //Biến luận lý khủng long nhảy
        //bool godown; 
        bool exit; //Biến luận lý thoát game
        bool restart;//Biến luận lý bắt đầu lại game
        //bool mute;
        int score = 0;//Biến nguyên điểm số
        int highscore;//Biến nguyên điểm cao
        int speed = 9;//Biến nguyên tốc độ game
        Random rand = new Random(); //Lấy ngẫu nhiên giá trị
        int playerSpeed = 36; //Biến nguyên tốc độ khủng long
        int gravity=3;//Biến nguyên trọng lực
        int index;//Biến nguyên để lấy giá trị ngẫu nhiên
        int[] b={250,600,850,1000,1300,2000,2600,3000,3300};//Mảng lưu điểm để tăng tốc độ
        int[] a = { 150,300,450,600,750,900,1050,1200,1350,1500,1650,1800,1950,2100,
                    2250,2400,2550,2700,2850,3000,3150,3300,3450,3600,3750,3900,4050,
                    4200,4350,4500};//Mảng lưu điểm để phát âm khi đạt các mức điểm
        int Force;//Mức nhảy
        SoundPlayer jumpaudio = new SoundPlayer(DinoRunTest.Properties.Resources.jump);
        SoundPlayer scoreaudio = new SoundPlayer(DinoRunTest.Properties.Resources.score);
        SoundPlayer dieaudio = new SoundPlayer(DinoRunTest.Properties.Resources.die);
        #endregion   //Khởi tạo các biến giá trị
        public screen()
        {
            InitializeComponent(); 
        }//Khởi tạo form
        private void Form1_Load(object sender, EventArgs e)
        {

        } //Load form (Những picturebox và label bên design)
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)                          //Nếu nhấn phím mũi tên lên 
            if ((Trex.Top == LineRun.Top - Trex.Height + 10)) //và vị trí của khủng long đang ở mặt đất
            {                                                //thì khủng long sẽ 
                jump = true;                                //nhảy
                    Force = playerSpeed;                   //một khoảng force=playerspeed
                    jumpaudio.Play();                     //và đồng thời sẽ phát ra âm thanh nhảy  
                }
            //if (e.KeyCode == Keys.Down)
            //{
            //    godown = true;
            //}
            //if (e.KeyCode == Keys.M)
            //{
            //    mute = true;
            //}
            if (e.KeyCode == Keys.Space)
            {
                if ((Trex.Top == LineRun.Top - Trex.Height + 10)) //Nếu nhấn phím space
                {                                                //và vị trí của khủng long đang ở mặt đất
                    jump = true;                                //thì khủng long sẽ 
                    Force = playerSpeed;                       //nhảy
                    jumpaudio.Play();                         //một khoảng force=playerspeed
                }                                            //và đồng thời sẽ phát ra âm thanh nhảy  
            }
            if (e.KeyCode == Keys.Enter)                         //Nếu nhấn phím Enter
                if (Trex.Bounds.IntersectsWith(Cactus.Bounds))  //và khủng long đụng chướng ngại vật(Xương rồng)
                {                                              //thì
                    restart = true;                           //cho phép bắt đầu lại game
                }
         
            if (e.KeyCode == Keys.Escape)//Nếu nhấn phím Escape
                exit = true;            //Thoát chương trình
        }//hàm bắt keyboard
        private void keyisup(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
                restart = false;
            //if (e.KeyCode == Keys.Down)
            //{

            //    godown = false;
            //}
            if (e.KeyCode == Keys.Escape)
                exit = false;
        }
        private void makeLineRun()
        {
            PictureBox LineRunNew = new PictureBox();//Khởi tạo một picturebox
            LineRunNew.Image = LineRun.Image;       //Gán ảnh của picturebox này 
            LineRunNew.Height = LineRun.Height;    //bằng ảnh của picturebox_linerun ở phần design
            LineRunNew.Width = LineRun.Width;     //và cả kích thước cũng bằng 
            LineRunNew.Left = 300;               //kích thước của picturebox_linerun ở phần design
            LineRunNew.Top = LineRun.Top;       //vị trí nằm sau picturebox_linerun ở phần design
            LineRunNew.Tag = "linerun";        //gán tag
            this.Controls.Add(LineRunNew);    //và add vào control để quản lí trong quá trình game chạy  
        }// Hàm tạo đường chạy của khủng long
        private void changeCactus()
        {
           
            index = rand.Next(1, 9); // Lấy ngẫu nhiên 1 số từ 1 đến 9
            switch (index)
            {
                case 1:   
                    Cactus.Top = 425;
                    Cactus.Image = Properties.Resources.smallcatus_1;
                    Cactus.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 2:
                    Cactus.Top = 425;
                    Cactus.Image = Properties.Resources.smallcatus_2_1;
                    Cactus.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 3:
                    Cactus.Top = 425;
                    Cactus.Image = Properties.Resources.smallcatus_2;
                    Cactus.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 4:
                    Cactus.Top = 425;
                    Cactus.Image = Properties.Resources.smallcatus_3;
                    Cactus.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 5:
                    Cactus.Top = 400;
                    Cactus.Image = Properties.Resources.largecatus_1;
                    Cactus.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 6:
                    Cactus.Top = 400;
                    Cactus.Image = Properties.Resources.largecatus_2;
                    Cactus.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 7:
                    Cactus.Top = 400;
                    Cactus.Image = Properties.Resources.largecatus_2_1;
                    Cactus.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 8:
                    Cactus.Top = 400;
                    Cactus.Image = Properties.Resources.largecatus_3_1;
                    Cactus.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
            }//Chọn ra một ảnh từ số lấy ngẫu nhiên
        }//Hàm thay đổi cây xương rồng

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(mute==true)
            //{
            //    scoreaudio.Stop();
            //    jumpaudio.Stop();
            //    dieaudio.Stop();
            //}
            score += 1; //Tăng điểm khi bắt đầu game
            LineRun.Left -= speed;//Picturebox di chuyển sang trái màn hình theo tốc độ speed tạo hiệu ứng chạy
            foreach (int x in a)
            {
                if (x == score)
                    scoreaudio.Play();
            }//Sau mỗi móc điểm nhất định trong mảng a sẽ phát âm thanh ghi điểm
            foreach (int x in b)
            {
                if (score == x)
                {
                    speed += 6;
                    gravity += 3;
                    playerSpeed += 15;
                }
            }//Sau mỗi móc điểm nhất định trong mảng b sẽ tăng tốc độ game
            Label_Score.Text = " "+score;//Hiển thị điểm lên Label
            Cactus.Left -= speed;//Xương rồng di chuyển sang trái theo tốc độ speed
            Cloud_1.Left -= speed;//Mây di chuyển sang trái theo tốc độ speed
            Cloud_2.Left -= speed;//Mây di chuyển sang trái theo tốc độ speed
            Cloud_3.Left -= speed;//Mây di chuyển sang trái theo tốc độ speed
            if (exit ==true)//Thoát chương trình
                this.Close();
            if (Cloud_1.Left < -150)//Đặt lại vị trí của mây khi chạy ra khỏi màn hình
                Cloud_1.Left = 1100;               
            if (Cloud_2.Left < -500)//Đặt lại vị trí của mây khi chạy ra khỏi màn hình
                Cloud_2.Left = 2500;
            if (Cloud_3.Left < -300)//Đặt lại vị trí của mây khi chạy ra khỏi màn hình
                Cloud_3.Left = 1500;
            if (Cactus.Left < -150)//Đặt lại vị trí của xương rồng khi chạy ra khỏi màn hình
            {
                Cactus.Left = rand.Next(1100, 1200);//Đặt lại vị trí của xương rồng trong khoảng (1100-1200)
                changeCactus();//Thay đổi xương rồng
            }
            if (jump == true)//Nếu nhấn space
            {
                Trex.Top -= Force;//Khủng long nhảy lên một khoảng force
                Force -= gravity;// Khủng long rơi xuống sau khi nhảy
            }
            if (Trex.Top + Trex.Height >= LineRun.Top || Trex.Top + Trex.Height < 100)
            {//nếu vị trí của khủng long nhảy cao so với qui định hoặc chệch ra khỏi đường chạy
                jump = false;
                Trex.Top = LineRun.Top - Trex.Height + 10;//Đặt vị trí khủng long trên đường chạy
                //jump = false;
            }
            else
                Trex.Top += gravity;

            //if (godown == true)
            //{
            //    Trex.Image = Properties.Resources.duck;
            //    //Trex.Height = 52;
            //    //Trex.Width = 101;
            //    Trex.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
            if (LineRun.Left < -66)   //Nếu picturebox_linerun chạy ra khỏi màn hình
                makeLineRun();       //tạo một linerun đằng sau nó
            if (LineRun.Left < -886)//Nếu picturebox_linerun mất khỏi màn hình
                LineRun.Left = 886;//thì đặt nó sau màn hình

            if (
               Trex.Bounds.IntersectsWith(Cactus.Bounds)//Nếu Khủng Long va chạm xương rồng(GameOver)
               )
            {
                
                dieaudio.Play();//Phát âm thanh kết thúc
                Trex.Image = Properties.Resources.die1;//Thay đổi hình picturebox
                if (score >= highscore)//Nếu điểm hiện tại lớn hơn điểm highscore
                {
                    highscore = score;//Gán highscore bằng điểm hiện tại
                    Label_HighScore.Text = "HI         " + highscore;//Hiển thị điểm đó lên Label_HighScore
                }
                timer1.Stop();//Dừng Timer1(Game Kết Thúc)

                PictureBox Restart = new PictureBox();              //Khởi tạo picturebox Restart
                Restart.Image = Properties.Resources.restart;      //Gán hình restart cho picturebox
                Restart.Location = new Point(370, 240);           //Đặt picturebox ở giữa màn hình
                Restart.SizeMode = PictureBoxSizeMode.AutoSize;  //Căn kích thước picturebox
                Restart.Anchor = AnchorStyles.None;
                Restart.Tag = "restart";                       //Gắn tag
                this.Controls.Add(Restart);                   //Thêm vào control để điều khiển
                timer2.Start();                              //Bắt đầu Timer2 (Khởi động lại game) 
            }
            foreach (Control X in this.Controls)
            {
               
                if (X is PictureBox && X.Tag == "linerun")
                {
                    X.Left -=speed;//Di chuyển linerun sang trái màn hình tạo hiệu ứng chạy cho khủng long
                    if (X.Left < -1772)//Nếu vị trí của linerun mất khỏi màn hình 
                    {
                        this.Controls.Remove(X);//thì xoá picturebox linerun đó
                        X.Dispose();
                    }
                }
                if (X is PictureBox && X.Tag == "restart" && restart==true)//Nếu nhấn enter 
                    this.Controls.Remove(X);                              //xoá picturebox Restart
            }
        }//Bắt đầu Game

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (restart == true)//Nếu nhấn enter
            {

                Cactus.Left = 1000;//đặt lại vị trí của xương rồng
                foreach (Control X in this.Controls)
                    if (X is PictureBox && X.Tag == "restart" && restart == true)//Xoá pictruebox Restart
                        this.Controls.Remove(X);                                //khi bắt đầu lại game
                Trex.Image = Properties.Resources.run;                         //Đặt lại hình cho khủng long
                speed = 9;                                                    //Đặt lại tốc độ
                //Random rand = new Random();       
                playerSpeed = 36;                                           //Đặt lại tốc độ khủng long
                gravity = 3;                                               //Đặt lại trọng lực khủng long
                timer1.Start();                                           //Bắt đầu lại game
                score = 0;                                               //Đặt lại điểm về 0
            }
            restart = false;
                if (exit == true)//Thoát chương trình khi nhấn escape
                this.Close();
        }//Bắt đầu lại game
    }
}
