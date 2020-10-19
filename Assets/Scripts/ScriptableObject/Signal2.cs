using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Signal2 : ScriptableObject
{
    public List<Signal2Listener> listeners = new List<Signal2Listener>();

    public void Raise()
    {
        for(int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnSignalRaised();
        }
    }

    public void RegisterListener(Signal2Listener listener)
    {
        listeners.Add(listener);
    }

    public void DeRegisterListener(Signal2Listener listener)
    {
        listeners.Remove(listener);
    }
}
