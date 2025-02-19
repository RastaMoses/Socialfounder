﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] AudioClip deathSFX;
    [SerializeField] List<AudioClip> jumpSFX;
    [SerializeField] List<AudioClip> landSFX;

    [SerializeField] [Range(0, 1)] float landVolume;
    [SerializeField] [Range(0, 1)] float jumpVolume;
    AudioSource audioSource;

    public void PlayJumpSFX()
    {
        audioSource = GetComponent<AudioSource>();
        int randomSFX = Random.Range(0, jumpSFX.Count - 1);
        var clip = jumpSFX[randomSFX];
        audioSource.PlayOneShot(clip, jumpVolume);
    }

    public void PlayDeathSFX()
    {
        
        AudioSource.PlayClipAtPoint(deathSFX, gameObject.transform.position);
    }
    public void PlayLandSFX()
    {
        audioSource = GetComponent<AudioSource>();
        int randomSFX = Random.Range(0, landSFX.Count - 1);
        var clip = landSFX[randomSFX];

        audioSource.clip=clip;
        audioSource.volume = landVolume;
        audioSource.Play();
    }
}
