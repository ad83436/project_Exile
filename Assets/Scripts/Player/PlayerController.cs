using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.InputSystem.Users;
using UnityEngine.Animations;

public class PlayerController : Souls
{
    public override AnimalType animalType() => AnimalType.None;
    PlayerControls _input;
    InputFunctions inputFunc;

    Player player;

    public bool isMoving { get; private set; }
    public bool isAiming { get; private set; }
    public bool isFiring { get; private set; }
    public bool isDrawing { get; private set; }
    public bool isReloading { get; private set;  }
    public bool isGamepad { get; private set; }
    public bool isMouseAndKeyboard { get; private set; }
    public bool isInteracting { get; private set; }

    bool isInventoryOpen = false;


    int aimChecker = -1; // used so the player only goes into the aim animation once 
    public float rotSpeed;

    public Vector2 currentMovement { get; private set; }
    public Vector2 aimInput { get; private set; }

    public Canvas plyCanvas;
    Image reticle;

    public GunType plyGunType;
    public Gun plyGun;
    public GameObject showGun;
    public GameObject right_Hand;
 
    private void Awake()
    {
        _input = new PlayerControls();
        inputFunc = new InputFunctions(this);

        //Mouse and Keyboard 
        _input.MouseAndKeyboard.Move.performed += ctx => currentMovement = ctx.ReadValue<Vector2>();
        _input.MouseAndKeyboard.MouseAim.performed += ctx => aimInput = ctx.ReadValue<Vector2>().normalized;

        _input.MouseAndKeyboard.Run.performed += ctx => isRunning = ctx.ReadValueAsButton();
        _input.MouseAndKeyboard.Aim.performed += ctx => isAiming = ctx.ReadValueAsButton();

        _input.MouseAndKeyboard.Shoot.performed += ctx => isFiring = true;
        _input.MouseAndKeyboard.Shoot.canceled += ctx => isFiring = false;

        _input.MouseAndKeyboard.Reload.performed += ctx => isReloading = true;
        _input.MouseAndKeyboard.Reload.canceled += ctx => isReloading = false;

        // Gamepad
        _input.Gamepad.Move.performed += ctx => currentMovement = ctx.ReadValue<Vector2>();
        _input.Gamepad.AnalogAim.performed += ctx => aimInput = ctx.ReadValue<Vector2>();

        _input.Gamepad.Run.performed += ctx => isRunning = ctx.ReadValueAsButton();
        _input.Gamepad.Aim.performed += ctx => isAiming = ctx.ReadValueAsButton();

        _input.Gamepad.Shoot.performed += ctx => isFiring = inputFunc.FireContext(ctx);
        _input.Gamepad.Shoot.canceled += ctx => isFiring = inputFunc.FireContext(ctx);

        _input.Gamepad.Reload.performed += ctx => isReloading = true;
        _input.Gamepad.Reload.canceled += ctx => isReloading = false;

        //might add some functions iInputFunctions class to add this to inventory instead of the item adding itself 
        _input.Gamepad.Interact.performed += ctx => isInteracting = true;
        _input.Gamepad.Interact.canceled += ctx => isInteracting = false;

        player = GetComponent<Player>();

    }

    private void Start()
    {
        charaController = GetComponent<CharacterController>();
        soulAnimator = GetComponent<Animator>();
        reticle = plyCanvas.GetComponentInChildren<Image>();

        if (plyGun == null)
        {
            if (plyGunType == GunType.Pistol)
            {
                GameObject tmp = Instantiate(Resources.Load("Prefabs/Pistol") as GameObject, right_Hand.transform.position, right_Hand.transform.rotation);
                tmp.transform.parent = right_Hand.transform;
                tmp.transform.localEulerAngles = new Vector3(-10, 72, -100);
                tmp.transform.localPosition = new Vector3(.14f, .06f, 0f);
                plyGun = tmp.GetComponent<Gun>();

            }
            else if (plyGunType == GunType.Machine)
            {

            }
        }
    }

