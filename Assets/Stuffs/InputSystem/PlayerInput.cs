// GENERATED AUTOMATICALLY FROM 'Assets/Stuffs/InputSystem/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""e6292523-73de-430e-ae19-f1b4701d5a10"",
            ""actions"": [
                {
                    ""name"": ""Acclerator"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c22206c7-50bd-4b55-9d53-e12383ebe3aa"",
                    ""expectedControlType"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""PassThrough"",
                    ""id"": ""482df77b-c79f-4e00-b950-daa901888076"",
                    ""expectedControlType"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3ee9549e-eb16-4563-a575-7fe69db94d8a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gear"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0d4fd7af-b102-4291-8f50-ea326dab4196"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e5ae3197-29cb-41f8-b5ee-c7968f3df5c9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acclerator"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6cc85da-c03c-4656-92cc-6a3d4a37e522"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acclerator"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61153969-fe68-4297-86df-a82332c3c4fa"",
                    ""path"": ""<HID::OpenChord X RMIT Exertion Games Lab UnoJoy Joystick>/z"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-0.5,zero=-0.4)"",
                    ""groups"": """",
                    ""action"": ""Acclerator"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6f2afed-86ba-4427-b0c4-accdc2afcd68"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32ed5d9a-07e6-4433-a4b4-4a99a6e713c2"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b20c78f-09ab-4232-b776-cee652544480"",
                    ""path"": ""<HID::OpenChord X RMIT Exertion Games Lab UnoJoy Joystick>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""906f1fca-47bb-4841-958f-efdbdb6bfe13"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""SteerKb"",
                    ""id"": ""fc2c19a6-a750-4adf-8739-d9a308603049"",
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
                    ""id"": ""af248659-f021-4090-ad92-7e0850204aa1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""105b91bd-5451-40c5-b138-fa207e2c9ae6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ecdc6fa7-8da2-475e-aac1-d5c59f0c4588"",
                    ""path"": ""<HID::OpenChord X RMIT Exertion Games Lab UnoJoy Joystick>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""gearKb"",
                    ""id"": ""bc699614-a6c6-436e-beaf-3c83288b1ba0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gear"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e16c65b0-7746-43ee-bd44-0bb582445174"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8fe21cf6-7190-481c-a0c2-d02cb0345bc1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Car
        m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
        m_Car_Acclerator = m_Car.FindAction("Acclerator", throwIfNotFound: true);
        m_Car_Brake = m_Car.FindAction("Brake", throwIfNotFound: true);
        m_Car_Steer = m_Car.FindAction("Steer", throwIfNotFound: true);
        m_Car_Gear = m_Car.FindAction("Gear", throwIfNotFound: true);
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
    private readonly InputAction m_Car_Acclerator;
    private readonly InputAction m_Car_Brake;
    private readonly InputAction m_Car_Steer;
    private readonly InputAction m_Car_Gear;
    public struct CarActions
    {
        private @PlayerInput m_Wrapper;
        public CarActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Acclerator => m_Wrapper.m_Car_Acclerator;
        public InputAction @Brake => m_Wrapper.m_Car_Brake;
        public InputAction @Steer => m_Wrapper.m_Car_Steer;
        public InputAction @Gear => m_Wrapper.m_Car_Gear;
        public InputActionMap Get() { return m_Wrapper.m_Car; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
        public void SetCallbacks(ICarActions instance)
        {
            if (m_Wrapper.m_CarActionsCallbackInterface != null)
            {
                @Acclerator.started -= m_Wrapper.m_CarActionsCallbackInterface.OnAcclerator;
                @Acclerator.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnAcclerator;
                @Acclerator.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnAcclerator;
                @Brake.started -= m_Wrapper.m_CarActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnBrake;
                @Steer.started -= m_Wrapper.m_CarActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnSteer;
                @Gear.started -= m_Wrapper.m_CarActionsCallbackInterface.OnGear;
                @Gear.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnGear;
                @Gear.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnGear;
            }
            m_Wrapper.m_CarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Acclerator.started += instance.OnAcclerator;
                @Acclerator.performed += instance.OnAcclerator;
                @Acclerator.canceled += instance.OnAcclerator;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @Gear.started += instance.OnGear;
                @Gear.performed += instance.OnGear;
                @Gear.canceled += instance.OnGear;
            }
        }
    }
    public CarActions @Car => new CarActions(this);
    public interface ICarActions
    {
        void OnAcclerator(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnGear(InputAction.CallbackContext context);
    }
}
