using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource myFx;
    public AudioClip ClipFX;

    public void ClickSound()
    {
        myFx.PlayOneShot(ClipFX);
    }
}
