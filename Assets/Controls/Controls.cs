// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Attract"",
            ""id"": ""d8d970a6-42f9-4b92-98bf-ca9215c52672"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""d844bab3-dbd2-4d62-bd4a-02851000bf08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24a9d4f5-b1fd-4fd9-83d3-c681d16ec7b9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d19adfc0-fc1a-42f7-a011-18bb923987f1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c43a862-5dab-483b-89de-ea023004a441"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20b01ae1-87af-4351-a4a7-c73981b9adbb"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae4e1815-628b-4470-a8b8-6f10ab75a3a4"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ce2313a-261e-4c3a-86f3-c682c6b34a5b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08792b59-aeeb-4603-ab47-7dca28980ce4"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0694bc49-5586-404f-be74-4d6634f83bac"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14d77a37-9d40-4ad0-95ac-59229c595a69"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40aa4449-4e3c-4ff7-ae34-691ad5e6a59d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""614deafe-a40e-4a2e-a346-36723b78dbe9"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4f7a8f1-d918-4b0f-9416-5c3d2b40c554"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Loading"",
            ""id"": ""2d9cce9b-a1bd-4f33-86c1-490eb6753515"",
            ""actions"": [
                {
                    ""name"": ""Next Hint"",
                    ""type"": ""Button"",
                    ""id"": ""f37d9b11-dced-45ef-a370-e42433516b28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Previous Hint"",
                    ""type"": ""Button"",
                    ""id"": ""f13e2d9d-11e0-4c25-b724-95ecb100461e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""ed4e861a-53ad-4ac1-a612-b20dc0015911"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa3097ea-87d0-41ae-94ba-2dd6f3dc0d2f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Next Hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db2203b9-be46-47b2-a791-9becd77fac42"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Next Hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23e748de-ffaf-4fe1-a542-6b2e1ab8e22c"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Next Hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0922f375-1abf-486b-aa5e-1bf6e8b1e381"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Previous Hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""349977c5-a96c-4b4f-a459-efd4137d3e75"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Previous Hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc8b2350-7d41-47ab-bc3a-9054bb2d4860"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Previous Hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb69b7a4-8cd0-46e9-b3a6-2e2fb0ee7b09"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuOneDimension"",
            ""id"": ""cd90df14-2126-48d2-a885-f18c8c952340"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""46d6e192-6aa8-4a51-9eba-fed9c5d66180"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""f10535c9-4f91-4c04-8e37-c2d8c933e922"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""b127d72b-84fa-4841-adb7-c3540c582fbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backward"",
                    ""type"": ""Button"",
                    ""id"": ""78de8936-6a5c-4cfa-9232-d8bc40725d3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""875773f0-695d-4d46-9eaf-0ee5eb3c50ec"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9ec56b6-437d-4c58-9b19-c07053b0104a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edb9888f-d19a-4f2a-89df-66bef5205457"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0666a265-3c17-4d85-b951-57b2c08689d6"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a94a47a0-c754-4e61-8242-b0eff73dda1b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29fe943b-36ae-43a7-9646-aba842741b31"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""094287a6-c53e-4aee-8d0a-3204184b9ba5"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""baba2a0e-aebc-44b2-b17b-656f001ce3e4"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8472649d-a9e1-43c0-a49c-8213474f28a8"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6e8b832-e773-4b4e-8651-1135255f8374"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9d5e338-e220-4234-9867-fb1ab9fb012a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""744103f8-f253-4596-a544-a55c7e706911"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8dde59d-3961-45f8-984a-e168d6bd7e2a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aff0beb5-9e26-437f-8fc2-250374a36e3b"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuTwoDimension"",
            ""id"": ""0eddd5c1-ae10-4718-8401-46a57094ad7c"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""9e49eff0-c5a3-4a6a-ac70-6671d819c859"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""e4176c5d-6f48-4da7-8454-f149f8791d6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""c01dbc55-e8c7-4d75-8eb3-34de791728b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""e884ec99-9c4e-413e-87a5-454f757bc212"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backward"",
                    ""type"": ""Button"",
                    ""id"": ""dde42cdb-ca2c-495a-a30c-171089145b76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cd06de40-5e93-4ffa-96e9-90197b180479"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""797e75a1-5341-4ae0-a34f-2b9c001525a7"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9789b2de-c3b5-4869-af1b-1679740b95bc"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3edc0060-7a20-4129-9a31-35b4158de10e"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d844868c-06cb-4ea3-a00e-a774ac29372f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""df87ec94-b129-41c1-a7fa-3b0658ceeafb"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""96fe1bad-d175-4c25-8f5c-db51283d593e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dcd614e9-bdaa-4026-b528-3b8fd36581de"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Basic"",
            ""id"": ""c8f74e72-5382-4606-ac66-82c29eb71a56"",
            ""actions"": [
                {
                    ""name"": ""ToggleLookMode"",
                    ""type"": ""Button"",
                    ""id"": ""33598ac4-0f15-444b-a603-9e9020ceeacd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleInternalConsole"",
                    ""type"": ""Button"",
                    ""id"": ""26caa65f-05f8-47a1-a2dc-b64c943b8e87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleExternalConsole"",
                    ""type"": ""Button"",
                    ""id"": ""d8db371b-a4f6-43b1-9530-eaa940e08417"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4c9b7b3d-e4a0-42e2-a88c-c23e71f8a140"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ToggleLookMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0518345b-7e4b-461d-bd67-86fd66817e51"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ToggleInternalConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""787d953d-9928-459b-a0b5-71a81bfb1d3a"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ToggleExternalConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Free Look"",
            ""id"": ""757390bc-ed4a-4935-a05f-57073c267b5d"",
            ""actions"": [
                {
                    ""name"": ""Center"",
                    ""type"": ""Button"",
                    ""id"": ""f91eb804-0e6c-4d87-a9d4-88a06f3fd8bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookX"",
                    ""type"": ""Value"",
                    ""id"": ""3a59be5a-5d01-4c1f-b372-0d1d17c63101"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookY"",
                    ""type"": ""Value"",
                    ""id"": ""738ade7a-6097-4ce8-9f90-35792c24844e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""04e75582-b8c3-48d7-a5ee-f82b2904c31b"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f858e72d-853c-4489-af97-3dc0be1a49a8"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f15fcabf-aba9-41a5-b2f4-cef5d81daf69"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Internal Console"",
            ""id"": ""08dea574-0fce-4582-8367-965fbcc08905"",
            ""actions"": [
                {
                    ""name"": ""Console 1"",
                    ""type"": ""Button"",
                    ""id"": ""3da69172-f522-4b74-bce3-4dc8aba5cb7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 2"",
                    ""type"": ""Button"",
                    ""id"": ""d14a566e-6632-4543-9828-1750928573b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 3"",
                    ""type"": ""Button"",
                    ""id"": ""883c0d6c-83f7-4858-b8be-db99ce8d9e9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 4"",
                    ""type"": ""Button"",
                    ""id"": ""82aa48e2-f913-4d06-a41d-f56df163793f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7fb8858-7ae0-41ea-b69f-2a139c200bb7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0591b124-f1c0-4222-b050-efc89b9e480a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc845825-9d43-4ad8-a37a-bb83f04a2d2b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a64b9dc6-4257-4c52-8c43-3ec89a898856"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle External Console"",
            ""id"": ""bd8b5bd7-8f33-4d82-9df3-d6126c989ea1"",
            ""actions"": [
                {
                    ""name"": ""Console 1"",
                    ""type"": ""Button"",
                    ""id"": ""3953b9a1-24ac-4233-bdd5-25ed920abc9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 2"",
                    ""type"": ""Button"",
                    ""id"": ""ac476479-286c-4ace-b770-05778059a66b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 3"",
                    ""type"": ""Button"",
                    ""id"": ""e4053a5a-c02f-48a5-b91a-ab6c7643e16a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 4"",
                    ""type"": ""Button"",
                    ""id"": ""d3a6c666-4bc9-4adf-abc0-f4795b01cb0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3b316f3a-d32b-4dde-8e13-3d816f0f1d26"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b334b7f-7c52-4450-9c96-453663771e3f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97873193-521c-44d3-98f9-9f41bfc8d5e4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ed62ae3-39a5-4e7a-9208-bcda089386f7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Attitudes"",
            ""id"": ""30ae359c-0ef6-4924-8778-421efc9187d1"",
            ""actions"": [
                {
                    ""name"": ""PitchUp"",
                    ""type"": ""Value"",
                    ""id"": ""c8cf42f4-f6fe-46e5-bcac-5ab25ba879db"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PitchDown"",
                    ""type"": ""Button"",
                    ""id"": ""6ea9e3fa-82a8-49da-8d1c-2fb27483f3c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""YawRight"",
                    ""type"": ""Value"",
                    ""id"": ""7c0141db-6241-4ab5-a687-487a367f576c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""YawLeft"",
                    ""type"": ""Button"",
                    ""id"": ""038ceadd-46ec-476e-8625-869d036e158c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RollRight"",
                    ""type"": ""Button"",
                    ""id"": ""09dc1526-1511-4b76-ab04-d79388c0c845"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RollLeft"",
                    ""type"": ""Button"",
                    ""id"": ""419dff94-a8de-4dbb-862c-e851a3ff8812"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ca2c9176-3c1a-473e-b7c9-799785c8df2f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RollRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f281e4b-786e-4da1-b1eb-8b29e724e577"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""YawRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e59660ab-b2c4-47ae-94b9-e367101eb3a2"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RollLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dba0089-6f1a-4680-883e-62ba5584d4f9"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""YawLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88c6ebc0-9925-45c7-9e82-252bdb05600a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PitchUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfb33810-7432-4777-a0c2-360b93ab08d6"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PitchDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Attitude Dampeners"",
            ""id"": ""fbba9ce5-e3d7-413b-8dc6-8b5aa80ce6ec"",
            ""actions"": [
                {
                    ""name"": ""Center"",
                    ""type"": ""Button"",
                    ""id"": ""42768b1b-5d71-4eda-879c-7a682d7bc000"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9ad80487-5112-4171-bca5-ff0a8f7e4840"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Dampeners"",
            ""id"": ""21146c3e-3175-4fde-9305-2e578313896b"",
            ""actions"": [
                {
                    ""name"": ""DampenSurge"",
                    ""type"": ""Button"",
                    ""id"": ""5706c471-a4e7-4722-bba3-d09aadfcbc70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DampenSway"",
                    ""type"": ""Button"",
                    ""id"": ""4eeaccc2-54dc-4f2f-8dd7-cb5c51ffd1d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DampenHeave"",
                    ""type"": ""Button"",
                    ""id"": ""23bae116-9955-4898-8066-f4db97fb1e5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DampenAllMotors"",
                    ""type"": ""Button"",
                    ""id"": ""b5123a40-adbc-4573-ba35-54c2aa9528e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ece78abe-37f2-424b-ab9b-eda6bb9028ee"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DampenSurge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19519cc1-16f7-4b08-8209-742c9a58a64a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DampenSway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a4434bb-9476-4247-8747-2ab915a05bc1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DampenHeave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e809d4e-e04d-44f8-9b11-7159ea23cebd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DampenAllMotors"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Motors"",
            ""id"": ""38784511-9714-4d1f-af57-08bea864fbff"",
            ""actions"": [
                {
                    ""name"": ""SwayRight"",
                    ""type"": ""Value"",
                    ""id"": ""3516a35c-c134-4ebc-ac65-8c11c31b6ac2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwayLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c48df2dc-c1ab-42a6-9959-6f644c2944a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeaveUp"",
                    ""type"": ""Button"",
                    ""id"": ""621d6156-315b-4256-9810-ec49dd48af00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeaveDown"",
                    ""type"": ""Button"",
                    ""id"": ""1dbca3b5-9166-4137-9e72-dd6d4cf5f426"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SurgeUp"",
                    ""type"": ""Value"",
                    ""id"": ""49b1f41e-e906-4ff9-9274-806cff5fb92f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SurgeDown"",
                    ""type"": ""Button"",
                    ""id"": ""41b33dc3-bbcf-4198-8987-72f53364a078"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7f90ef75-2988-492e-88a1-78946f0e9eed"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SwayRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69e06acd-e777-43be-ae7b-ebfdbbfcb37a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SurgeUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b6adfe4-539a-456c-8509-a59f6706e05a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SurgeDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7c0b1e4-831d-4708-808c-c29ffad34cac"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SwayLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9970788c-ea98-45cd-af43-7a893e7381e5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HeaveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c78bbd0f-b323-48d8-b9cf-5691b5c4a484"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HeaveDown"",
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
        }
    ]
}");
        // Attract
        m_Attract = asset.FindActionMap("Attract", throwIfNotFound: true);
        m_Attract_Interact = m_Attract.FindAction("Interact", throwIfNotFound: true);
        // Loading
        m_Loading = asset.FindActionMap("Loading", throwIfNotFound: true);
        m_Loading_NextHint = m_Loading.FindAction("Next Hint", throwIfNotFound: true);
        m_Loading_PreviousHint = m_Loading.FindAction("Previous Hint", throwIfNotFound: true);
        m_Loading_Continue = m_Loading.FindAction("Continue", throwIfNotFound: true);
        // MenuOneDimension
        m_MenuOneDimension = asset.FindActionMap("MenuOneDimension", throwIfNotFound: true);
        m_MenuOneDimension_Confirm = m_MenuOneDimension.FindAction("Confirm", throwIfNotFound: true);
        m_MenuOneDimension_Cancel = m_MenuOneDimension.FindAction("Cancel", throwIfNotFound: true);
        m_MenuOneDimension_Forward = m_MenuOneDimension.FindAction("Forward", throwIfNotFound: true);
        m_MenuOneDimension_Backward = m_MenuOneDimension.FindAction("Backward", throwIfNotFound: true);
        // MenuTwoDimension
        m_MenuTwoDimension = asset.FindActionMap("MenuTwoDimension", throwIfNotFound: true);
        m_MenuTwoDimension_Confirm = m_MenuTwoDimension.FindAction("Confirm", throwIfNotFound: true);
        m_MenuTwoDimension_Up = m_MenuTwoDimension.FindAction("Up", throwIfNotFound: true);
        m_MenuTwoDimension_Down = m_MenuTwoDimension.FindAction("Down", throwIfNotFound: true);
        m_MenuTwoDimension_Forward = m_MenuTwoDimension.FindAction("Forward", throwIfNotFound: true);
        m_MenuTwoDimension_Backward = m_MenuTwoDimension.FindAction("Backward", throwIfNotFound: true);
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_Menu = m_Game.FindAction("Menu", throwIfNotFound: true);
        // Vehicle Basic
        m_VehicleBasic = asset.FindActionMap("Vehicle Basic", throwIfNotFound: true);
        m_VehicleBasic_ToggleLookMode = m_VehicleBasic.FindAction("ToggleLookMode", throwIfNotFound: true);
        m_VehicleBasic_ToggleInternalConsole = m_VehicleBasic.FindAction("ToggleInternalConsole", throwIfNotFound: true);
        m_VehicleBasic_ToggleExternalConsole = m_VehicleBasic.FindAction("ToggleExternalConsole", throwIfNotFound: true);
        // Vehicle Free Look
        m_VehicleFreeLook = asset.FindActionMap("Vehicle Free Look", throwIfNotFound: true);
        m_VehicleFreeLook_Center = m_VehicleFreeLook.FindAction("Center", throwIfNotFound: true);
        m_VehicleFreeLook_LookX = m_VehicleFreeLook.FindAction("LookX", throwIfNotFound: true);
        m_VehicleFreeLook_LookY = m_VehicleFreeLook.FindAction("LookY", throwIfNotFound: true);
        // Vehicle Internal Console
        m_VehicleInternalConsole = asset.FindActionMap("Vehicle Internal Console", throwIfNotFound: true);
        m_VehicleInternalConsole_Console1 = m_VehicleInternalConsole.FindAction("Console 1", throwIfNotFound: true);
        m_VehicleInternalConsole_Console2 = m_VehicleInternalConsole.FindAction("Console 2", throwIfNotFound: true);
        m_VehicleInternalConsole_Console3 = m_VehicleInternalConsole.FindAction("Console 3", throwIfNotFound: true);
        m_VehicleInternalConsole_Console4 = m_VehicleInternalConsole.FindAction("Console 4", throwIfNotFound: true);
        // Vehicle External Console
        m_VehicleExternalConsole = asset.FindActionMap("Vehicle External Console", throwIfNotFound: true);
        m_VehicleExternalConsole_Console1 = m_VehicleExternalConsole.FindAction("Console 1", throwIfNotFound: true);
        m_VehicleExternalConsole_Console2 = m_VehicleExternalConsole.FindAction("Console 2", throwIfNotFound: true);
        m_VehicleExternalConsole_Console3 = m_VehicleExternalConsole.FindAction("Console 3", throwIfNotFound: true);
        m_VehicleExternalConsole_Console4 = m_VehicleExternalConsole.FindAction("Console 4", throwIfNotFound: true);
        // Vehicle Attitudes
        m_VehicleAttitudes = asset.FindActionMap("Vehicle Attitudes", throwIfNotFound: true);
        m_VehicleAttitudes_PitchUp = m_VehicleAttitudes.FindAction("PitchUp", throwIfNotFound: true);
        m_VehicleAttitudes_PitchDown = m_VehicleAttitudes.FindAction("PitchDown", throwIfNotFound: true);
        m_VehicleAttitudes_YawRight = m_VehicleAttitudes.FindAction("YawRight", throwIfNotFound: true);
        m_VehicleAttitudes_YawLeft = m_VehicleAttitudes.FindAction("YawLeft", throwIfNotFound: true);
        m_VehicleAttitudes_RollRight = m_VehicleAttitudes.FindAction("RollRight", throwIfNotFound: true);
        m_VehicleAttitudes_RollLeft = m_VehicleAttitudes.FindAction("RollLeft", throwIfNotFound: true);
        // Vehicle Attitude Dampeners
        m_VehicleAttitudeDampeners = asset.FindActionMap("Vehicle Attitude Dampeners", throwIfNotFound: true);
        m_VehicleAttitudeDampeners_Center = m_VehicleAttitudeDampeners.FindAction("Center", throwIfNotFound: true);
        // Vehicle Dampeners
        m_VehicleDampeners = asset.FindActionMap("Vehicle Dampeners", throwIfNotFound: true);
        m_VehicleDampeners_DampenSurge = m_VehicleDampeners.FindAction("DampenSurge", throwIfNotFound: true);
        m_VehicleDampeners_DampenSway = m_VehicleDampeners.FindAction("DampenSway", throwIfNotFound: true);
        m_VehicleDampeners_DampenHeave = m_VehicleDampeners.FindAction("DampenHeave", throwIfNotFound: true);
        m_VehicleDampeners_DampenAllMotors = m_VehicleDampeners.FindAction("DampenAllMotors", throwIfNotFound: true);
        // Vehicle Motors
        m_VehicleMotors = asset.FindActionMap("Vehicle Motors", throwIfNotFound: true);
        m_VehicleMotors_SwayRight = m_VehicleMotors.FindAction("SwayRight", throwIfNotFound: true);
        m_VehicleMotors_SwayLeft = m_VehicleMotors.FindAction("SwayLeft", throwIfNotFound: true);
        m_VehicleMotors_HeaveUp = m_VehicleMotors.FindAction("HeaveUp", throwIfNotFound: true);
        m_VehicleMotors_HeaveDown = m_VehicleMotors.FindAction("HeaveDown", throwIfNotFound: true);
        m_VehicleMotors_SurgeUp = m_VehicleMotors.FindAction("SurgeUp", throwIfNotFound: true);
        m_VehicleMotors_SurgeDown = m_VehicleMotors.FindAction("SurgeDown", throwIfNotFound: true);
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

    // Attract
    private readonly InputActionMap m_Attract;
    private IAttractActions m_AttractActionsCallbackInterface;
    private readonly InputAction m_Attract_Interact;
    public struct AttractActions
    {
        private @Controls m_Wrapper;
        public AttractActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Attract_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Attract; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttractActions set) { return set.Get(); }
        public void SetCallbacks(IAttractActions instance)
        {
            if (m_Wrapper.m_AttractActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_AttractActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_AttractActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_AttractActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_AttractActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public AttractActions @Attract => new AttractActions(this);

    // Loading
    private readonly InputActionMap m_Loading;
    private ILoadingActions m_LoadingActionsCallbackInterface;
    private readonly InputAction m_Loading_NextHint;
    private readonly InputAction m_Loading_PreviousHint;
    private readonly InputAction m_Loading_Continue;
    public struct LoadingActions
    {
        private @Controls m_Wrapper;
        public LoadingActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextHint => m_Wrapper.m_Loading_NextHint;
        public InputAction @PreviousHint => m_Wrapper.m_Loading_PreviousHint;
        public InputAction @Continue => m_Wrapper.m_Loading_Continue;
        public InputActionMap Get() { return m_Wrapper.m_Loading; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LoadingActions set) { return set.Get(); }
        public void SetCallbacks(ILoadingActions instance)
        {
            if (m_Wrapper.m_LoadingActionsCallbackInterface != null)
            {
                @NextHint.started -= m_Wrapper.m_LoadingActionsCallbackInterface.OnNextHint;
                @NextHint.performed -= m_Wrapper.m_LoadingActionsCallbackInterface.OnNextHint;
                @NextHint.canceled -= m_Wrapper.m_LoadingActionsCallbackInterface.OnNextHint;
                @PreviousHint.started -= m_Wrapper.m_LoadingActionsCallbackInterface.OnPreviousHint;
                @PreviousHint.performed -= m_Wrapper.m_LoadingActionsCallbackInterface.OnPreviousHint;
                @PreviousHint.canceled -= m_Wrapper.m_LoadingActionsCallbackInterface.OnPreviousHint;
                @Continue.started -= m_Wrapper.m_LoadingActionsCallbackInterface.OnContinue;
                @Continue.performed -= m_Wrapper.m_LoadingActionsCallbackInterface.OnContinue;
                @Continue.canceled -= m_Wrapper.m_LoadingActionsCallbackInterface.OnContinue;
            }
            m_Wrapper.m_LoadingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextHint.started += instance.OnNextHint;
                @NextHint.performed += instance.OnNextHint;
                @NextHint.canceled += instance.OnNextHint;
                @PreviousHint.started += instance.OnPreviousHint;
                @PreviousHint.performed += instance.OnPreviousHint;
                @PreviousHint.canceled += instance.OnPreviousHint;
                @Continue.started += instance.OnContinue;
                @Continue.performed += instance.OnContinue;
                @Continue.canceled += instance.OnContinue;
            }
        }
    }
    public LoadingActions @Loading => new LoadingActions(this);

    // MenuOneDimension
    private readonly InputActionMap m_MenuOneDimension;
    private IMenuOneDimensionActions m_MenuOneDimensionActionsCallbackInterface;
    private readonly InputAction m_MenuOneDimension_Confirm;
    private readonly InputAction m_MenuOneDimension_Cancel;
    private readonly InputAction m_MenuOneDimension_Forward;
    private readonly InputAction m_MenuOneDimension_Backward;
    public struct MenuOneDimensionActions
    {
        private @Controls m_Wrapper;
        public MenuOneDimensionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_MenuOneDimension_Confirm;
        public InputAction @Cancel => m_Wrapper.m_MenuOneDimension_Cancel;
        public InputAction @Forward => m_Wrapper.m_MenuOneDimension_Forward;
        public InputAction @Backward => m_Wrapper.m_MenuOneDimension_Backward;
        public InputActionMap Get() { return m_Wrapper.m_MenuOneDimension; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuOneDimensionActions set) { return set.Get(); }
        public void SetCallbacks(IMenuOneDimensionActions instance)
        {
            if (m_Wrapper.m_MenuOneDimensionActionsCallbackInterface != null)
            {
                @Confirm.started -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnCancel;
                @Forward.started -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnForward;
                @Backward.started -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnBackward;
                @Backward.performed -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnBackward;
                @Backward.canceled -= m_Wrapper.m_MenuOneDimensionActionsCallbackInterface.OnBackward;
            }
            m_Wrapper.m_MenuOneDimensionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Backward.started += instance.OnBackward;
                @Backward.performed += instance.OnBackward;
                @Backward.canceled += instance.OnBackward;
            }
        }
    }
    public MenuOneDimensionActions @MenuOneDimension => new MenuOneDimensionActions(this);

    // MenuTwoDimension
    private readonly InputActionMap m_MenuTwoDimension;
    private IMenuTwoDimensionActions m_MenuTwoDimensionActionsCallbackInterface;
    private readonly InputAction m_MenuTwoDimension_Confirm;
    private readonly InputAction m_MenuTwoDimension_Up;
    private readonly InputAction m_MenuTwoDimension_Down;
    private readonly InputAction m_MenuTwoDimension_Forward;
    private readonly InputAction m_MenuTwoDimension_Backward;
    public struct MenuTwoDimensionActions
    {
        private @Controls m_Wrapper;
        public MenuTwoDimensionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_MenuTwoDimension_Confirm;
        public InputAction @Up => m_Wrapper.m_MenuTwoDimension_Up;
        public InputAction @Down => m_Wrapper.m_MenuTwoDimension_Down;
        public InputAction @Forward => m_Wrapper.m_MenuTwoDimension_Forward;
        public InputAction @Backward => m_Wrapper.m_MenuTwoDimension_Backward;
        public InputActionMap Get() { return m_Wrapper.m_MenuTwoDimension; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuTwoDimensionActions set) { return set.Get(); }
        public void SetCallbacks(IMenuTwoDimensionActions instance)
        {
            if (m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface != null)
            {
                @Confirm.started -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnConfirm;
                @Up.started -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnDown;
                @Forward.started -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnForward;
                @Backward.started -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnBackward;
                @Backward.performed -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnBackward;
                @Backward.canceled -= m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface.OnBackward;
            }
            m_Wrapper.m_MenuTwoDimensionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Backward.started += instance.OnBackward;
                @Backward.performed += instance.OnBackward;
                @Backward.canceled += instance.OnBackward;
            }
        }
    }
    public MenuTwoDimensionActions @MenuTwoDimension => new MenuTwoDimensionActions(this);

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Menu;
    public struct GameActions
    {
        private @Controls m_Wrapper;
        public GameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_Game_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @Menu.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public GameActions @Game => new GameActions(this);

    // Vehicle Basic
    private readonly InputActionMap m_VehicleBasic;
    private IVehicleBasicActions m_VehicleBasicActionsCallbackInterface;
    private readonly InputAction m_VehicleBasic_ToggleLookMode;
    private readonly InputAction m_VehicleBasic_ToggleInternalConsole;
    private readonly InputAction m_VehicleBasic_ToggleExternalConsole;
    public struct VehicleBasicActions
    {
        private @Controls m_Wrapper;
        public VehicleBasicActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleLookMode => m_Wrapper.m_VehicleBasic_ToggleLookMode;
        public InputAction @ToggleInternalConsole => m_Wrapper.m_VehicleBasic_ToggleInternalConsole;
        public InputAction @ToggleExternalConsole => m_Wrapper.m_VehicleBasic_ToggleExternalConsole;
        public InputActionMap Get() { return m_Wrapper.m_VehicleBasic; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleBasicActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleBasicActions instance)
        {
            if (m_Wrapper.m_VehicleBasicActionsCallbackInterface != null)
            {
                @ToggleLookMode.started -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleLookMode;
                @ToggleLookMode.performed -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleLookMode;
                @ToggleLookMode.canceled -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleLookMode;
                @ToggleInternalConsole.started -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleInternalConsole;
                @ToggleInternalConsole.performed -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleInternalConsole;
                @ToggleInternalConsole.canceled -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleInternalConsole;
                @ToggleExternalConsole.started -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleExternalConsole;
                @ToggleExternalConsole.performed -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleExternalConsole;
                @ToggleExternalConsole.canceled -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleExternalConsole;
            }
            m_Wrapper.m_VehicleBasicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleLookMode.started += instance.OnToggleLookMode;
                @ToggleLookMode.performed += instance.OnToggleLookMode;
                @ToggleLookMode.canceled += instance.OnToggleLookMode;
                @ToggleInternalConsole.started += instance.OnToggleInternalConsole;
                @ToggleInternalConsole.performed += instance.OnToggleInternalConsole;
                @ToggleInternalConsole.canceled += instance.OnToggleInternalConsole;
                @ToggleExternalConsole.started += instance.OnToggleExternalConsole;
                @ToggleExternalConsole.performed += instance.OnToggleExternalConsole;
                @ToggleExternalConsole.canceled += instance.OnToggleExternalConsole;
            }
        }
    }
    public VehicleBasicActions @VehicleBasic => new VehicleBasicActions(this);

    // Vehicle Free Look
    private readonly InputActionMap m_VehicleFreeLook;
    private IVehicleFreeLookActions m_VehicleFreeLookActionsCallbackInterface;
    private readonly InputAction m_VehicleFreeLook_Center;
    private readonly InputAction m_VehicleFreeLook_LookX;
    private readonly InputAction m_VehicleFreeLook_LookY;
    public struct VehicleFreeLookActions
    {
        private @Controls m_Wrapper;
        public VehicleFreeLookActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Center => m_Wrapper.m_VehicleFreeLook_Center;
        public InputAction @LookX => m_Wrapper.m_VehicleFreeLook_LookX;
        public InputAction @LookY => m_Wrapper.m_VehicleFreeLook_LookY;
        public InputActionMap Get() { return m_Wrapper.m_VehicleFreeLook; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleFreeLookActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleFreeLookActions instance)
        {
            if (m_Wrapper.m_VehicleFreeLookActionsCallbackInterface != null)
            {
                @Center.started -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnCenter;
                @Center.performed -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnCenter;
                @Center.canceled -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnCenter;
                @LookX.started -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookX;
                @LookX.performed -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookX;
                @LookX.canceled -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookX;
                @LookY.started -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookY;
                @LookY.performed -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookY;
                @LookY.canceled -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookY;
            }
            m_Wrapper.m_VehicleFreeLookActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Center.started += instance.OnCenter;
                @Center.performed += instance.OnCenter;
                @Center.canceled += instance.OnCenter;
                @LookX.started += instance.OnLookX;
                @LookX.performed += instance.OnLookX;
                @LookX.canceled += instance.OnLookX;
                @LookY.started += instance.OnLookY;
                @LookY.performed += instance.OnLookY;
                @LookY.canceled += instance.OnLookY;
            }
        }
    }
    public VehicleFreeLookActions @VehicleFreeLook => new VehicleFreeLookActions(this);

    // Vehicle Internal Console
    private readonly InputActionMap m_VehicleInternalConsole;
    private IVehicleInternalConsoleActions m_VehicleInternalConsoleActionsCallbackInterface;
    private readonly InputAction m_VehicleInternalConsole_Console1;
    private readonly InputAction m_VehicleInternalConsole_Console2;
    private readonly InputAction m_VehicleInternalConsole_Console3;
    private readonly InputAction m_VehicleInternalConsole_Console4;
    public struct VehicleInternalConsoleActions
    {
        private @Controls m_Wrapper;
        public VehicleInternalConsoleActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Console1 => m_Wrapper.m_VehicleInternalConsole_Console1;
        public InputAction @Console2 => m_Wrapper.m_VehicleInternalConsole_Console2;
        public InputAction @Console3 => m_Wrapper.m_VehicleInternalConsole_Console3;
        public InputAction @Console4 => m_Wrapper.m_VehicleInternalConsole_Console4;
        public InputActionMap Get() { return m_Wrapper.m_VehicleInternalConsole; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleInternalConsoleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleInternalConsoleActions instance)
        {
            if (m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface != null)
            {
                @Console1.started -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole1;
                @Console1.performed -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole1;
                @Console1.canceled -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole1;
                @Console2.started -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole2;
                @Console2.performed -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole2;
                @Console2.canceled -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole2;
                @Console3.started -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole3;
                @Console3.performed -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole3;
                @Console3.canceled -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole3;
                @Console4.started -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole4;
                @Console4.performed -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole4;
                @Console4.canceled -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole4;
            }
            m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Console1.started += instance.OnConsole1;
                @Console1.performed += instance.OnConsole1;
                @Console1.canceled += instance.OnConsole1;
                @Console2.started += instance.OnConsole2;
                @Console2.performed += instance.OnConsole2;
                @Console2.canceled += instance.OnConsole2;
                @Console3.started += instance.OnConsole3;
                @Console3.performed += instance.OnConsole3;
                @Console3.canceled += instance.OnConsole3;
                @Console4.started += instance.OnConsole4;
                @Console4.performed += instance.OnConsole4;
                @Console4.canceled += instance.OnConsole4;
            }
        }
    }
    public VehicleInternalConsoleActions @VehicleInternalConsole => new VehicleInternalConsoleActions(this);

    // Vehicle External Console
    private readonly InputActionMap m_VehicleExternalConsole;
    private IVehicleExternalConsoleActions m_VehicleExternalConsoleActionsCallbackInterface;
    private readonly InputAction m_VehicleExternalConsole_Console1;
    private readonly InputAction m_VehicleExternalConsole_Console2;
    private readonly InputAction m_VehicleExternalConsole_Console3;
    private readonly InputAction m_VehicleExternalConsole_Console4;
    public struct VehicleExternalConsoleActions
    {
        private @Controls m_Wrapper;
        public VehicleExternalConsoleActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Console1 => m_Wrapper.m_VehicleExternalConsole_Console1;
        public InputAction @Console2 => m_Wrapper.m_VehicleExternalConsole_Console2;
        public InputAction @Console3 => m_Wrapper.m_VehicleExternalConsole_Console3;
        public InputAction @Console4 => m_Wrapper.m_VehicleExternalConsole_Console4;
        public InputActionMap Get() { return m_Wrapper.m_VehicleExternalConsole; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleExternalConsoleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleExternalConsoleActions instance)
        {
            if (m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface != null)
            {
                @Console1.started -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole1;
                @Console1.performed -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole1;
                @Console1.canceled -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole1;
                @Console2.started -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole2;
                @Console2.performed -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole2;
                @Console2.canceled -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole2;
                @Console3.started -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole3;
                @Console3.performed -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole3;
                @Console3.canceled -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole3;
                @Console4.started -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole4;
                @Console4.performed -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole4;
                @Console4.canceled -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole4;
            }
            m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Console1.started += instance.OnConsole1;
                @Console1.performed += instance.OnConsole1;
                @Console1.canceled += instance.OnConsole1;
                @Console2.started += instance.OnConsole2;
                @Console2.performed += instance.OnConsole2;
                @Console2.canceled += instance.OnConsole2;
                @Console3.started += instance.OnConsole3;
                @Console3.performed += instance.OnConsole3;
                @Console3.canceled += instance.OnConsole3;
                @Console4.started += instance.OnConsole4;
                @Console4.performed += instance.OnConsole4;
                @Console4.canceled += instance.OnConsole4;
            }
        }
    }
    public VehicleExternalConsoleActions @VehicleExternalConsole => new VehicleExternalConsoleActions(this);

    // Vehicle Attitudes
    private readonly InputActionMap m_VehicleAttitudes;
    private IVehicleAttitudesActions m_VehicleAttitudesActionsCallbackInterface;
    private readonly InputAction m_VehicleAttitudes_PitchUp;
    private readonly InputAction m_VehicleAttitudes_PitchDown;
    private readonly InputAction m_VehicleAttitudes_YawRight;
    private readonly InputAction m_VehicleAttitudes_YawLeft;
    private readonly InputAction m_VehicleAttitudes_RollRight;
    private readonly InputAction m_VehicleAttitudes_RollLeft;
    public struct VehicleAttitudesActions
    {
        private @Controls m_Wrapper;
        public VehicleAttitudesActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PitchUp => m_Wrapper.m_VehicleAttitudes_PitchUp;
        public InputAction @PitchDown => m_Wrapper.m_VehicleAttitudes_PitchDown;
        public InputAction @YawRight => m_Wrapper.m_VehicleAttitudes_YawRight;
        public InputAction @YawLeft => m_Wrapper.m_VehicleAttitudes_YawLeft;
        public InputAction @RollRight => m_Wrapper.m_VehicleAttitudes_RollRight;
        public InputAction @RollLeft => m_Wrapper.m_VehicleAttitudes_RollLeft;
        public InputActionMap Get() { return m_Wrapper.m_VehicleAttitudes; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleAttitudesActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleAttitudesActions instance)
        {
            if (m_Wrapper.m_VehicleAttitudesActionsCallbackInterface != null)
            {
                @PitchUp.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitchUp;
                @PitchUp.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitchUp;
                @PitchUp.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitchUp;
                @PitchDown.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitchDown;
                @PitchDown.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitchDown;
                @PitchDown.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitchDown;
                @YawRight.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYawRight;
                @YawRight.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYawRight;
                @YawRight.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYawRight;
                @YawLeft.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYawLeft;
                @YawLeft.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYawLeft;
                @YawLeft.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYawLeft;
                @RollRight.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRollRight;
                @RollRight.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRollRight;
                @RollRight.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRollRight;
                @RollLeft.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRollLeft;
                @RollLeft.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRollLeft;
                @RollLeft.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRollLeft;
            }
            m_Wrapper.m_VehicleAttitudesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PitchUp.started += instance.OnPitchUp;
                @PitchUp.performed += instance.OnPitchUp;
                @PitchUp.canceled += instance.OnPitchUp;
                @PitchDown.started += instance.OnPitchDown;
                @PitchDown.performed += instance.OnPitchDown;
                @PitchDown.canceled += instance.OnPitchDown;
                @YawRight.started += instance.OnYawRight;
                @YawRight.performed += instance.OnYawRight;
                @YawRight.canceled += instance.OnYawRight;
                @YawLeft.started += instance.OnYawLeft;
                @YawLeft.performed += instance.OnYawLeft;
                @YawLeft.canceled += instance.OnYawLeft;
                @RollRight.started += instance.OnRollRight;
                @RollRight.performed += instance.OnRollRight;
                @RollRight.canceled += instance.OnRollRight;
                @RollLeft.started += instance.OnRollLeft;
                @RollLeft.performed += instance.OnRollLeft;
                @RollLeft.canceled += instance.OnRollLeft;
            }
        }
    }
    public VehicleAttitudesActions @VehicleAttitudes => new VehicleAttitudesActions(this);

    // Vehicle Attitude Dampeners
    private readonly InputActionMap m_VehicleAttitudeDampeners;
    private IVehicleAttitudeDampenersActions m_VehicleAttitudeDampenersActionsCallbackInterface;
    private readonly InputAction m_VehicleAttitudeDampeners_Center;
    public struct VehicleAttitudeDampenersActions
    {
        private @Controls m_Wrapper;
        public VehicleAttitudeDampenersActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Center => m_Wrapper.m_VehicleAttitudeDampeners_Center;
        public InputActionMap Get() { return m_Wrapper.m_VehicleAttitudeDampeners; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleAttitudeDampenersActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleAttitudeDampenersActions instance)
        {
            if (m_Wrapper.m_VehicleAttitudeDampenersActionsCallbackInterface != null)
            {
                @Center.started -= m_Wrapper.m_VehicleAttitudeDampenersActionsCallbackInterface.OnCenter;
                @Center.performed -= m_Wrapper.m_VehicleAttitudeDampenersActionsCallbackInterface.OnCenter;
                @Center.canceled -= m_Wrapper.m_VehicleAttitudeDampenersActionsCallbackInterface.OnCenter;
            }
            m_Wrapper.m_VehicleAttitudeDampenersActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Center.started += instance.OnCenter;
                @Center.performed += instance.OnCenter;
                @Center.canceled += instance.OnCenter;
            }
        }
    }
    public VehicleAttitudeDampenersActions @VehicleAttitudeDampeners => new VehicleAttitudeDampenersActions(this);

    // Vehicle Dampeners
    private readonly InputActionMap m_VehicleDampeners;
    private IVehicleDampenersActions m_VehicleDampenersActionsCallbackInterface;
    private readonly InputAction m_VehicleDampeners_DampenSurge;
    private readonly InputAction m_VehicleDampeners_DampenSway;
    private readonly InputAction m_VehicleDampeners_DampenHeave;
    private readonly InputAction m_VehicleDampeners_DampenAllMotors;
    public struct VehicleDampenersActions
    {
        private @Controls m_Wrapper;
        public VehicleDampenersActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @DampenSurge => m_Wrapper.m_VehicleDampeners_DampenSurge;
        public InputAction @DampenSway => m_Wrapper.m_VehicleDampeners_DampenSway;
        public InputAction @DampenHeave => m_Wrapper.m_VehicleDampeners_DampenHeave;
        public InputAction @DampenAllMotors => m_Wrapper.m_VehicleDampeners_DampenAllMotors;
        public InputActionMap Get() { return m_Wrapper.m_VehicleDampeners; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleDampenersActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleDampenersActions instance)
        {
            if (m_Wrapper.m_VehicleDampenersActionsCallbackInterface != null)
            {
                @DampenSurge.started -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSurge;
                @DampenSurge.performed -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSurge;
                @DampenSurge.canceled -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSurge;
                @DampenSway.started -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSway;
                @DampenSway.performed -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSway;
                @DampenSway.canceled -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSway;
                @DampenHeave.started -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenHeave;
                @DampenHeave.performed -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenHeave;
                @DampenHeave.canceled -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenHeave;
                @DampenAllMotors.started -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenAllMotors;
                @DampenAllMotors.performed -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenAllMotors;
                @DampenAllMotors.canceled -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenAllMotors;
            }
            m_Wrapper.m_VehicleDampenersActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DampenSurge.started += instance.OnDampenSurge;
                @DampenSurge.performed += instance.OnDampenSurge;
                @DampenSurge.canceled += instance.OnDampenSurge;
                @DampenSway.started += instance.OnDampenSway;
                @DampenSway.performed += instance.OnDampenSway;
                @DampenSway.canceled += instance.OnDampenSway;
                @DampenHeave.started += instance.OnDampenHeave;
                @DampenHeave.performed += instance.OnDampenHeave;
                @DampenHeave.canceled += instance.OnDampenHeave;
                @DampenAllMotors.started += instance.OnDampenAllMotors;
                @DampenAllMotors.performed += instance.OnDampenAllMotors;
                @DampenAllMotors.canceled += instance.OnDampenAllMotors;
            }
        }
    }
    public VehicleDampenersActions @VehicleDampeners => new VehicleDampenersActions(this);

    // Vehicle Motors
    private readonly InputActionMap m_VehicleMotors;
    private IVehicleMotorsActions m_VehicleMotorsActionsCallbackInterface;
    private readonly InputAction m_VehicleMotors_SwayRight;
    private readonly InputAction m_VehicleMotors_SwayLeft;
    private readonly InputAction m_VehicleMotors_HeaveUp;
    private readonly InputAction m_VehicleMotors_HeaveDown;
    private readonly InputAction m_VehicleMotors_SurgeUp;
    private readonly InputAction m_VehicleMotors_SurgeDown;
    public struct VehicleMotorsActions
    {
        private @Controls m_Wrapper;
        public VehicleMotorsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwayRight => m_Wrapper.m_VehicleMotors_SwayRight;
        public InputAction @SwayLeft => m_Wrapper.m_VehicleMotors_SwayLeft;
        public InputAction @HeaveUp => m_Wrapper.m_VehicleMotors_HeaveUp;
        public InputAction @HeaveDown => m_Wrapper.m_VehicleMotors_HeaveDown;
        public InputAction @SurgeUp => m_Wrapper.m_VehicleMotors_SurgeUp;
        public InputAction @SurgeDown => m_Wrapper.m_VehicleMotors_SurgeDown;
        public InputActionMap Get() { return m_Wrapper.m_VehicleMotors; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleMotorsActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleMotorsActions instance)
        {
            if (m_Wrapper.m_VehicleMotorsActionsCallbackInterface != null)
            {
                @SwayRight.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSwayRight;
                @SwayRight.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSwayRight;
                @SwayRight.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSwayRight;
                @SwayLeft.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSwayLeft;
                @SwayLeft.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSwayLeft;
                @SwayLeft.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSwayLeft;
                @HeaveUp.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveUp;
                @HeaveUp.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveUp;
                @HeaveUp.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveUp;
                @HeaveDown.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveDown;
                @HeaveDown.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveDown;
                @HeaveDown.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveDown;
                @SurgeUp.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurgeUp;
                @SurgeUp.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurgeUp;
                @SurgeUp.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurgeUp;
                @SurgeDown.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurgeDown;
                @SurgeDown.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurgeDown;
                @SurgeDown.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurgeDown;
            }
            m_Wrapper.m_VehicleMotorsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwayRight.started += instance.OnSwayRight;
                @SwayRight.performed += instance.OnSwayRight;
                @SwayRight.canceled += instance.OnSwayRight;
                @SwayLeft.started += instance.OnSwayLeft;
                @SwayLeft.performed += instance.OnSwayLeft;
                @SwayLeft.canceled += instance.OnSwayLeft;
                @HeaveUp.started += instance.OnHeaveUp;
                @HeaveUp.performed += instance.OnHeaveUp;
                @HeaveUp.canceled += instance.OnHeaveUp;
                @HeaveDown.started += instance.OnHeaveDown;
                @HeaveDown.performed += instance.OnHeaveDown;
                @HeaveDown.canceled += instance.OnHeaveDown;
                @SurgeUp.started += instance.OnSurgeUp;
                @SurgeUp.performed += instance.OnSurgeUp;
                @SurgeUp.canceled += instance.OnSurgeUp;
                @SurgeDown.started += instance.OnSurgeDown;
                @SurgeDown.performed += instance.OnSurgeDown;
                @SurgeDown.canceled += instance.OnSurgeDown;
            }
        }
    }
    public VehicleMotorsActions @VehicleMotors => new VehicleMotorsActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IAttractActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface ILoadingActions
    {
        void OnNextHint(InputAction.CallbackContext context);
        void OnPreviousHint(InputAction.CallbackContext context);
        void OnContinue(InputAction.CallbackContext context);
    }
    public interface IMenuOneDimensionActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnBackward(InputAction.CallbackContext context);
    }
    public interface IMenuTwoDimensionActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnBackward(InputAction.CallbackContext context);
    }
    public interface IGameActions
    {
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IVehicleBasicActions
    {
        void OnToggleLookMode(InputAction.CallbackContext context);
        void OnToggleInternalConsole(InputAction.CallbackContext context);
        void OnToggleExternalConsole(InputAction.CallbackContext context);
    }
    public interface IVehicleFreeLookActions
    {
        void OnCenter(InputAction.CallbackContext context);
        void OnLookX(InputAction.CallbackContext context);
        void OnLookY(InputAction.CallbackContext context);
    }
    public interface IVehicleInternalConsoleActions
    {
        void OnConsole1(InputAction.CallbackContext context);
        void OnConsole2(InputAction.CallbackContext context);
        void OnConsole3(InputAction.CallbackContext context);
        void OnConsole4(InputAction.CallbackContext context);
    }
    public interface IVehicleExternalConsoleActions
    {
        void OnConsole1(InputAction.CallbackContext context);
        void OnConsole2(InputAction.CallbackContext context);
        void OnConsole3(InputAction.CallbackContext context);
        void OnConsole4(InputAction.CallbackContext context);
    }
    public interface IVehicleAttitudesActions
    {
        void OnPitchUp(InputAction.CallbackContext context);
        void OnPitchDown(InputAction.CallbackContext context);
        void OnYawRight(InputAction.CallbackContext context);
        void OnYawLeft(InputAction.CallbackContext context);
        void OnRollRight(InputAction.CallbackContext context);
        void OnRollLeft(InputAction.CallbackContext context);
    }
    public interface IVehicleAttitudeDampenersActions
    {
        void OnCenter(InputAction.CallbackContext context);
    }
    public interface IVehicleDampenersActions
    {
        void OnDampenSurge(InputAction.CallbackContext context);
        void OnDampenSway(InputAction.CallbackContext context);
        void OnDampenHeave(InputAction.CallbackContext context);
        void OnDampenAllMotors(InputAction.CallbackContext context);
    }
    public interface IVehicleMotorsActions
    {
        void OnSwayRight(InputAction.CallbackContext context);
        void OnSwayLeft(InputAction.CallbackContext context);
        void OnHeaveUp(InputAction.CallbackContext context);
        void OnHeaveDown(InputAction.CallbackContext context);
        void OnSurgeUp(InputAction.CallbackContext context);
        void OnSurgeDown(InputAction.CallbackContext context);
    }
}
