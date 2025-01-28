using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//to read files
using OOP_Project_Alon_Itzik;//maybe useless
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace OOP_Project_Alon_Itzik
{
    public partial class Form1 : Form
    {
        // Stuff
        List<Enemy> EnemyList = new List<Enemy>();
        Player player;
        Turret turret = new Turret(1);
        public Random random = new Random();
        Point cursorPos = new Point();

        string scoreboardFile = @"..\..\Documents\scoreboard.txt";
        string tempFile = @"..\..\Documents\tempScoreboard.txt";
        string gameFilePath = @"..\..\Documents\levelData.bin";

        // Player movment
        public bool goLeft, goRight, goUp, goDown, playerFire, fireKeyLimiter = true, enterKey;

        // Form stuff
        bool isGameOver;
        int level = 0;

        //Classes and stuff
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            IntroScreen();
        }

        public void MainTicking(object sender, EventArgs e)
        {
            if (level > 0)
            {
                RealCursorPos();
                TextControl();
                BulletMovmentAndManagment();
                Enemy.EnemiesMovment(EnemyList, this);
                this.player.PlayerMovment(goLeft, goRight, goUp, goDown, this, cursorPos);
            }

        }
        public void BulletMovmentAndManagment()
        {
            int j, i;
            bool flag = false;

            //enemy fire?
            foreach (Enemy enemy in EnemyList)
            {
                if(RandomNum() < 1)
                {
                    enemy.FireBullet().AddPicture(this);
                }
            }
            //turret fire?
            if (RandomNum() < 3 && turret.get_ammoAmount() > 0 && player.get_isAlive() == true)
            {
                turret.FireBullet().AddPicture(this);

            }

            //player fire?
            if (playerFire == true && player.get_isAlive() == true)
            {
                player.FireBullet().AddPicture(this);
                playerFire = false;
            }

            //check for collision loop
            for (i = 0; i < Spaceship._BulletList.Count; i++)
            {
                foreach (Enemy enemy in EnemyList)
                {
                    if (Spaceship._BulletList[i]._bulletPicturebox.Bounds.IntersectsWith(enemy._picturebox.Bounds) && ( Spaceship._BulletList[i].get_bulletName() == "player" || Spaceship._BulletList[i].get_bulletName() == "turret"))
                    {
                        if (enemy.SpaceShipHit(Spaceship._BulletList[i], player, EnemyList))
                            NextLevel();

                        flag = true;
                        i--;

                        break;
                    }
                }
                if (flag == true)
                    break;

                //player is hit by bullet
                if (Spaceship._BulletList[i]._bulletPicturebox.Bounds.IntersectsWith(player._picturebox.Bounds) && (Spaceship._BulletList[i].get_bulletName() == "enemy" || Spaceship._BulletList[i].get_bulletName() == "shieldedEnemy") && player.get_isAlive() == true)
                {
                    player.set_hp(player.get_hp() - Spaceship._BulletList[i].get_bulletDamage());
                    Spaceship._BulletList[i].removeBullet();

                    if (player.get_hp() <= 0)
                        GameIsOver();
                }
            }


            // this is the actual bullet movment... in all of the other places we created a bullet or clideee somehitsm ds
            for ( i = 0; i < Spaceship._BulletList.Count; i++)
            {

                switch (Spaceship._BulletList[i].get_bulletName())
                {
                    case "player":
                        Spaceship._BulletList[i]._bulletPicturebox.Left += (int)(Spaceship._BulletList[i].get_bulletSpeed() * (Math.Sin(Spaceship._BulletList[i].get_bulletAngle() * 2 * (3.1415926535 / 180))));
                        Spaceship._BulletList[i]._bulletPicturebox.Top -= (int)(Spaceship._BulletList[i].get_bulletSpeed() * (Math.Cos(Spaceship._BulletList[i].get_bulletAngle() * 2 * (3.1415926535 / 180))));
                        break;

                    case "enemy":
                        Spaceship._BulletList[i]._bulletPicturebox.Top -= Spaceship._BulletList[i].get_bulletSpeed();
                        break;
                    case "shieldedEnemy":
                        Spaceship._BulletList[i]._bulletPicturebox.Top -= Spaceship._BulletList[i].get_bulletSpeed();
                        break;

                    case "turret":
                        Spaceship._BulletList[i]._bulletPicturebox.Top += Spaceship._BulletList[i].get_bulletSpeed()*2;
                        Spaceship._BulletList[i]._bulletPicturebox.Left += Spaceship._BulletList[i].get_bulletSpeed();
                        break;

                }

                if (Spaceship._BulletList[i]._bulletPicturebox.Top <= 0 || Spaceship._BulletList[i]._bulletPicturebox.Top >= Height)
                {
                    Spaceship._BulletList[i].removeBullet();
                    i--;
                }
            }

        }
        public void TextControl()
        {
            LevelText.Left = 0;
            LevelText.Top = Height - 90;
            ScoreText.Left = Width - (ScoreText.Width + 15);
            ScoreText.Top = Height - 90;
            HPText.Left = Width / 2 - (HPText.Width / 2);
            HPText.Top = Height - 90;
            bottomPictureBox.Top = Height - 90;

            LevelText.Text= "LEVEL: " + level;
            ScoreText.Text = "SCORE:" + player.get_score();
            HPText.Text = "HP:" + player.get_hp();
        }
        public int RandomNum()
        {
            int num = random.Next(0,200);
            return num;
        }


        // Game and Level managment
        public void StartGame(int inLevel)
        {
            this.KeyPreview = true;
            if (inLevel < 1)
                this.level = 1;
            else
                this.level = inLevel;

            this.player = new Player();
            player.set_isAlive(true);
            player.AddPicture(this);
            turret.AddPicture(this);
            turret._picturebox.Visible = true;
            turret.set_ammoAmount(1);
            StartLevel(this.level);
        }
        public void NextLevel()
        {
            if (level>=5)
            {
                GameIsOver();
                return;
            }
            level++;
            turret.set_ammoAmount(level);

/*            string[] levelLine = {level.ToString()};
            File.WriteAllLines(savedGameFile, levelLine);
*/
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(gameFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, level);
            }

            StartLevel(level);
        }
        public void StartLevel(int level)
        {
            CleanUpAllTexts();
            LevelText.Visible = true;
            HPText.Visible = true;
            ScoreText.Visible = true;
            
            Enemy.set_spacingPosX(0);
            Enemy.set_spacingPosY(0);
            EnemyList.Clear();
            Enemy.CreateEnemyList(level + 3, EnemyList,this);
        }
        public void LoadLastGame()
        {
            try
            {
                Stream stream = File.Open(gameFilePath, FileMode.Open);
                var binaryFormatter = new BinaryFormatter();
                level = (int)binaryFormatter.Deserialize(stream);
                stream.Close();
                Console.WriteLine("THIS IS THE LEVEL : " + level);
                StartGame(level);
            }
            catch (Exception)
            {
                StartGame(level);
            }
        }
        public void GameIsOver()
        {
            player.PlayerIsDead();
            isGameOver = true;
            turret._picturebox.Visible = false;
            Lable_gameover.Visible = true;
            Lable_gameover_addscore.Visible = true;
            level = 1;
            string[] levelLine = { level.ToString() };
            File.WriteAllLines(gameFilePath, levelLine);

            AddToScoreboard();

        }
        public void RestartGame()
        {
            foreach (Enemy enemy in EnemyList)
            {
                enemy._picturebox.Dispose();
            }
            foreach (Bullet bullet in Spaceship._BulletList)
            {
                bullet._bulletPicturebox.Dispose();
            }
            this.player._picturebox.Dispose();
            EnemyList.Clear();
            Spaceship._BulletList.Clear();
            
            isGameOver = false;
            level = 0;
            IntroScreen();
        }
        public void IntroScreen()
        {
            CleanUpAllTexts();
            Lable_new_game.Left = Width / 2 - Lable_new_game.Width / 2;
            Lable_continue.Left = Width / 2 - Lable_continue.Width / 2;
            Lable_scoreboard.Left = Width / 2 - Lable_scoreboard.Width / 2;


            Lable_new_game.Visible = true;
            Lable_continue.Visible = true;
            Lable_scoreboard.Visible = true;
            Label_credits.Visible = true;
        }


        //These are all the Keyboard and Mouse clicks & controls
        public void RealCursorPos()
        {
            cursorPos.X = Cursor.Position.X - this.Left - 12;
            cursorPos.Y = Cursor.Position.Y - this.Top - 35;

        }
        public void AddToScoreboard()
        {
            Textbox_entername.Text = "";
            Textbox_entername.Visible = true;
        }
        public void Scoreboard_Click(object sender, EventArgs e)
        {
            CleanUpAllTexts();
            Lable_score1.Visible = true;
            Lable_score2.Visible = true;
            Lable_score3.Visible = true;
            Lable_score4.Visible = true;
            Label_scoreboard2.Visible = true;
            Lable_ReturnToMenu.Visible = true;

            if (File.Exists(scoreboardFile))
            {
                using (StreamReader lineHolder = new StreamReader(scoreboardFile))
                foreach (Control textLable in this.Controls)
                {
                    if ((string)textLable.Tag == "Lable_score")
                    {
                       textLable.Text = lineHolder.ReadLine();
                    }
                }
            }
            Lable_score1.Left = Width / 2 - Lable_score1.Width / 2;
            Lable_score2.Left = Width / 2 - Lable_score2.Width / 2;
            Lable_score3.Left = Width / 2 - Lable_score3.Width / 2;
            Lable_score4.Left = Width / 2 - Lable_score4.Width / 2;
            Label_scoreboard2.Left = Width / 2 - Label_scoreboard2.Width / 2;

        }
        public void ReturnToMain_Click(object sender, EventArgs e)
        {
            IntroScreen();
        }
        public void Label_credits_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://i.imgur.com/BK8Efco.jpeg"); 
            }
            catch (Exception)
            {

            }
        }
        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && fireKeyLimiter == true /*&& player != null*/)
            {
                playerFire = true;
                fireKeyLimiter = false;
            }
            Console.WriteLine("fireKeyLimiter: " + fireKeyLimiter);
            Console.WriteLine("playerFire: " + playerFire);
        }
        private void Lable_gameover_addscore_Click(object sender, EventArgs e)
        {

            string nameAndScore = "PLAYER " + Textbox_entername.Text + " - " + "SCORE "+ player.get_score().ToString() + "\n" ;
            try
            {

                File.WriteAllText(tempFile, nameAndScore);
                

                File.AppendAllText(tempFile, File.ReadAllText(scoreboardFile));

                File.WriteAllText(scoreboardFile, File.ReadAllText(tempFile));

                File.Delete(tempFile);

                Console.WriteLine("Text added to the first line successfully.");
            }
            catch (IOException f)
            {
                Console.WriteLine("An error occurred while adding text: " + f.Message);
            }

            RestartGame();
        }

        public void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                playerFire = false;
                fireKeyLimiter = true;
            }
        }
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Space && fireKeyLimiter == true /*&& player != null*/)
            {
                playerFire = true;
                fireKeyLimiter = false;
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                enterKey = true;
            }


