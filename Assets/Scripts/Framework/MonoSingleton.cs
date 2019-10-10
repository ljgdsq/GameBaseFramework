using UnityEngine;

namespace Framework
{
    public class MonoSingleton<T> :MonoBehaviour where T:MonoSingleton<T>
    {
        private static T _instance;

        public static T GetInstance()
        {
            return _instance;
        }
        
        private void Awake()
        {
            _instance = (T) this;
        }

    }
}