//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/3. Scripts/Player/PlayerMap.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMap"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""bcd69149-0773-40c9-bfd4-4fe20cdd340c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""73b57e56-3ff3-44a3-9c4b-441c28abb0a4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""b179760c-9174-426a-81d7-313024cdc29a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c6e6a560-05d3-4879-b800-2b7f0dc54728"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""8c32baea-dcf5-4aa8-a377-82d3b53b466f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""f2790db4-d339-468a-8443-56243a802c69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Suicide"",
                    ""type"": ""Button"",
                    ""id"": ""c8d63b70-37f7-4079-aada-d28bd0ba182e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""9e03c2cb-a766-4e1d-bf28-43505bb3e1fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Teleport"",
                    ""type"": ""Button"",
                    ""id"": ""584474c3-6aaf-4c78-8ce8-484c964a46f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c64b2e85-d872-4a9c-8b7f-dfa2c1e2653f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b4093b4f-4f34-4d92-a173-8644a5c5a18c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d5907568-4855-4dec-9ecc-e20a5d6e6297"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73afcd58-5c50-4f33-902a-cb39980e0273"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""063cc703-64bd-4aea-8d24-ef8b4bd3095a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""60a430d6-72f6-49e7-9f1c-25c779054f87"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d16ea201-e261-42e1-baf8-54705b02ff1d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d71f0d69-43ca-41bf-a862-7fac4a9cc2c0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c15900bf-9403-4c74-bc43-ebc54934005b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe682bee-8f1b-42f1-a39c-34af4f3c8429"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a57fd46f-e9e0-49da-8de1-e0027fae633b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""279e3db5-095f-4a3b-bc05-6909be7d982b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""898014aa-0117-4c44-ba5d-a94264414e34"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea1996e2-6613-40e4-9f76-e990adf86235"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b4311c1-340e-45bb-92e8-f10b30d977ef"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Suicide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeb91d01-938f-473c-b107-bfc2f623a15e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3dec068b-9ebd-4c1a-90fd-135f4311efc3"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Movement = m_Default.FindAction("Movement", throwIfNotFound: true);
        m_Default_Dash = m_Default.FindAction("Dash", throwIfNotFound: true);
        m_Default_Attack = m_Default.FindAction("Attack", throwIfNotFound: true);
        m_Default_Aim = m_Default.FindAction("Aim", throwIfNotFound: true);
        m_Default_Special = m_Default.FindAction("Special", throwIfNotFound: true);
        m_Default_Suicide = m_Default.FindAction("Suicide", throwIfNotFound: true);
        m_Default_Pause = m_Default.FindAction("Pause", throwIfNotFound: true);
        m_Default_Teleport = m_Default.FindAction("Teleport", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Movement;
    private readonly InputAction m_Default_Dash;
    private readonly InputAction m_Default_Attack;
    private readonly InputAction m_Default_Aim;
    private readonly InputAction m_Default_Special;
    private readonly InputAction m_Default_Suicide;
    private readonly InputAction m_Default_Pause;
    private readonly InputAction m_Default_Teleport;
    public struct DefaultActions
    {
        private @PlayerMap m_Wrapper;
        public DefaultActions(@PlayerMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Default_Movement;
        public InputAction @Dash => m_Wrapper.m_Default_Dash;
        public InputAction @Attack => m_Wrapper.m_Default_Attack;
        public InputAction @Aim => m_Wrapper.m_Default_Aim;
        public InputAction @Special => m_Wrapper.m_Default_Special;
        public InputAction @Suicide => m_Wrapper.m_Default_Suicide;
        public InputAction @Pause => m_Wrapper.m_Default_Pause;
        public InputAction @Teleport => m_Wrapper.m_Default_Teleport;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Dash.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDash;
                @Attack.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAttack;
                @Aim.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAim;
                @Special.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSpecial;
                @Suicide.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSuicide;
                @Suicide.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSuicide;
                @Suicide.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSuicide;
                @Pause.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Teleport.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnTeleport;
                @Teleport.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnTeleport;
                @Teleport.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnTeleport;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
                @Suicide.started += instance.OnSuicide;
                @Suicide.performed += instance.OnSuicide;
                @Suicide.canceled += instance.OnSuicide;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Teleport.started += instance.OnTeleport;
                @Teleport.performed += instance.OnTeleport;
                @Teleport.canceled += instance.OnTeleport;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
        void OnSuicide(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnTeleport(InputAction.CallbackContext context);
    }
}
