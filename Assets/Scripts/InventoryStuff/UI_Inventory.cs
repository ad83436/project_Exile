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
        itemSlotContainer = transform.Find("ItemSlotContainer");
        itemSlot = itemSlotContainer.Find("ItemSlot");
    }
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

        foreach(Transform child in itemSlotContainer)
        {
            if(child == itemSlot) { continue; }
            Destroy(child.gameObject);
        }
        int x = 0;
        int y = 0;
        float itemSlotSize = 280.0f;

        foreach (Item item in inventory.GetItemList()) 
        {
            RectTransform itemSlotRectTrans = Instantiate(itemSlot, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTrans.gameObject.SetActive(true);

            itemSlotRectTrans.anchoredPosition = new Vector2(x * itemSlotSize, y * itemSlotSize);

            Image image = itemSlotRectTrans.Find("ItemImage").GetComponent<Image>();
            image.sprite = item.GetSprite();
            TextMeshProUGUI itemCountText = itemSlotRectTrans.Find("text").GetComponent<TextMeshProUGUI>();

            if (item.currentAmount > 1)
            {
                itemCountText.SetText(item.currentAmount.ToString());
            }
            else { itemCountText.SetText(""); }

            x++;

            if(x > 5)
            {
                x = -550;
                y --;
            }

        }
    }

    public Transform GetItemSlotContainer()
    {
        return itemSlotContainer;
    }
}

