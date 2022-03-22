using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSwitch : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Killer") == true)
        {
            Debug.Log("Switch");
            
        }
    }
}
