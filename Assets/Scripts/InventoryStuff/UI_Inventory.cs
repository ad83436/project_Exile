using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UI_Inventory : MonoBehaviour
{
    Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlot;
    public GameObject invBackground;

    private void Awake()
    {
        //find item slot container  and item slot in hierarchy 
        itemSlotContainer = transform.Find("ItemSlotContainer");
        itemSlot = itemSlotContainer.Find("ItemSlot");
    }

    // sets the inventory then refreshes it
    public void SetInventory(Inventory inventory_)
    {
        inventory = inventory_;
        inventory.onItemListChanged += Inventory_OnItemListChanged;
        RefreshInventoryItems();

    }

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e)
    {
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        //loop through item slot container to get each item slot  
        foreach (Transform child in itemSlotContainer)
        {
            if (child == itemSlot) { continue; }
            Destroy(child.gameObject);
        }

        // item slot image starting x and y position
        int x = 0;
        int y = 0;

        //space between each item slots 
        float itemSlotSize = 280.0f;

        //looping through each item in the inventory
        foreach (Item item in inventory.GetItemList())
        {
            //create new item slot container 
            RectTransform itemSlotRectTrans = Instantiate(itemSlot, itemSlotContainer).GetComponent<RectTransform>();

            //Activate item so it shows up 
            itemSlotRectTrans.gameObject.SetActive(true);

            //place the item slot at the right position 
            itemSlotRectTrans.anchoredPosition = new Vector2(x * itemSlotSize, y * itemSlotSize);

            //get the item image
            Image image = itemSlotRectTrans.Find("ItemImage").GetComponent<Image>();
            //set image to the sprite that is the right item that was picked up 
            image.sprite = item.GetSprite();
            //set the amount of items in slot 
            TextMeshProUGUI itemCountText = itemSlotRectTrans.Find("text").GetComponent<TextMeshProUGUI>();

            // item amout is greater than one in the slot provide how much is in that slot if there is only one display nothing
            if (item.currentAmount > 1)
            {
                itemCountText.SetText(item.currentAmount.ToString());
            }
            else { itemCountText.SetText(""); }

            //add one to the x so the next slot is placed beside the slot before
            x++;

            //if slots row has reached max amount reset the x pos and move the y pos down one to start a new row 
            if (x > 5)
            {
                x = 0;
                y--;
            }

        }
    }

    public GameObject GetItemSlotContainer()
    {
        return itemSlotContainer.gameObject;
    }
}

  

