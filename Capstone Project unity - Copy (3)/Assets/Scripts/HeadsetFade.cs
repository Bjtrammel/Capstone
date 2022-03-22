using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HeadsetFade : MonoBehaviour
{
    public Image BlackImage;
    public Color FadeColor = Color.black;
    public float FadeOutTime, FadeInTime, InBetweenTime;
    public UnityEvent FadeInEvent, FadeOutEvent;
    private bool running;
    public bool FadeOnStart;

    private IEnumerator Start()
    {
        running = false;
        if (FadeOnStart)
        {
            yield return new WaitForSeconds(4);
            FadeIn();
        }
    }

    public void FadeOut()
    {
        if (!running) {
            running = true;
            StartCoroutine(Fade(Color.clear, FadeColor, FadeOutTime, FadeOutEvent));
        }
    }

    public void FadeIn()
    {
        if (!running)
        {
            running = true;
            StartCoroutine(Fade(FadeColor, Color.clear, FadeInTime, FadeInEvent));
        }
    }

    public IEnumerator Fade(Color origColor, Color newColor, float time, UnityEvent ev)
    {
        Debug.Log("Start Fade");
        BlackImage.color = origColor;
        float currentTime = 0;
        while (currentTime < time)
        {
            currentTime += Time.deltaTime;
            BlackImage.color = Color.Lerp(origColor, newColor, ConvertRange(0, time, 0, 1, currentTime));
            yield return new WaitForFixedUpdate();
        }
        ev.Invoke();
        running = false;
    }

    public static float ConvertRange(float origMinRange, float origMaxRange, float newMinRange, float newMaxRange, float value)
    {
        return (value - origMinRange) * (newMaxRange - newMinRange) / (origMaxRange - origMinRange) + newMinRange;
    }
}
