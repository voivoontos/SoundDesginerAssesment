using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource SpellSound;

    private void OnTriggerEnter(Collider other)
    {
        SpellSound.Play();
    }
}
