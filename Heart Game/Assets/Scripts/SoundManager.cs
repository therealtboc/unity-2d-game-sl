using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    public AudioClip heartCollectSound;

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
}
