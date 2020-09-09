using System;
using System.Collections.Generic;
using System.Linq;
public class Player : IPlayer
{

    public Guid Id { get; set; }
    public int Score { get; set; }
    
    public List<Item> Items { get; set; }
 

    //2
    public Guid GetHighestLevelItem() {
        Item Highest = Items[0];
        for(int i=0;i<Items.Count;i++) {
            if (Items[i].Level > Highest.Level) {
                Highest = Items[i];
            }
            
        }
        return Highest.Id;
    }

    //3 
    public Item[] GetItems(Player player) {
        Item[] items = {};
        for (int i=0;i<player.Items.Count;i++) {
            items[i] = player.Items[i];
        }

        return items;
    }

    public Item[] GetLinqItems(Player player) {
        return player.Items.ToArray();

    }
    //4
    public static Item FirstItem(Player player) {
         if (player.Items.Count != 0) {
             return player.Items[0];
         } else{
             return null;
         }
    }

     public static Item FirstItemWithLinq(Player player) {
          return player.Items.FirstOrDefault();
     }

}