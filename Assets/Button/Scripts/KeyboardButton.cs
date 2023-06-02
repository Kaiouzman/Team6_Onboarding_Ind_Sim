using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyboardButton : MonoBehaviour
{
    Keyboard Keyboard;
    TextMeshProUGUI buttonText;

    void Start()
    {
        Keyboard = GetComponentInParent<Keyboard>();
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        if (buttonText.text.Length == 1)
        {
            NameToButtonText();
            GetComponentInChildren<ButtonVR>().onRelease.AddListener(delegate { Keyboard.InsertChar(buttonText.text); });
        }
    }

    public void NameToButtonText()
    {
        buttonText.text = gameObject.name;
    }

}
