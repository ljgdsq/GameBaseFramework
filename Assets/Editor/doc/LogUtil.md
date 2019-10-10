[代码](../../../Assets/Scripts/Framework/LogUtil.cs)

```c#
public class LogUtil
    {
        [Conditional("DEBUG")]
        public static void  Log(String msg)
        {
            UnityEngine.Debug.Log(msg);
        } 
        
        [Conditional("DEBUG")]
        public static void  LogWarning(String msg)
        {
            UnityEngine.Debug.LogWarning(msg);
        } 
        
        [Conditional("DEBUG")]
        public static void  LogError(String msg)
        {
            UnityEngine.Debug.LogError(msg);
        } 
        
    }
 ```
 
 1. Conditional 属性经常与 DEBUG 标识符一起使用以启用调试版本的跟踪和日志记录功能
 2. 使用 Conditional 是封闭 #if 和 #endif 内部方法的替代方法，它更整洁、更别致、减少了出错的机会
 3. Unity 自带log 关闭后仍然会产生方法调用，虽然方法什么也没有做，但是会产生额外开销
