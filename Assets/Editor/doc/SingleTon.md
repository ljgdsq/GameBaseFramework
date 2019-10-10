[代码](../../../Assets/Scripts/Framework/MonoSingleton.cs)

```c#

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
    
```

 * 单例的一种实现。单例有很多实现方法，找到一种方便快捷适合自己的就好了.