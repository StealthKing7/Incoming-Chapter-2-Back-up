//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Inputs/DefaultInputs.inputactions
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

public partial class @DefaultInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultInputs"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""87f97c28-a3e7-40fc-abc9-fb11cdfe63c9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c62ed9b2-cd56-4653-83c2-39aa470b117c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""13a277de-7b62-4766-8733-ed5bf6789710"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5dc80748-3a2c-4f4e-9493-8e4a76950755"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""02c99b95-72a2-4c02-9a7a-dd9deea52021"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""PassThrough"",
                    ""id"": ""44b5b482-bac6-4564-959f-b4bea832ad9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""181012f8-0995-4aad-b443-15e62e3a324c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SprintReleased"",
                    ""type"": ""Button"",
                    ""id"": ""82d91289-c8e0-4385-8da0-f53033b63156"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeftPressed"",
                    ""type"": ""Button"",
                    ""id"": ""fbaa0b53-fd46-403b-b04a-3645db1de3a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeftReleased"",
                    ""type"": ""Button"",
                    ""id"": ""9549b8bb-39cd-4e59-88b1-4f795b0198f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRightPressed"",
                    ""type"": ""Button"",
                    ""id"": ""2be6db34-ee24-4765-94d4-e268587852f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRightReleased"",
                    ""type"": ""Button"",
                    ""id"": ""a0111311-70ed-4a08-95a9-160115a5ae6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f1051076-4988-44e2-abda-15eb95984706"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5fe46780-4712-4b5a-b475-8202c8cbb4f5"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f324d830-c1b8-442e-bbc3-b056979af7bb"",
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
                    ""id"": ""98d35396-11ae-4b18-ae91-9c4bfc55a130"",
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
                    ""id"": ""34e63324-2c0c-46fa-893f-f8a761c1d86d"",
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
                    ""id"": ""14ecf7cc-ec2f-4ff5-81f9-fae1112bef79"",
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
                    ""id"": ""d8b08330-3f7a-4b40-b344-08146530e617"",
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
                    ""id"": ""b043c63b-4084-418d-95c5-dd35fd4ee61f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d6779a6-7331-4fe9-99f7-cc047f54002d"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""467de9d6-a9ff-4a97-ad50-c233a4dfb188"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffa2ecbb-b5ca-4956-b6a9-c234122f4fea"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57068f66-ef50-4e85-9217-df99b989cd40"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16b6c745-17ec-4c9b-9967-03084b28b068"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e4cf7c7-cc03-4f8d-897c-60f0b33621ce"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLeftPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ca37875-79b5-4b09-9b06-9603eb9c7937"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanRightPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5fd73b6-de56-4b61-abcf-e330a4442818"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLeftReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c4710a1-720c-41a6-9957-15e22a33513b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanRightReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f886d56a-f37b-495f-9bfd-ae0f25bf8294"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Weapon"",
            ""id"": ""2f0d5202-bac6-417e-952f-d30d410dd0cc"",
            ""actions"": [
                {
                    ""name"": ""Fire2Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""c4f9704b-5358-4aa0-b38e-76eb30cfa9a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire2Released"",
                    ""type"": ""Button"",
                    ""id"": ""39691c41-b4b6-4bd6-ba56-c1c239b9dcd8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""92e9f7df-8964-4aff-ad25-640ebc7f5563"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1Released"",
                    ""type"": ""Button"",
                    ""id"": ""78822e93-af48-4403-bfc9-4824e5083155"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d1619ed4-2b19-4e65-9786-921fd4705975"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6e97c0b-8348-4ee5-931c-ff67db6b4529"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b3f84f1-2dc6-4b86-8e40-ce5636b2557e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20dad69f-fa23-4aac-b231-ecd03844e0de"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_View = m_Character.FindAction("View", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_Crouch = m_Character.FindAction("Crouch", throwIfNotFound: true);
        m_Character_Prone = m_Character.FindAction("Prone", throwIfNotFound: true);
        m_Character_Sprint = m_Character.FindAction("Sprint", throwIfNotFound: true);
        m_Character_SprintReleased = m_Character.FindAction("SprintReleased", throwIfNotFound: true);
        m_Character_LeanLeftPressed = m_Character.FindAction("LeanLeftPressed", throwIfNotFound: true);
        m_Character_LeanLeftReleased = m_Character.FindAction("LeanLeftReleased", throwIfNotFound: true);
        m_Character_LeanRightPressed = m_Character.FindAction("LeanRightPressed", throwIfNotFound: true);
        m_Character_LeanRightReleased = m_Character.FindAction("LeanRightReleased", throwIfNotFound: true);
        m_Character_Interact = m_Character.FindAction("Interact", throwIfNotFound: true);
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_Fire2Pressed = m_Weapon.FindAction("Fire2Pressed", throwIfNotFound: true);
        m_Weapon_Fire2Released = m_Weapon.FindAction("Fire2Released", throwIfNotFound: true);
        m_Weapon_Fire1Pressed = m_Weapon.FindAction("Fire1Pressed", throwIfNotFound: true);
        m_Weapon_Fire1Released = m_Weapon.FindAction("Fire1Released", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_View;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_Crouch;
    private readonly InputAction m_Character_Prone;
    private readonly InputAction m_Character_Sprint;
    private readonly InputAction m_Character_SprintReleased;
    private readonly InputAction m_Character_LeanLeftPressed;
    private readonly InputAction m_Character_LeanLeftReleased;
    private readonly InputAction m_Character_LeanRightPressed;
    private readonly InputAction m_Character_LeanRightReleased;
    private readonly InputAction m_Character_Interact;
    public struct CharacterActions
    {
        private @DefaultInputs m_Wrapper;
        public CharacterActions(@DefaultInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @View => m_Wrapper.m_Character_View;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @Crouch => m_Wrapper.m_Character_Crouch;
        public InputAction @Prone => m_Wrapper.m_Character_Prone;
        public InputAction @Sprint => m_Wrapper.m_Character_Sprint;
        public InputAction @SprintReleased => m_Wrapper.m_Character_SprintReleased;
        public InputAction @LeanLeftPressed => m_Wrapper.m_Character_LeanLeftPressed;
        public InputAction @LeanLeftReleased => m_Wrapper.m_Character_LeanLeftReleased;
        public InputAction @LeanRightPressed => m_Wrapper.m_Character_LeanRightPressed;
        public InputAction @LeanRightReleased => m_Wrapper.m_Character_LeanRightReleased;
        public InputAction @Interact => m_Wrapper.m_Character_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @View.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Prone.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Prone.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Prone.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Sprint.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @SprintReleased.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
                @SprintReleased.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
                @SprintReleased.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
                @LeanLeftPressed.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftPressed;
                @LeanLeftPressed.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftPressed;
                @LeanLeftPressed.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftPressed;
                @LeanLeftReleased.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftReleased;
                @LeanLeftReleased.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftReleased;
                @LeanLeftReleased.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftReleased;
                @LeanRightPressed.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightPressed;
                @LeanRightPressed.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightPressed;
                @LeanRightPressed.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightPressed;
                @LeanRightReleased.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightReleased;
                @LeanRightReleased.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightReleased;
                @LeanRightReleased.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightReleased;
                @Interact.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Prone.started += instance.OnProne;
                @Prone.performed += instance.OnProne;
                @Prone.canceled += instance.OnProne;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @SprintReleased.started += instance.OnSprintReleased;
                @SprintReleased.performed += instance.OnSprintReleased;
                @SprintReleased.canceled += instance.OnSprintReleased;
                @LeanLeftPressed.started += instance.OnLeanLeftPressed;
                @LeanLeftPressed.performed += instance.OnLeanLeftPressed;
                @LeanLeftPressed.canceled += instance.OnLeanLeftPressed;
                @LeanLeftReleased.started += instance.OnLeanLeftReleased;
                @LeanLeftReleased.performed += instance.OnLeanLeftReleased;
                @LeanLeftReleased.canceled += instance.OnLeanLeftReleased;
                @LeanRightPressed.started += instance.OnLeanRightPressed;
                @LeanRightPressed.performed += instance.OnLeanRightPressed;
                @LeanRightPressed.canceled += instance.OnLeanRightPressed;
                @LeanRightReleased.started += instance.OnLeanRightReleased;
                @LeanRightReleased.performed += instance.OnLeanRightReleased;
                @LeanRightReleased.canceled += instance.OnLeanRightReleased;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Weapon
    private readonly InputActionMap m_Weapon;
    private IWeaponActions m_WeaponActionsCallbackInterface;
    private readonly InputAction m_Weapon_Fire2Pressed;
    private readonly InputAction m_Weapon_Fire2Released;
    private readonly InputAction m_Weapon_Fire1Pressed;
    private readonly InputAction m_Weapon_Fire1Released;
    public struct WeaponActions
    {
        private @DefaultInputs m_Wrapper;
        public WeaponActions(@DefaultInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire2Pressed => m_Wrapper.m_Weapon_Fire2Pressed;
        public InputAction @Fire2Released => m_Wrapper.m_Weapon_Fire2Released;
        public InputAction @Fire1Pressed => m_Wrapper.m_Weapon_Fire1Pressed;
        public InputAction @Fire1Released => m_Wrapper.m_Weapon_Fire1Released;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterface != null)
            {
                @Fire2Pressed.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Pressed.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Pressed.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Released.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
                @Fire2Released.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
                @Fire2Released.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
                @Fire1Pressed.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Pressed;
                @Fire1Pressed.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Pressed;
                @Fire1Pressed.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Pressed;
                @Fire1Released.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Released;
                @Fire1Released.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Released;
                @Fire1Released.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Released;
            }
            m_Wrapper.m_WeaponActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire2Pressed.started += instance.OnFire2Pressed;
                @Fire2Pressed.performed += instance.OnFire2Pressed;
                @Fire2Pressed.canceled += instance.OnFire2Pressed;
                @Fire2Released.started += instance.OnFire2Released;
                @Fire2Released.performed += instance.OnFire2Released;
                @Fire2Released.canceled += instance.OnFire2Released;
                @Fire1Pressed.started += instance.OnFire1Pressed;
                @Fire1Pressed.performed += instance.OnFire1Pressed;
                @Fire1Pressed.canceled += instance.OnFire1Pressed;
                @Fire1Released.started += instance.OnFire1Released;
                @Fire1Released.performed += instance.OnFire1Released;
                @Fire1Released.canceled += instance.OnFire1Released;
            }
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);
    public interface ICharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnProne(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSprintReleased(InputAction.CallbackContext context);
        void OnLeanLeftPressed(InputAction.CallbackContext context);
        void OnLeanLeftReleased(InputAction.CallbackContext context);
        void OnLeanRightPressed(InputAction.CallbackContext context);
        void OnLeanRightReleased(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IWeaponActions
    {
        void OnFire2Pressed(InputAction.CallbackContext context);
        void OnFire2Released(InputAction.CallbackContext context);
        void OnFire1Pressed(InputAction.CallbackContext context);
        void OnFire1Released(InputAction.CallbackContext context);
    }
}
