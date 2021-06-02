using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Souls
{
    public override AnimalType animalType() => AnimalType.Bear;
    Inventory plyInv;
    [SerializeField] UI_Inventory uiInventory;

    private void Awake()
    {
        plyInv = new Inventory();
        uiInventory.SetInventory(plyInv);
    }
    // Start is called before the first frame update
    void Start()
    {
        curntHealth_ = maxHealth_ = 100.0f;
        damage_ = 10.0f;
        StartUp();
        
        
    }
    // Update is called once per frame
    void Update()
    {

    }

    public Inventory GetInv()
    {
        return plyInv;
    }

    public UI_Inventory GetInvetoryUI()
    {
        return uiInventory;
    }
}

