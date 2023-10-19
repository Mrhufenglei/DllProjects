using System;
using UnityEngine;
using UnityEngine.Internal;
using Object = UnityEngine.Object;

public class HLog
{
    private static bool m_enbleLog = true;

    private const string m_tagInfo = "<color=yellow>[HotFix]</color>";
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
            Debug.Log(m_tagInfo + message);
        }
    }

    [ExcludeFromDocs]
    public static void Log(object message, Object context)
    {
        if (EnableLog)
        {
            Debug.Log(m_tagInfo + message, context);
        }
    }

    [ExcludeFromDocs]
    public static void LogAssertion(object message)
    {
        if (EnableLog)
        {
            Debug.LogAssertion(m_tagInfo + message);
        }
    }

    [ExcludeFromDocs]
    public static void LogAssertionFormat(string format, params object[] args)
    {
        if (EnableLog)
        {
            Debug.LogAssertionFormat(m_tagInfo + format, args);
        }
    }

    public static void LogError(object message)
    {
        Debug.LogError(message);
    }

    public static void LogError(object message, Object context)
    {
        Debug.LogError(m_tagInfo + message, context);
    }

    public static void LogErrorFormat(string format, params object[] args)
    {
        Debug.LogErrorFormat(m_tagInfo + format, args);
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
            Debug.LogFormat(m_tagInfo + format, args);
        }
    }

    [ExcludeFromDocs]
    public static void LogWarning(object message)
    {
        if (EnableLog)
        {
            Debug.LogWarning(m_tagInfo + message);
        }
    }

    [ExcludeFromDocs]
    public static void LogWarning(object message, Object context)
    {
        if (EnableLog)
        {
            Debug.LogWarning(m_tagInfo + message, context);
        }
    }

    [ExcludeFromDocs]
    public static void LogWarningFormat(string format, params object[] args)
    {
        if (EnableLog)
        {
            Debug.LogWarningFormat(m_tagInfo + format, args);
        }
    }
}