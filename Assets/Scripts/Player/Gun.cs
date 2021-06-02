using UnityEngine;


public enum GunType
{
    Pistol,
    Machine
}

public class Gun : MonoBehaviour
{
    public GunType gunType;
    public Transform muzzlePos;

    public Transform followPoint;
    float fireRate;
    public float nextFire { get; private set; }
    bool canShoot;
    float bulRange = 100.0f;
    public PlayerController plyer;
    public float damage { get; private set; }
    public bool canReload { get; private set; }

    int maxClipSize;
    int curntBulInClip; 
    public int maxClips;
    int clips;
 

    // Start is called before the first frame update
    void Start()
    {
        DeterminClipSize(gunType);
        canShoot = true;
        clips = maxClips = 8;
        plyer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        nextFire = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (plyer.isAiming)
        {
            FireType(gunType);
        }

        if(curntBulInClip < maxClipSize) { canReload = true; }
        else if (curntBulInClip == maxClipSize) { canReload = false; }

        if(clips == 0) { canReload = false; }
    }

    void FireType(GunType gun_)
    {
        switch (gun_)
        {
            case GunType.Pistol:

                bulRange = 100.0f;
                if(plyer.isFiring && canShoot)
                {
                    if (curntBulInClip > 0)
                    {
                        Shoot();
                    }
                }

                if (!canShoot && !plyer.isFiring)
                {
                    nextFire += Time.deltaTime;

                    if(nextFire >= 0.2f)
                    {
                        canShoot = true;
                        nextFire = 0.0f;
                    }
                }
                
                break;

            case GunType.Machine:
                
                break;
        }
   
    }

    void Shoot()
    {
        canShoot = false;
        --curntBulInClip;

        RaycastHit hit;
        var shootPoint = plyer.plyCanvas.worldCamera.transform;
        Debug.DrawLine(shootPoint.position, shootPoint.forward * bulRange, Color.red, 0.5f);
    
        if (Physics.Raycast(shootPoint.position, shootPoint.forward, out hit, bulRange))
        {
            //display name of what was hit in console
            Debug.Log(hit.transform.name);
            
        } 
    }

    void DeterminClipSize(GunType gun_)
    {
        switch (gun_)
        {
            case GunType.Pistol:
                curntBulInClip = maxClipSize = 8;
                damage = 1.0f;
                break;

            case GunType.Machine:
                curntBulInClip = maxClipSize = 25;
                damage = 0.5f;
                break;
        }
    }

    public void Reload()
    {
        if (curntBulInClip < maxClipSize)
        {
            curntBulInClip = maxClipSize;
            --clips;
        }
    }

}

