using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointEvent : MonoBehaviour
{
    public AudioClip hoverClip;
    public AudioClip clickClip;

    public AudioSource source;
    public void HoverMouseButtonSFX()
    {
        source.PlayOneShot(hoverClip);
    }
    public void MouseButtonClickSFX()
    {
        source.PlayOneShot(clickClip);
    }
}
