using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxPlaying : MonoBehaviour
{
    public AudioSource Bubble;
    public AudioSource Button;
    public AudioSource Escape;

    public void PlayBubble(){
        Bubble.Play();
    }
     public void PlayButton(){
        Button.Play();
    }
     public void PlayEscape(){
        Escape.Play();
    }
}
