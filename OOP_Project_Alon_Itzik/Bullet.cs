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
    public class Bullet
    {
        public PictureBox _bulletPicturebox;
        protected static int NamePostfix;//maybe useless
        protected int _bulletDamage;
        protected int _bulletSpeed;
        protected double _bulletAngle;
        protected Point _bulletLocate;
        protected string _bulletName;
        //Class Constructor
        public Bullet(string bulletSource, int sourceDamage, Point originalLocation, double fireAngle)
        {

            _bulletPicturebox = new PictureBox();

            switch (bulletSource)
            {
                case "enemy":
                    _bulletPicturebox.Image = Resources.Green_Bullet;
                    _bulletSpeed = -10;
                    _bulletLocate.X +=20;

                    break;
                case "shieldedEnemy":
                    _bulletPicturebox.Image = Resources.Blue_Bullet;
                    _bulletSpeed = -10;
                    _bulletLocate.X +=25;
                    break;

                case "player":
                    _bulletPicturebox.Image = Image.FromFile("..\\..\\Pictures\\Space-Invaders-Bullet-rotation\\Space-Invaders-Bullet_" + ((int)(fireAngle)).ToString() + ".png");
                    _bulletSpeed = 10;

                    break;

                case "turret":
                    _bulletPicturebox.Image = Resources.Yellow_Bullet;
                    _bulletSpeed = -10;

                    break;
            }

            _bulletDamage = sourceDamage;
            _bulletLocate = originalLocation;
            _bulletAngle = fireAngle;
            _bulletName = bulletSource;
        }



        public int get_bulletDamage()
        {
            return _bulletDamage;
        }
        public void set_bulletDamage(int a)
        {
            _bulletDamage = a;
        }

        public int get_bulletSpeed()
        {
            return _bulletSpeed;
        }
        public void set_bulletSpeed(int a)
        {
            _bulletSpeed = a;
        }

        public double get_bulletAngle()
        {
            return _bulletAngle;
        }
        public void set_bulletAngle(double a)
        {
            _bulletAngle = a;
        }

        public Point get_bulletLocate()
        {
            return _bulletLocate;
        }
        public void set_bulletLocate(Point a)
        {
            _bulletLocate = a;
        }

        public string get_bulletName()
        {
            return _bulletName;
        }
        public void set_bulletName(string a)
        {
            _bulletName = a;
        }


        public void AddPicture(Form form)
        {
            _bulletLocate.X -= 17;
            _bulletLocate.Y -= 17;
            _bulletPicturebox.Location = _bulletLocate;
            _bulletPicturebox.Size = new System.Drawing.Size(35, 35);
            _bulletPicturebox.BackColor = System.Drawing.Color.Transparent;
            _bulletPicturebox.Name = _bulletName;
            _bulletPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _bulletPicturebox.TabIndex = 0;
            _bulletPicturebox.TabStop = false;
            _bulletPicturebox.Tag = _bulletName + "bullet";

            form.Controls.Add(_bulletPicturebox);
        }
        public void removeBullet()
        {
            _bulletPicturebox.Dispose();


            if (Spaceship._BulletList.Remove(this))
                Spaceship._BulletListSize--;
        }

    }
}
