using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Inventory 
{
    public event EventHandler onItemListChanged;
    List<Item> itemList;
    int maxSlots = 20;// number of items you can carry in the inventory
    public Inventory()
    {
        itemList = new List<Item>();
    }


    public void AddItem(Item item_)
    {
        //bool invFull = false;
        // quick full inventory check
        //if(itemList.Count == maxSlots) { invFull = true; }

        //nothing is currently in the inventory so add a item to the first slot
        if (itemList.Count == 0)
        {
            Debug.Log("Added " + item_.itemName);
            itemList.Add(item_);
            itemList[0].currentAmount += 1; // increase the amount of that item in the slot
            onItemListChanged?.Invoke(this, EventArgs.Empty);

        }

        // if there is an item already inside the inventory 
        else if (itemList.Count > 0 && itemList.Count < maxSlots)
        {
            //loop through the inventory
            for (int i = 0; i < itemList.Count; ++i)
            {
                //check if the item already exist in the inventory 
                if (item_.type == itemList[i].type)
                {
                    //check if the item is even stackable
                    if (itemList[i].isStackable)
                    {
                        //check if the item still has room to fit more into that slot
                        if (itemList[i].currentAmount < itemList[i].maxAmount)
                        {
                            itemList[i].currentAmount += 1;
                            onItemListChanged?.Invoke(this, EventArgs.Empty);
                            return;
                        }

                        // if that item is at max amount continue through the loop to check if there is another obj of the same type
                        else if(itemList[i].currentAmount >= itemList[i].maxAmount)
                        {
                            continue;
                        }
                    }

                    else
                    {
                        //instantiate the pick up item
                    }
                }
            }
            
            //Inventory was not full and item either full or not in the inventory
            Debug.Log("Added " + item_.itemName);
            itemList.Add(item_);
            itemList[itemList.Count - 1].currentAmount += 1;
            onItemListChanged?.Invoke(this, EventArgs.Empty);
        }

        else if(itemList.Count == maxSlots)
        {
            foreach(var item in itemList)
            {
                //check if all the items are full up
                if(item.currentAmount == item.maxAmount)
                {

                }
            }
        }

    }


    public List<Item> GetItemList()
    {
        return itemList;
    }

}


