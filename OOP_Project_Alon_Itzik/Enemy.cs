using OOP_Project_Alon_Itzik.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP_Project_Alon_Itzik
{
    public class Enemy : Battleship
    {
        //Class Constructor
        protected static int _SpacingPosX;
        protected static int _SpacingPosY;
        protected static int _EnemySpeed = 1;
        protected static int _EnemyAmount;
        public Enemy() : base()
        {
            _isAlive = true;
            _damage = 1;
            _hp = 1;
            _picturebox = new PictureBox();

            if (_SpacingPosX >= 500)
            {
                _SpacingPosX = -100;
                _SpacingPosY = 100;
            }
            _SpacingPosX += 100;
        }

        public static int get_spacingPosX()
        {
            return _SpacingPosX;
        }
        public static void set_spacingPosX(int a)
        {
            _SpacingPosX = a;
        }

        public static int get_spacingPosY()
        {
            return _SpacingPosY;
        }
        public static void set_spacingPosY(int a)
        {
            _SpacingPosY = a;
        }
        public static int get_enemySpeed()
        {
            return _EnemySpeed;
        }
        public static void set_enemySpeed(int a)
        {
            _EnemySpeed = a;
        }

        public static int get_enemyAmount()
        {
            return _EnemyAmount;
        }
        public static void set_enemyAmount(int a)
        {
            _EnemyAmount = a;
        }


        public override void AddPicture(Form form)
        {
            _picturebox.Image = Properties.Resources.Space_Invaders_Enemy_resized2;
            _picturebox.Size = new System.Drawing.Size(70, 70);
            _picturebox.Left =50 + _SpacingPosX;
            _picturebox.Top = 50 + _SpacingPosY;

            _picturebox.BackColor = System.Drawing.Color.Transparent;
            _picturebox.Name = "enemySpaceship_" + _EnemyAmount.ToString();
            _picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _picturebox.TabIndex = 0;
            _picturebox.TabStop = false;
            _picturebox.Tag = "enemyTag";

            form.Controls.Add(_picturebox);
        }
        public override Bullet FireBullet()
        {
            Point newPoint = new Point();
            newPoint.X = _picturebox.Location.X + _picturebox.Size.Width / 2;
            newPoint.Y = _picturebox.Location.Y + _picturebox.Size.Height / 2;
            Bullet enemyBullet = new Bullet("enemy", _damage, newPoint, 180);
            _BulletList.Add(enemyBullet);
            _BulletListSize++;
            return enemyBullet;
        }
        public static void CreateEnemyList(int enemyWaveSize, List<Enemy> EnemyList, Form form)
        {
            //Enemy._enemyAmount = enemyWaveSize;
            Enemy._EnemyAmount = enemyWaveSize;
            for (int i = 0; i < Enemy._EnemyAmount; i++)
            {
                if (i%3==0)
                {
                    Enemy newTempEnemy = new Enemy();
                    newTempEnemy.AddPicture(form);
                    EnemyList.Add(newTempEnemy);
                }
                else
                {
                    ShieldedEnemy newTempShieldedEnemy = new ShieldedEnemy();
                    newTempShieldedEnemy.AddPicture(form);
                    EnemyList.Add(newTempShieldedEnemy);
                }
            }
        }
        public virtual bool SpaceShipHit(Bullet bulletObj, Player player, List<Enemy> EnemyList)
        {
            _hp -= bulletObj.get_bulletDamage();
            player.set_score(player.get_score() + bulletObj.get_bulletDamage());


            bulletObj.removeBullet();

            if (_hp <= 0)
                if (Enemy.enemyDied(this, EnemyList))
                {
                    return true;
                }
            return false;
        }
        public static void EnemiesMovment(List<Enemy> EnemyList, Form form)
        {
            int i;
            //check if they hit a wall and reverse speed:
            foreach (Enemy enemy in EnemyList)
            {
                if (enemy._picturebox.Left <= 0 || enemy._picturebox.Left + enemy._picturebox.Width + 10>= form.Width )
                {
                    Enemy._EnemySpeed *= -1;
                }
            }

            foreach (Enemy enemy in EnemyList)
            {
                //move:
                enemy._picturebox.Left -= Enemy._EnemySpeed;

            }

        }
        public static bool enemyDied(Enemy enemyShip,List<Enemy> EnemyList)
        {
            enemyShip._isAlive = false;
            enemyShip._picturebox.Dispose();

            if (EnemyList.Remove(enemyShip))
                Enemy._EnemyAmount--;

            if (Enemy._EnemyAmount == 0)
                return true;
            return false;
        }
    }
}