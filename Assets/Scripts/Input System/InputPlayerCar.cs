// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input System/InputPlayerCar.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputPlayerCar : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputPlayerCar()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputPlayerCar"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""ec6fbfea-7446-4afa-8ffc-d8067072489e"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""0bacdf0c-dbcf-4b52-80d5-fb4646f3f06d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Button"",
                    ""id"": ""e544e83c-a237-4015-9d37-88edc11e5ff0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ea4a0f86-db1c-4fc9-a173-f0230429b0e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""c7560884-2ff7-4237-8b84-5e37ebfcd9d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Accelerate"",
                    ""id"": ""4a356cc9-afcb-438c-9903-2d95edd4bf5b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8eb1b303-a2cd-454d-aba5-f09548ef6258"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""e11a1830-431b-43e7-a7bd-ecba0d0b2c57"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Steer"",
                    ""id"": ""e5e8a94a-b192-4c90-b79a-5980a0dde3f1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5ad682a2-a672-41ee-80ec-373163ff1806"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7db8da5f-a309-4208-878f-3d404d61edc1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8f9fe981-bd6c-46f1-854e-6098d1673267"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25f285c1-0130-4629-8f98-31299d36a9ba"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
        // Car
        m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
        m_Car_Accelerate = m_Car.FindAction("Accelerate", throwIfNotFound: true);
        m_Car_Steer = m_Car.FindAction("Steer", throwIfNotFound: true);
        m_Car_Jump = m_Car.FindAction("Jump", throwIfNotFound: true);
        m_Car_Reset = m_Car.FindAction("Reset", throwIfNotFound: true);
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

    // Car
    private readonly InputActionMap m_Car;
    private ICarActions m_CarActionsCallbackInterface;
    private readonly InputAction m_Car_Accelerate;
    private readonly InputAction m_Car_Steer;
    private readonly InputAction m_Car_Jump;
    private readonly InputAction m_Car_Reset;
    public struct CarActions
    {
        private @InputPlayerCar m_Wrapper;
        public CarActions(@InputPlayerCar wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Car_Accelerate;
        public InputAction @Steer => m_Wrapper.m_Car_Steer;
        public InputAction @Jump => m_Wrapper.m_Car_Jump;
        public InputAction @Reset => m_Wrapper.m_Car_Reset;
        public InputActionMap Get() { return m_Wrapper.m_Car; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
        public void SetCallbacks(ICarActions instance)
        {
            if (m_Wrapper.m_CarActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @Steer.started -= m_Wrapper.m_CarActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnSteer;
                @Jump.started -= m_Wrapper.m_CarActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnJump;
                @Reset.started -= m_Wrapper.m_CarActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnReset;
            }
            m_Wrapper.m_CarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
            }
        }
    }
    public CarActions @Car => new CarActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface ICarActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
}
