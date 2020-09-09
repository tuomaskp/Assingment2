using System;
using System.Collections.Generic;
using System.Runtime;

namespace Assingment2
{


    class Program
    {
        public static List<Player> players = new List<Player>();
        public static HashSet<Guid> guids = new HashSet<Guid>();

        
        //1
        /*
        public static void InstanciatePlayers() {
            for(int i=0;i<1000000;i++) {

                Player player = new Player();
                Guid g = Guid.NewGuid();
                if (guids.Contains(g)) {
                    Console.WriteLine("identical guids");
                }
                player.Id = g;
                players.Add(player);
            }
        }

        */

        static void Main(string[] args)
        {

            Player peluri = new Player();
            Item vasara = new Item();
            vasara.Level = 200;
            Item saha = new Item();
            saha.Level = 100;
            Item puukko = new Item();
            puukko.Level = 300;

            
            peluri.Items = new List<Item>();

            peluri.Items.Add(new Item() { Level = 5, Id = Guid.NewGuid() });
            peluri.Items.Add(new Item() { Level = 6, Id = Guid.NewGuid() });
            peluri.Items.Add(new Item() { Level = 7, Id = Guid.NewGuid() });

            Console.WriteLine(peluri.GetHighestLevelItem());


            //InstanciatePlayers();


            Player p1 = new Player();
            p1.Items = new List<Item>();
            
            p1.Items.Add(new Item() { Level = 1, Id = Guid.NewGuid() });
            p1.Items.Add(new Item() { Level = 2, Id = Guid.NewGuid() });
            p1.Items.Add(new Item() { Level = 3, Id = Guid.NewGuid() });

            Console.WriteLine(Player.FirstItem(p1));
            Console.WriteLine(Player.FirstItemWithLinq(p1));

            
            
        } 

    }
}
