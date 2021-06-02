using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

struct InputFunctions
{
    PlayerController playerCon;

    public InputFunctions(PlayerController playerCon_)
    {
        playerCon = playerCon_;
    }

    public bool FireContext(InputAction.CallbackContext ctx)
    {
        if(playerCon.plyGun.nextFire <= 0.0 && !playerCon.isFiring)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
