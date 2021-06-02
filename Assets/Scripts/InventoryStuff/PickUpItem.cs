using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] SphereCollider pItemRadius;
    [SerializeField] float pickUpTimer = 0.0f;
    //public Item item;
    [SerializeField]ItemType type;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
      if(pItemRadius == null) { pItemRadius = GetComponent<SphereCollider>(); }
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>(); 

    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            PlayerController plyCon = other.GetComponent<PlayerController>();

            if (plyCon.isInteracting) // check if the player is interacting with it 
                 
            {
                pickUpTimer += Time.deltaTime;

               
                if(pickUpTimer >= 1.0f)
                {
                    //Add to inventory
                    Item pickedUpItem = new Item();// create a new pickup item 
                    pickedUpItem.SetItemInfo(type); // Set item info based off its type
                    player.GetInv().AddItem(pickedUpItem); // add the item to the players inventory 
                    pickUpTimer = 0.0f;
                    Destroy(this.gameObject);// Destroy the pickup Object
                }
            }
            else
            {
                if(pickUpTimer > 0.0f)
                {
                    pickUpTimer = 0.0f;
                    return;
                }
            }
        }
        else
        {
            return;
        }
    }
}
 
