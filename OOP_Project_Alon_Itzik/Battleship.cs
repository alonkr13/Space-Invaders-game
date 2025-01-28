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
    public class Battleship : Spaceship
    {
        public Battleship() : base() { }
        protected int _hp;


        public int get_hp()
        {
            return _hp;
        }
        public void set_hp(int a)
        {
            _hp = a;
        }

    }

}
