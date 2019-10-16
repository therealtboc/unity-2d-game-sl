using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;
    public AudioSource audioSource2;

    public AudioClip heartCollectSound;
    public AudioClip allHeartCollectSound;
    public AudioClip deathSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject); ;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayHeartCollectSound()
    {
        audioSource.clip = heartCollectSound;
        audioSource.Play();
    }

    public void PlayAllHeartCollectSound()
    {
        audioSource2.clip = allHeartCollectSound;
        audioSource2.Play();
    }

    public void PlayDeathSound()
    {
        audioSource.clip = deathSound;
        audioSource.Play();
    }
}
