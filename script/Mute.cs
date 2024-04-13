using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    [SerializeField] AudioSource audioSource; 
    public void OFFMute()
    {
        audioSource.Stop();
    }
}