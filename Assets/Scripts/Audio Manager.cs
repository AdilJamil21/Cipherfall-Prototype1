using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
   public static AudioManager instance;
   public AudioSource audioSource;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else 
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        audioSource = GetComponent<AudioSource>();

    }
    public void StopMusic()
    {
        audioSource.Stop();
    }

    public void PlayMusic()
    {
        audioSource.Play();
    }
}
