using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static bool     m_ShutDown = false;
    private static object   m_Lock = new object();
    private static T        m_instance;

    public static T instance
    {
        get
        {
            if (m_ShutDown)
            {
                Debug.LogWarning("[Singleton] Instance '" + typeof(T) + "' already destroyed. Returning null.");
                return null;
            }
            lock (m_Lock)
            {
                if(m_instance == null)
                {
                    m_instance = (T)FindObjectOfType(typeof(T));

                    if(m_instance == null)
                    {
                        var singletonObject = new GameObject();
                        m_instance = singletonObject.AddComponent<T>();
                        singletonObject.name = typeof(T).ToString() + " (Singleton)";

                        DontDestroyOnLoad(singletonObject);
                    }
                }

                return m_instance;
            }
        }
    }

    private void OnApplicationQuit()
    {
        m_ShutDown = true;
    }

    private void OnDestroy()
    {
        m_ShutDown = true;
    }
}
