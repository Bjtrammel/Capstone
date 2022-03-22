using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMenu : MonoBehaviour
{

    public void menuLoad()
    {
        SceneManager.LoadScene(0);
    }
}