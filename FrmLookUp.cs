using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Project_0._1
{
    public partial class FrmLookUp : Form
    {
           
        public FrmLookUp()
        {
            InitializeComponent();
            {
                string username = textBox1.Text;
                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load($"https://secure.runescape.com/m=hiscore_oldschool/hiscorepersonal?user1={username}");

                {
                    string[] skill = new string[] { "Overall", "Attack", "Defence", "Strength", "Hitpoints", "Ranged", "Prayer", "Magic", "Cooking", "Woodcutting", "Fletching", "Fishing", "Firemaking", "Crafting", "Smothing", "Mining", "Herblore", "Agility", "Thieving", "Slayer", "Farming", "Runecraft", "Hunter", "Construction" };
                    var rank = document.DocumentNode.SelectNodes($"//tr[{i}]/td[3]").First().InnerText;
                    var level = document.DocumentNode.SelectNodes($"//tr[{i}]/td[4]").First().InnerText;
                    var xp = document.DocumentNode.SelectNodes($"//tr[{i}]/td[5]").First().InnerText;
                    //[@id="contentHiscores"]/table/tbody/tr[4]/td[3]
                    //[@id="contentHiscores"]/table/tbody/tr[27]/td[3]
                    Console.WriteLine($"{skill[i - 4]} {i}: {rank}     {level}      {xp}");
                }
            }
        

        }

        private void FrmLookUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Console.ReadKey(); //Her indtaster brugeren, brugerens brugernavn
            Console.WriteLine();


        }    
    }
}
