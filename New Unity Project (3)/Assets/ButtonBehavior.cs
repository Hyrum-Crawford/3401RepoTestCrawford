using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{

    public AudioSource buttonAudioSource;


    public void OnButtonClicked()
    {
        Debug.Log("Button Clicked!");

        if (buttonAudioSource.isPlaying)
        {
            buttonAudioSource.Stop();
        }
        else
        {
            buttonAudioSource.Play();
        }
    }
}