    private void Update()
    {
        if (!charaController.isGrounded) { charaController.Move(Vector3.down * speed * Time.deltaTime); }
        //ChangeInputDevice();
        UpdateMovingAnimations();
        Move();
        Aim();
        PlayerReload();
    }

    private void Move()
    {
        if (isRunning)
        {
            speed = 6;
            isRunning = true;
            isWalking = false;
        }
        else { 
           speed = 3;
            isWalking = true;
            isRunning = false;
        }
        Vector3 moveDir = transform.forward * currentMovement.y  * speed * Time.deltaTime;

        if (currentMovement.y != 0)
        {
            charaController.Move(moveDir);
            isMoving = true;

        }
        else
        {
            isWalking = false;
            isRunning = false;
            isMoving = false;
        }
    }

    private void Aim()
    {
        if (isAiming)
        {
            reticle.enabled = true;
            showGun.SetActive(false);
            if (aimChecker == -1)
            {
                soulAnimator.SetBool("isDrawing", true);
                plyGun.gameObject.SetActive(true);
                aimChecker++;
            }

        }
        else
        {
            reticle.enabled = false;
            showGun.SetActive(true); 
           if(plyGun != null) { plyGun.gameObject.SetActive(false); } 
            soulAnimator.SetBool("isAiming", false);
            soulAnimator.SetBool("isReloading", false);
            if (soulAnimator.GetBool("isDrawing")) { soulAnimator.SetBool("isDrawing", false); }
            aimChecker = -1;
        }
    }

    private void PlayerReload()
    {
        if (isReloading)
        {
            if (plyGun.canReload)
            {
                if (soulAnimator.GetBool("isAiming"))
                {
                    soulAnimator.SetBool("isReloading", true);
                }
            }
        }
    }

    void DrawEnd()// used by the Drawing Animation
    {
        soulAnimator.SetBool("isDrawing", false);
        soulAnimator.SetBool("isAiming", true);
    }

    void ReloadEnd()
    {
        if (plyGun != null) { plyGun.Reload(); }
        soulAnimator.SetBool("isReloading", false);
    }

    void UpdateMovingAnimations()
    {
        soulAnimator.SetBool("isWalking", isWalking);
        soulAnimator.SetBool("isRunning", isRunning);
        soulAnimator.SetBool("isMoving", isMoving);

    }

    private void OnEnable()
    {
        _input.MouseAndKeyboard.Enable();
        _input.Gamepad.Enable();
    }

    private void OnDisable()
    {
        _input.Gamepad.Disable();
        _input.MouseAndKeyboard.Disable();
    }

  /*  void ChangeInputDevice()
    {

        if (isMouseAndKeyboard)
        {
            _input.Gamepad.Disable();
            _input.MouseAndKeyboard.Enable();
            Debug.Log("Current Action Map is Mouse And Keyboard");
        }

        if (isGamepad)
        {
            _input.Gamepad.Enable();
            _input.MouseAndKeyboard.Disable();
            Debug.Log("Current Action Map is Gamepad");
        } 
        

        if(isMouseAndKeyboard && isGamepad)
        {
            if(Gamepad.current != null)
            {
                isGamepad = true;
                isMouseAndKeyboard = false;
            }

            else
            {
                isGamepad = false;
                isMouseAndKeyboard = true;
            }
            
        }

        if(Gamepad.current == null)
        {
            isGamepad = false;
            isMouseAndKeyboard = true;
        }
        else
        {
            isMouseAndKeyboard = false;
            isGamepad = true;
        }
    }*/

    public void OpenInventory(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && !isInventoryOpen)
        {
            isInventoryOpen = true;
            _input.Gamepad.Disable();
            player.GetInvetoryUI().invBackground.SetActive(true);
            player.GetInvetoryUI().GetItemSlotContainer().SetActive(true);
            Debug.Log("inventory should open");
        }

        else if (ctx.performed && isInventoryOpen)
        {
            isInventoryOpen = false;
            _input.Gamepad.Enable();
            player.GetInvetoryUI().invBackground.SetActive(false);
            player.GetInvetoryUI().GetItemSlotContainer().SetActive(false);
            Debug.Log("inventory should close");
        }
    }
}

