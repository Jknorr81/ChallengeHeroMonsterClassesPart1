using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Batman";
            hero.Health = 100;
            hero.DamageMaximum = 75;
            hero.AttackBonus = false;


            Character monster = new Character();
            monster.Name = "Joker";
            monster.Health = 100;
            monster.DamageMaximum = 25;
            monster.AttackBonus = false;


            int damage = hero.Attack();
            monster.Defend(damage);

            damage = monster.Attack();
            hero.Defend(damage);

           /* monster.Health -= hero.Attack();
            hero.Health -= monster.Defend(5);

            hero.Health -= monster.Attack();
            monster.Health -= hero.Defend(10);
            */


            displayStats(hero);
            resultLabel.Text += "<br />";
            displayStats(monster);
        }

        private void displayStats(Character character)
        {
            resultLabel.Text += string.Format("Name: {0} - Health: {1} - DamageMax: {2} - AttackBonus: {3} <br />", 
                character.Name,
                character.Health,
                character.DamageMaximum,
                character.AttackBonus);
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }


        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(this.DamageMaximum);
            return damage;
        }

        public int Defend(int damage)
        {
            this.Health -= damage;
            return this.Health;
        }
    }



}