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
    class ShieldedEnemy : Enemy// should this be virtual contructor? is that even a thing?
    {
        protected int _shield;
        public ShieldedEnemy() : base()
        {
            _isAlive = true;
            _hp = 1;
            _shield = 1;
            _damage = 1;
            _picturebox = new PictureBox();

            if (_SpacingPosX >= 500)
            {
                _SpacingPosX = -100;
                _SpacingPosY = 100;
            }
            _SpacingPosX += 100;// change the spacing so it will be according to the form width? naaa
        }


        public int get_shield()
        {
            return _shield;
        }
        public void set_shield(int a)
        {
            _shield = a;
        }

        public override void AddPicture(Form form)
        {
            _picturebox.Image = Properties.Resources.Space_Invaders_ShieldedEnemy;
            _picturebox.Size = new System.Drawing.Size(108, 108);
            _picturebox.Left = _SpacingPosX-68;
            _picturebox.Top = 31 + _SpacingPosY;

            _picturebox.BackColor = System.Drawing.Color.Transparent;
            _picturebox.Name = "enemySpaceship_" + _EnemyAmount.ToString();
            _picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _picturebox.TabIndex = 0;
            _picturebox.TabStop = false;
            _picturebox.Tag = "enemyTag";

            form.Controls.Add(_picturebox);
        }
        public override bool SpaceShipHit(Bullet bulletObj, Player player, List<Enemy> EnemyList)
        {
            if (_shield > 0)
            {
                _shield -= bulletObj.get_bulletDamage();
            }
            else
            { 
                _hp -= bulletObj.get_bulletDamage();
                player.set_score(player.get_score() + bulletObj.get_bulletDamage());
            }

            bulletObj.removeBullet();

            if (_hp <= 0)
                if (Enemy.enemyDied(this, EnemyList))
                {
                    return true;
                }
            return false;
        }
        public override Bullet FireBullet()
        {
            Point newPoint = new Point();
            newPoint.X = _picturebox.Location.X + _picturebox.Size.Width / 2;
            newPoint.Y = _picturebox.Location.Y + _picturebox.Size.Height / 2;
            Bullet enemyBullet = new Bullet("shieldedEnemy", _damage, newPoint, 180);
            _BulletList.Add(enemyBullet);
            _BulletListSize++;
            return enemyBullet;
        }
    }
}
