using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ThirdPersonCamera : MonoBehaviour
{
    public Transform followPoint;
    public PlayerController player;
    public GameObject mainCam;
    public GameObject aimCam;
    [Range (0.0f,4.0f)]
    public float rotSpeed;
    Transform orgTrans;

    private void Start()
    {

    }

   private void Update()
    {
        var camLookY = player.aimInput.y;
        var camLookX = player.aimInput.x;

        followPoint.rotation *= Quaternion.AngleAxis(camLookX * rotSpeed, Vector3.up);
        followPoint.rotation *= Quaternion.AngleAxis(camLookY * rotSpeed, Vector3.left);

        var angles = followPoint.localEulerAngles;
        angles.z = 0.0f;
        var angleX = followPoint.localEulerAngles.x;
        var angleY = followPoint.localEulerAngles.y;

        if (!player.isAiming)
        {
            aimCam.SetActive(false);
            mainCam.SetActive(true);

            player.transform.Rotate(Vector3.up, player.currentMovement.x * player.rotSpeed * Time.deltaTime);
           
            //clamp up and down camera rot 
            if (angleX > 180 && angleX < 340)
            {
                angles.x = 340;
            }
            else if (angleX < 180 && angleX > 40)
            {
                angles.x = 40;
            }

            /* if (player.isGamepad)
             {
                 if (player.isMoving && player.currentMovement.x == 0)
                 {
                     // Rotate the player when the camera is at the shoulder when the player is moving  
                     if (angleY > 180 && angleY < 300f)
                     {
                         angles.y = 300f;
                         player.transform.Rotate(Vector3.down, angles.normalized.y * player.rotSpeed * Time.deltaTime);
                     }
                     else if (angleY < 180f && angleY > 70f)
                     {
                         angles.y = 70f;
                         player.transform.Rotate(Vector3.up, angles.normalized.y * player.rotSpeed * Time.deltaTime);
                     }

                 }
             }*/

            followPoint.localEulerAngles = angles;
        }
        else
        {
            aimCam.SetActive(true);
            mainCam.SetActive(false);
            
            //clamp up and down camera rot 
            if (angleX > 180 && angleX < 340)
            {
                angles.x = 340;
            }
            else if (angleX < 180 && angleX > 20)
            {
                angles.x = 20;
            }

            player.transform.rotation = Quaternion.Euler(0, followPoint.transform.rotation.eulerAngles.y, 0);

            followPoint.transform.localEulerAngles = new Vector3(angles.x, 0, 0);
        }
    }
}

