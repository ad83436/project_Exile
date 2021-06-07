// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gamepad"",
            ""id"": ""5ce37710-5873-480f-ac29-44fe7d39f834"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cdd81528-9ab1-4ca0-b543-01ad0217ebd3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnalogAim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""181c1dd8-dde8-46a1-abde-a06b6a9e0baa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""1a4467bf-0209-4a14-bda6-5ef22bb68d46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""e3e21be3-2fea-41e4-ad69-4c9efd7ada91"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f19cd1ea-fd13-4f9b-a2d5-e41e220f9cb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""3462bf25-0ccc-4057-9f72-9e25e2eb85e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""4e32095c-10ed-4985-9c98-7733ce3c7867"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""a5c43e87-c847-40cf-b0ac-f48393948b2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Analog"",
                    ""id"": ""88aaec0f-9157-43d7-84e8-3bdb104e84fd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3764e934-7261-45df-98b0-c95a51c747b8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""68ad1b5a-f62b-4cd9-b052-75e53bc550ca"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bbee49dc-ae6e-43c6-b55a-dc5d68a00696"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""81c081c1-b3b2-40b1-85ae-273e9978f46e"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Analog"",
                    ""id"": ""e2e836c6-212b-4b4c-9238-c09bf2b7a80a"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""AnalogAim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f01e0204-dec1-43dd-83f4-bc9a4d4b7231"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnalogAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fcb7ebdd-c7c9-4c62-904f-286c6f782d78"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnalogAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9a1d2564-063e-426e-898d-475dae10dd16"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnalogAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9b234d85-019e-4e7d-87ec-68f60d26c063"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnalogAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1d1db322-0931-41b8-8bf5-62ee20b9e039"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9db4a095-ea85-4607-be8e-124d518b71f0"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a51af460-ba24-476e-9416-492b793ad82b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e8211f4-194d-41fb-b11f-4aaf3fd001fb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86eab7f8-087d-45ae-9551-95554205b451"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a74ed66-ef64-4a11-9691-881a1ab9277a"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MouseAndKeyboard"",
            ""id"": ""2bb650e4-a873-4d21-a97b-299a766edc17"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5a8953c0-7c55-4922-bd8e-009d5911d4c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""10985dc2-5640-4ade-8e36-cc3033fb2944"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""06d0d903-1287-4a5a-8ff9-bbd4f9154ce0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseAim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3cc2e722-e9ff-4b3b-b1a3-82491b5187ce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""5edea818-4fbe-4fe6-90f4-dd80300e030d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""28a3d6db-2d8c-4119-8d3b-fe5faac9ee05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""169638dd-c67d-49fe-a387-605b54323558"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4514b76d-fc66-4b0e-8fd6-821266f4f30d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dbfe92fc-e7f8-4cf9-a4f9-62750e8c34a3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c1948a28-7146-449d-827f-7b7b39691870"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e5c4711a-666b-48e2-a35b-f3c77029ce91"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a9ce0fd5-2f64-46de-9ff3-813fdcfb7232"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a099e5f-a463-4f9e-9a11-c1dcdbd87a3b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a90886bc-f84c-41d6-8714-6d071263faf2"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""664e0afc-2b51-416e-9b31-41f0db352615"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d99ddfb8-cc8d-4d3a-8e5d-ff81d704118d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f50869b6-568a-4dbb-a772-49834a147cf1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InventoryUI"",
            ""id"": ""8e1b5963-216a-425d-9310-c2a07309e3ad"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""c29d7a03-1211-4e4e-8aee-e759c40ed4c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4ee2b215-f7cb-4693-ad3f-457d4c4e8b40"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""MouseAndKeyboard"",
            ""bindingGroup"": ""MouseAndKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gamepad
        m_Gamepad = asset.FindActionMap("Gamepad", throwIfNotFound: true);
        m_Gamepad_Move = m_Gamepad.FindAction("Move", throwIfNotFound: true);
        m_Gamepad_AnalogAim = m_Gamepad.FindAction("AnalogAim", throwIfNotFound: true);
        m_Gamepad_Run = m_Gamepad.FindAction("Run", throwIfNotFound: true);
        m_Gamepad_Aim = m_Gamepad.FindAction("Aim", throwIfNotFound: true);
        m_Gamepad_Shoot = m_Gamepad.FindAction("Shoot", throwIfNotFound: true);
        m_Gamepad_Reload = m_Gamepad.FindAction("Reload", throwIfNotFound: true);
        m_Gamepad_Interact = m_Gamepad.FindAction("Interact", throwIfNotFound: true);
        m_Gamepad_Inventory = m_Gamepad.FindAction("Inventory", throwIfNotFound: true);
        // MouseAndKeyboard
        m_MouseAndKeyboard = asset.FindActionMap("MouseAndKeyboard", throwIfNotFound: true);
        m_MouseAndKeyboard_Move = m_MouseAndKeyboard.FindAction("Move", throwIfNotFound: true);
        m_MouseAndKeyboard_Run = m_MouseAndKeyboard.FindAction("Run", throwIfNotFound: true);
        m_MouseAndKeyboard_Aim = m_MouseAndKeyboard.FindAction("Aim", throwIfNotFound: true);
        m_MouseAndKeyboard_MouseAim = m_MouseAndKeyboard.FindAction("MouseAim", throwIfNotFound: true);
        m_MouseAndKeyboard_Shoot = m_MouseAndKeyboard.FindAction("Shoot", throwIfNotFound: true);
        m_MouseAndKeyboard_Reload = m_MouseAndKeyboard.FindAction("Reload", throwIfNotFound: true);
        // InventoryUI
        m_InventoryUI = asset.FindActionMap("InventoryUI", throwIfNotFound: true);
        m_InventoryUI_Newaction = m_InventoryUI.FindAction("New action", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gamepad
    private readonly InputActionMap m_Gamepad;
    private IGamepadActions m_GamepadActionsCallbackInterface;
    private readonly InputAction m_Gamepad_Move;
    private readonly InputAction m_Gamepad_AnalogAim;
    private readonly InputAction m_Gamepad_Run;
    private readonly InputAction m_Gamepad_Aim;
    private readonly InputAction m_Gamepad_Shoot;
    private readonly InputAction m_Gamepad_Reload;
    private readonly InputAction m_Gamepad_Interact;
    private readonly InputAction m_Gamepad_Inventory;
    public struct GamepadActions
    {
        private @PlayerControls m_Wrapper;
        public GamepadActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gamepad_Move;
        public InputAction @AnalogAim => m_Wrapper.m_Gamepad_AnalogAim;
        public InputAction @Run => m_Wrapper.m_Gamepad_Run;
        public InputAction @Aim => m_Wrapper.m_Gamepad_Aim;
        public InputAction @Shoot => m_Wrapper.m_Gamepad_Shoot;
        public InputAction @Reload => m_Wrapper.m_Gamepad_Reload;
        public InputAction @Interact => m_Wrapper.m_Gamepad_Interact;
        public InputAction @Inventory => m_Wrapper.m_Gamepad_Inventory;
        public InputActionMap Get() { return m_Wrapper.m_Gamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadActions instance)
        {
            if (m_Wrapper.m_GamepadActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnMove;
                @AnalogAim.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAnalogAim;
                @AnalogAim.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAnalogAim;
                @AnalogAim.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAnalogAim;
                @Run.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRun;
                @Aim.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnAim;
                @Shoot.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnShoot;
                @Reload.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnReload;
                @Interact.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInteract;
                @Inventory.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnInventory;
            }
            m_Wrapper.m_GamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @AnalogAim.started += instance.OnAnalogAim;
                @AnalogAim.performed += instance.OnAnalogAim;
                @AnalogAim.canceled += instance.OnAnalogAim;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
            }
        }
    }
    public GamepadActions @Gamepad => new GamepadActions(this);

    // MouseAndKeyboard
    private readonly InputActionMap m_MouseAndKeyboard;
    private IMouseAndKeyboardActions m_MouseAndKeyboardActionsCallbackInterface;
    private readonly InputAction m_MouseAndKeyboard_Move;
    private readonly InputAction m_MouseAndKeyboard_Run;
    private readonly InputAction m_MouseAndKeyboard_Aim;
    private readonly InputAction m_MouseAndKeyboard_MouseAim;
    private readonly InputAction m_MouseAndKeyboard_Shoot;
    private readonly InputAction m_MouseAndKeyboard_Reload;
    public struct MouseAndKeyboardActions
    {
        private @PlayerControls m_Wrapper;
        public MouseAndKeyboardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MouseAndKeyboard_Move;
        public InputAction @Run => m_Wrapper.m_MouseAndKeyboard_Run;
        public InputAction @Aim => m_Wrapper.m_MouseAndKeyboard_Aim;
        public InputAction @MouseAim => m_Wrapper.m_MouseAndKeyboard_MouseAim;
        public InputAction @Shoot => m_Wrapper.m_MouseAndKeyboard_Shoot;
        public InputAction @Reload => m_Wrapper.m_MouseAndKeyboard_Reload;
        public InputActionMap Get() { return m_Wrapper.m_MouseAndKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseAndKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IMouseAndKeyboardActions instance)
        {
            if (m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnMove;
                @Run.started -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnRun;
                @Aim.started -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnAim;
                @MouseAim.started -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnMouseAim;
                @MouseAim.performed -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnMouseAim;
                @MouseAim.canceled -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnMouseAim;
                @Shoot.started -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnShoot;
                @Reload.started -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface.OnReload;
            }
            m_Wrapper.m_MouseAndKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @MouseAim.started += instance.OnMouseAim;
                @MouseAim.performed += instance.OnMouseAim;
                @MouseAim.canceled += instance.OnMouseAim;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
            }
        }
    }
    public MouseAndKeyboardActions @MouseAndKeyboard => new MouseAndKeyboardActions(this);

    // InventoryUI
    private readonly InputActionMap m_InventoryUI;
    private IInventoryUIActions m_InventoryUIActionsCallbackInterface;
    private readonly InputAction m_InventoryUI_Newaction;
    public struct InventoryUIActions
    {
        private @PlayerControls m_Wrapper;
        public InventoryUIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_InventoryUI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_InventoryUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryUIActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryUIActions instance)
        {
            if (m_Wrapper.m_InventoryUIActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_InventoryUIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public InventoryUIActions @InventoryUI => new InventoryUIActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_MouseAndKeyboardSchemeIndex = -1;
    public InputControlScheme MouseAndKeyboardScheme
    {
        get
        {
            if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseAndKeyboard");
            return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
        }
    }
    public interface IGamepadActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAnalogAim(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
    }
    public interface IMouseAndKeyboardActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnMouseAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
    public interface IInventoryUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
