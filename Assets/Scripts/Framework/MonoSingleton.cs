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
            var objectsOfType = FindObjectsOfType<T>();
            if (objectsOfType.Length>=2)
            {
                LogUtil.LogWarning("You have more than one instance of type "+typeof(T)+"!");
            }
            _instance = (T) this;
        }

    }
}