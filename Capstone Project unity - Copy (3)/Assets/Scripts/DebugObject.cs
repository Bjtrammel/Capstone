using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Debug")]
public class DebugObject : ScriptableObject
{
    public void Call(string value)
    {
        Debug.Log(value);
    }
}