/*            Console.WriteLine("Key pressed: " + e.KeyCode);
            Console.WriteLine("goLeft: " + goLeft);
            Console.WriteLine("goRight: " + goRight);
            Console.WriteLine("goUp: " + goUp);
            Console.WriteLine("goDown: " + goDown);
            Console.WriteLine("fireKeyLimiter: " + fireKeyLimiter);
            Console.WriteLine("playerFire: " + playerFire);
            Console.WriteLine("isGameOver: " + isGameOver);*/


        }
        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                playerFire = false;
                fireKeyLimiter = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                enterKey = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
            }

        }
        public void IntroLable1_Click(object sender, EventArgs e)
        {
            LoadLastGame();
        }
        public void NewGameLable_Click(object sender, EventArgs e)
        {
            StartGame(level);
        }
        public void CleanUpAllTexts()
        {
            Lable_continue.Visible = false;
            Lable_new_game.Visible = false;
            Lable_scoreboard.Visible = false;
            Lable_gameover.Visible = false;
            Lable_gameover_addscore.Visible = false;
            LevelText.Visible = false;
            HPText.Visible = false;
            ScoreText.Visible = false;
            Lable_score1.Visible = false;
            Lable_score2.Visible = false;
            Lable_score3.Visible = false;
            Lable_score4.Visible = false;
            Lable_ReturnToMenu.Visible = false;
            Label_credits.Visible = false;
            Label_scoreboard2.Visible = false;
            Textbox_entername.Visible = false;
            //Textbox_entername.Enabled = false;
            //Textbox_entername.ReadOnly = true;
        }
    }
}