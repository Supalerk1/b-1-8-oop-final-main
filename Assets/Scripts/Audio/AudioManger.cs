using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManger : MonoBehaviour
{
    [Header("------------------Audio Source-------------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------------------Audio Clip-------------------")]
    public AudioClip Background;
    public AudioClip Shoot;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
    }


    public void PlaySFx(AudioClip clip) 
    {
        SFXSource.PlayOneShot(clip);
    }
}
