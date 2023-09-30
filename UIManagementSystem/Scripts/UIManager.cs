using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace UIManagementSystem.Scripts
{

    public class UIManager : MonoBehaviour, IUIManager
    {
        public Dictionary<string, IUIScreen> instantiatedScreens = new Dictionary<string, IUIScreen>();
        private IUIAddressables iUIAddressables;
        public IUIScreen screen;

        void Start()
        {
            iUIAddressables = GetComponent<IUIAddressables>();
        }


        public void ShowScreen(string screenID)
        {
            if (!instantiatedScreens.ContainsKey(screenID))
            {
                iUIAddressables.LoadAddressableScreen(screenID);
            }
            else
            {
                screen = instantiatedScreens[screenID];
            }

            screen.ShowScreen();
        }


        public void HideScreen(string screenID)
        {
            if (instantiatedScreens.ContainsKey(screenID))
            {
                instantiatedScreens[screenID].HideScreen();
            }
        }
    }
}