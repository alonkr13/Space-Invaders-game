using OOP_Project_Alon_Itzik.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Alon_Itzik
{
    public class Player : Battleship
    {
        protected int _score;
        protected double _roatation;

        //Class Constructor
        public Player() : base()
        {
            _isAlive = false;
            _hp = 3;
            _damage = 4;
            _score = 0;
            _picturebox = new PictureBox();

        }

        public int get_score()
        {
            return _score;
        }
        public void set_score(int a)
        {
            _score = a;
        }
        
        public double get_roatation()
        {
            return _roatation;
        }
        public void set_roatation(double a)
        {
            _roatation = a;
        }


        public override void AddPicture(Form form)
        {
            _picturebox.Image = Properties.Resources.Space_Invaders_Player_0;
            _picturebox.Left = 100;
            _picturebox.Top = 500;

            _picturebox.BackColor = System.Drawing.Color.Transparent;
            _picturebox.Name = "PlayerSpaceship";
            _picturebox.Size = new System.Drawing.Size(100, 100);
            _picturebox.Location = new System.Drawing.Point(277, 591);
            _picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _picturebox.TabIndex = 0;
            _picturebox.TabStop = false;
            form.Controls.Add(_picturebox);
        }
        public override Bullet FireBullet()
        {
            SoundPlayer fireSound = new SoundPlayer(Resources.Laser);
            fireSound.Play();
            Point newPoint = new Point();
            newPoint.X = _picturebox.Location.X + _picturebox.Size.Width / 2;
            newPoint.Y = _picturebox.Location.Y + _picturebox.Size.Height / 2;
            Bullet playerBullet = new Bullet("player", _damage, newPoint, _roatation);
            _BulletList.Add(playerBullet);
            _BulletListSize++;
            return playerBullet;
        }
        public void PlayerMovment(bool goLeft,bool goRight, bool goUp, bool goDown, Form form, Point cursorPos)
        {

            //Arrow Controls
            if (goLeft == true)
            {
                if (_picturebox.Left + _picturebox.Width / 2 <= 0)
                {
                    _picturebox.Left = form.Width - _picturebox.Width / 2;
                }

                _picturebox.Left -= 10;
            }
            if (goRight == true)
            {
                if (_picturebox.Left + _picturebox.Width / 2 > form.Width)
                {
                    _picturebox.Left = 0 - _picturebox.Width / 2;
                }

                _picturebox.Left += 10;
            }
            if (goUp == true && _picturebox.Top >= 0)
            {
                _picturebox.Top -= 10;
            }

            if (goDown == true && _picturebox.Top <= form.Height- _picturebox.Height - 90)
            {
                _picturebox.Top += 10;
            }

            _roatation = Math.Atan(((_picturebox.Left + _picturebox.Width / 2) - cursorPos.X) / (((_picturebox.Top + _picturebox.Height / 2) - cursorPos.Y == 0) ? 0.001 : ((_picturebox.Top + _picturebox.Height / 2) - cursorPos.Y)));
            _roatation *= 57.2957795;
            if (cursorPos.Y < (_picturebox.Top + _picturebox.Height / 2))
            {
                _roatation = ((int)(-_roatation + 360) % 360) / 2;
            }
            else
            {
                _roatation = ((int)(-_roatation + 180) % 360) / 2;
            }
            _picturebox.Image = Image.FromFile("..\\..\\Pictures\\Space-Invaders-Player-rotation\\Space-Invaders-Player_" + ((int)(_roatation)).ToString() + ".png");
        }
        public void PlayerIsDead()
        {

            _isAlive = false;
            _picturebox.Visible = false;
        }
    }
}