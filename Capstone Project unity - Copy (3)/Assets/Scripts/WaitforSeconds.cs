using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitforSeconds : MonoBehaviour
{

    public float waitTime;
    public GameObject waitObject;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(waitTime);
        waitObject.SetActive(true);
    }

}
