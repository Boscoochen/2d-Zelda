﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class FloatValue2 : ScriptableObject, ISerializationCallbackReceiver
{
    public float initialValue;


    [HideInInspector]
    public float RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = initialValue;
    }


    public void OnBeforeSerialize() { }
}
