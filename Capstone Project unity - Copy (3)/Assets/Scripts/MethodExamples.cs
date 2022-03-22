using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MethodExamples : MonoBehaviour
{
    public AudioSource audio;
    public TextMeshProUGUI TMP;
    public Animator anim;
    private bool paused;

    public void Start()
    {
        //audio.Stop();
        paused = false;
        TMP.text = "During this experience you may encounter things that make you feel or trigger uncomfortable emotions. We have provided a panic button that will immediately remove you from the experience. We are not responsible for any discomfort, or injury that may occur as a result of this experience. ";
    }

    public void SetText(string newText)
    {
        TMP.text = newText;
    }

    public void ButtonPress()
    {
        if (paused)
        {
            Unpause();
        }
        else
        {
            Pause();
        }
    }

    public void Pause()
    {
        paused = true;
        anim.speed = 0;
        audio.Pause();
    }

    public void Unpause()
    {
        paused = false;
        anim.speed = 1;
        audio.Play();
    }
}
