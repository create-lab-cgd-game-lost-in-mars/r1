﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject panel;

    public void StartDialogue()
    {
        panel.SetActive(true);
        StartCoroutine(TextType());
    }

    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            
            continueButton.SetActive(true);
        }
    }
    IEnumerator TextType()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(TextType());
        } else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            panel.SetActive(false);
        }
    }
}
