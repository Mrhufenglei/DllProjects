using System;
using UnityEngine;
using UnityEngine.Internal;
using Object = UnityEngine.Object;

public class ULog
{
    private static bool m_enbleLog = true;

    public static bool EnableLog
    {
        get { return m_enbleLog; }
        set { m_enbleLog = value; }
    }

    [ExcludeFromDocs]
    public static void DrawLine(Vector3 start, Vector3 end)
    {
        if (EnableLog)
        {
            Debug.DrawLine(start, end);
        }
    }

    [ExcludeFromDocs]
    public static void DrawLine(Vector3 start, Vector3 end, Color color)
    {
        if (EnableLog)
        {
            Debug.DrawLine(start, end, color);
        }
    }

    [ExcludeFromDocs]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
    {
        if (EnableLog)
        {
            Debug.DrawLine(start, end, color, duration);
        }
    }

    [ExcludeFromDocs]
    public static void Log(object message)
    {
        if (EnableLog)
        {
            Debug.Log(message);
        }
    }

    [ExcludeFromDocs]
    public static void Log(object message, Object context)
    {
        if (EnableLog)
        {
            Debug.Log(message, context);
        }
    }

    [ExcludeFromDocs]
    public static void LogAssertion(object message)
    {
        if (EnableLog)
        {
            Debug.LogAssertion(message);
        }
    }

    [ExcludeFromDocs]
    public static void LogAssertionFormat(string format, params object[] args)
    {
        if (EnableLog)
        {
            Debug.LogAssertionFormat(format, args);
        }
    }

    public static void LogError(object message)
    {
        Debug.LogError(message);
    }

    public static void LogError(object message, Object context)
    {
        Debug.LogError(message, context);
    }

    public static void LogErrorFormat(string format, params object[] args)
    {
        Debug.LogErrorFormat(format, args);
    }

    [ExcludeFromDocs]
    public static void LogException(Exception exception)
    {
        if (EnableLog)
        {
            Debug.LogError(exception);
        }
    }

    [ExcludeFromDocs]
    public static void LogFormat(string format, params object[] args)
    {
        if (EnableLog)
        {
            Debug.LogFormat(format, args);
        }
    }

    [ExcludeFromDocs]
    public static void LogWarning(object message)
    {
        if (EnableLog)
        {
            Debug.LogWarning(message);
        }
    }

    [ExcludeFromDocs]
    public static void LogWarning(object message, Object context)
    {
        if (EnableLog)
        {
            Debug.LogWarning(message, context);
        }
    }

    [ExcludeFromDocs]
    public static void LogWarningFormat(string format, params object[] args)
    {
        if (EnableLog)
        {
            Debug.LogWarningFormat(format, args);
        }
    }
}