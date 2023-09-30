using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.AddressableAssets;

namespace UIManagementSystem.Scripts
{

    public class UIAddressables : MonoBehaviour, IUIAddressables
    {
        private UIManager uiManager;
        [SerializeField] private List<UIConfig> uIConfigs;



        void Start()
        {
            uiManager = GetComponent<UIManager>();
        }


        public async void LoadAddressableScreen(string screenID)
        {
            var screenConfig = uIConfigs.FirstOrDefault(screenConfig => screenConfig.screenID == screenID);
            if (screenConfig == null) return;

            var screenObject = await Addressables.InstantiateAsync(screenConfig.addressablePath).Task;
            uiManager.screen = screenObject.GetComponent<IUIScreen>();

            if (uiManager.screen == null)
            {
                return;
            }

            uiManager.instantiatedScreens.Add(screenID, uiManager.screen);
        }
    }
}