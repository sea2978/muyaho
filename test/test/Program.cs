using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character();
            player.maxhp = 100;
            player.hp = player.maxhp;
            player.power = 5;
            player.name = "a";

            Character enemy = new Character();
            enemy.maxhp = 100;
            enemy.hp = enemy.maxhp;
            enemy.power = 2;
            enemy.name = "b";

            for ( ;enemy.hp > 0 && player.hp > 0; enemy.Attack( player) ) 
            {
                player.Attack( enemy);

            }
            if(player.hp <= 0)
            {
                Console.WriteLine($"{enemy.name}승");
            }
            else if (enemy.hp <= 0)
            {
                Console.WriteLine($"{player.name}승");
            }
        }
    }

    class Character
    {

        public float maxhp;
        public float hp;
        public int power;
        public string name;
        public float damage;

        public void Attack(Character target)
        {
            Random ran = new Random();
            damage = ran.Next(0, this.power + 1);

            Console.WriteLine($"{this.name}가 {target.name}를 {this.damage}의 데미지로 공격");

            target.hp -= this.damage;
            Hit(this, target);
        }
        public void Hit(Character hitter,Character target)
        {
            if(hitter.damage == 0)
            {
                Console.WriteLine($"{target.name}가 {hitter.name}의 공격을 피함 " +
                    $"{target.name}의 남은 hp : {target.hp}");
            }
            if (hitter.damage == hitter.power)
            {
                Console.WriteLine($"{hitter.name}가 {target.name}의 급소를 공격함 " +
                    $"{target.name}의 남은 hp : {target.hp}");
            }
            else
            {
                Console.WriteLine($"{target.name}가 {hitter.name}로부터 {hitter.damage}의 데미지를 입음 " +
                    $"{target.name}의 남은 hp : {target.hp}");
            }
        }
    }

}
