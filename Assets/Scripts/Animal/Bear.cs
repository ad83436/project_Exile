using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Souls
{
    public override AnimalType animalType() => AnimalType.Bear;

    // Start is called before the first frame update
    void Start()
    {
        StartUp();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

