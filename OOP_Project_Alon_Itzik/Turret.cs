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
    class Turret : Spaceship
    {
        //public int _lifeSpanTime;
        protected int _ammoAmount;
        public Turret(int ammoFromLevel) : base()
        {
            _picturebox = new PictureBox();
            _ammoAmount = ammoFromLevel*5;
            _isAlive = true;
            _damage = 1;
        }

        public int get_ammoAmount()
        {
            return _ammoAmount;
        }
        public void set_ammoAmount(int a)
        {
            _ammoAmount = a;
        }



        public override void AddPicture(Form form)
        {
            _picturebox.Image = Properties.Resources.Space_Invaders_Turret;
            _picturebox.Left = form.Width-100;
            _picturebox.Top = form.Height-180;
            _picturebox.Size = new System.Drawing.Size(80,80);
            _picturebox.BackColor = System.Drawing.Color.Transparent;
            _picturebox.Name = "turret";
            _picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _picturebox.TabIndex = 0;
            _picturebox.TabStop = false;
            _picturebox.Tag = "Turret";

            form.Controls.Add(_picturebox);
        }

        public override Bullet FireBullet()
        {
            Bullet enemyBullet = new Bullet("turret", _damage, _picturebox.Location, 315);
            _BulletList.Add(enemyBullet);
            _BulletListSize++;
            _ammoAmount--;
            return enemyBullet;
        }

    }


}
