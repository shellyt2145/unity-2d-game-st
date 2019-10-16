using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    public AudioClip coinCollectSound;

<<<<<<< Updated upstream
=======
    public AudioClip hazardHitSound;
    public AudioClip youWinSound;


>>>>>>> Stashed changes
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayCoinCollectSound()
    {
        audioSource.clip = coinCollectSound;
        audioSource.Play();
    }

<<<<<<< Updated upstream

=======
    public void PlayhazardHitSound()
    {
        audioSource.clip = hazardHitSound;
        audioSource.Play();
    }

    public void PlayyouWinSound()
    {
        audioSource.clip = youWinSound;
        audioSource.Play();
    }
>>>>>>> Stashed changes
}
