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
    public class Spaceship
    {
        protected bool _isAlive;
        protected int _damage;
        public PictureBox _picturebox;
        public static List<Bullet> _BulletList = new List<Bullet>();
        public static int _BulletListSize;

        public Spaceship() { }//constructor

        public bool get_isAlive()
        {
            return _isAlive;
        }
        public void set_isAlive(bool a)
        {
            _isAlive = a;
        }

        public int get_damage()
        {
            return  _damage;
        }
        public void set_damage(int a)
        {
              _damage = a;
        }


        public virtual void AddPicture(Form form)
        {
            form.Controls.Add(_picturebox);
        }
        public virtual Bullet FireBullet() 
        {
            return null;
        }
        
    }


}
