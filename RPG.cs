using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
namespace RPG_game
{
    public partial class RPG : Form
    {
        private Player _player;
        public RPG()
        {
            InitializeComponent();
            _player = new Player(10,10,20,0,1);
         

            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            IbHitPoints.Text = _player.CurrentHitPoints.ToString();
            IblGold.Text = _player.Gold.ToString();
            IblExperience.Text = _player.ExperiencePoints.ToString();
            IblLevel.Text = _player.Level.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
