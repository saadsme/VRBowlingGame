using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSound : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (!GetComponent<AudioSource>().isPlaying && collision.relativeVelocity.magnitude >= 2)
        {
            GetComponent<AudioSource>().volume = collision.relativeVelocity.magnitude / 20;
            GetComponent<AudioSource>().Play();
        }
    }
}