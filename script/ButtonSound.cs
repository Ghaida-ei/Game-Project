using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonSound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

     public void OnSound()
    {
        audioSource.Play();
    }


}
