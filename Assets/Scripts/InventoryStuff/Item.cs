using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Stick,
    Rock,
    Bear_Meat,
    Deer_Meat,
    Logs
}



[System.Serializable]
public class Item 
{
    public enum ItemUse
    {
        Comsumable,
        Buliding,
        Weapon
    }

    public string itemName = "";
    public int maxAmount;
    public int currentAmount = 0;
    public bool isStackable;
    public bool isCooked; 
    public ItemType type;
    public ItemUse itemUse;
    public Sprite itemSprite;


    //should be called in pickup item to set stats and add Item to inventory 
    public void SetItemInfo(ItemType type_)
    {
        type = type_;
        switch (type)
        {
            case ItemType.Stick:

                itemName = "Stick";
                maxAmount = 2;
                isStackable = true;
                isCooked = true;
                itemUse = ItemUse.Comsumable;
                break;

            case ItemType.Rock:
                itemName = "Rock";
                maxAmount = 5;
                isStackable = true;
                isCooked = true;
                itemUse = ItemUse.Comsumable;
                break;
        }
    }

    public Sprite GetSprite()
    {
        switch (type)
        {
            default:
            case ItemType.Stick: return ItemAssets.Instance.Stick;
            case ItemType.Rock: return ItemAssets.Instance.Rock;
        }
    }
}
 
