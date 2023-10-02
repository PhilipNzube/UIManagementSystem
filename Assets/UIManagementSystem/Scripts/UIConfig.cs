using UnityEngine;

namespace UIManagementSystem.Scripts
{

    [CreateAssetMenu(menuName = "UIConfig")]
    public class UIConfig : ScriptableObject
    {
        public string screenID;
        public string addressablePath;
    }
}