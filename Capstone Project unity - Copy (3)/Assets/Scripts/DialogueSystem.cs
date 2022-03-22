using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class DialogueSystem : MonoBehaviour
{
    public List<string> dialogueText;
    public List<string> buttonTexts;
    public TextMeshProUGUI instructiontext, buttonText;
    public UnityEvent EndText;
    public int currentIndex;
    public GameObject ButtonImage;

    private void Start()
    {
        instructiontext.text = dialogueText[0];
        buttonText.text = buttonTexts[0];
        currentIndex = 0;
    }

    public void NextLine()
    {
        currentIndex++;
        if (currentIndex == 1)
        {
            instructiontext.text = dialogueText[1];
            buttonText.text = buttonTexts[1];
            ButtonImage.SetActive(false);
        }
        else
        {
            EndText.Invoke();
        }
    }

}
