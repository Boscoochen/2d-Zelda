using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signal2Listener : MonoBehaviour
{
    public Signal2 signal2;
    public UnityEvent signalEvent;
    public void OnSignalRaised()
    {
        signalEvent.Invoke();
    }

    private void OnEnable()
    {
        signal2.RegisterListener(this);
    }

    private void OnDisable()
    {
        signal2.DeRegisterListener(this);
    }
}
