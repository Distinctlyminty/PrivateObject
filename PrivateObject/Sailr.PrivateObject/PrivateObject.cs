using System.Reflection;

namespace Sailr.PrivateObject;

public class PrivateObject
{
    private readonly object _o;
    public PrivateObject(object o)
    {
        this._o = o;
    }
    public object? Invoke(string methodName, params object[] args)
    {
        var methodInfo = _o.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
        if (methodInfo == null)
        {
            throw new Exception($"Method'{methodName}' not found is class '{_o.GetType()}'");
        }

        return methodInfo.Invoke(_o, args);
    }
}