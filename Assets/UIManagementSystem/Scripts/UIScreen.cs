using UnityEngine;
using Doozy.Runtime.UIManager.Containers;

namespace UIManagementSystem.Scripts
{

    public class UIScreen : MonoBehaviour, IUIScreen
    {
        public string ScreenID;

        private UIView view;

        void Awake()
        {
            view = GetComponent<UIView>();
        }

        public void ShowScreen()
        {
            if (view != null)
            {
                view.Show();
            }
        }

        public void HideScreen()
        {
            if (view != null)
            {
                view.Hide();
            }
        }
    }
}