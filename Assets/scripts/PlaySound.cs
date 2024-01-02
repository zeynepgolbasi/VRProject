using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

//public class PlaySound : MonoBehaviour
//{
//    public AudioSource audioSource;
//    private bool isPaused = false;

//    public void ToggleAudio()
//    {
//        if (audioSource != null)
//        {
//            // Ses þu anda çalýyorsa ve durdurulmadýysa, durdur
//            if (audioSource.isPlaying && !isPaused)
//            {
//                audioSource.Pause();
//                isPaused = true;
//            }
//            // Ses durdurulduysa, kaldýðý yerden devam et
//            else if (!audioSource.isPlaying && isPaused)
//            {
//                audioSource.UnPause();
//                isPaused = false;
//            }
//            // Ses çalmýyorsa ve durdurulmadýysa, çalmaya baþlat
//            else if (!audioSource.isPlaying && !isPaused)
//            {
//                audioSource.Play();
//            }
//        }
//    }
//}
using UnityEngine;
using System.Collections.Generic;

public class PlaySound : MonoBehaviour
{
    // Tüm ses kaynaklarýný tutacak bir liste
    private List<AudioSource> audioSources = new List<AudioSource>();
    private bool isPaused = false;

    // Yeni bir ses kaynaðý eklemek için kullanýlacak fonksiyon
    public void AddAudioSource(AudioSource source)
    {
        if (!audioSources.Contains(source))
        {
            audioSources.Add(source);
        }
    }

    // Belirli bir ses kaynaðýný çalmak için kullanýlacak fonksiyon
    public void PlayAudio(AudioSource newSource)
    {
        // Tüm ses kaynaklarýný durdur
        foreach (AudioSource source in audioSources)
        {
            if (source != newSource && source.isPlaying)
            {
                source.Pause();
            }
            
        }

        // Yeni ses kaynaðýný çal
        if (!newSource.isPlaying && !isPaused)
        {
            newSource.Play();
        }
        else if (newSource.isPlaying && !isPaused)
        {
            newSource.Pause();
            isPaused = true;
        }
        else if (!newSource.isPlaying && isPaused)
        {
            newSource.UnPause();
            isPaused = false;
        }
    }
}

