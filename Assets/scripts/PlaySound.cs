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
//            // Ses �u anda �al�yorsa ve durdurulmad�ysa, durdur
//            if (audioSource.isPlaying && !isPaused)
//            {
//                audioSource.Pause();
//                isPaused = true;
//            }
//            // Ses durdurulduysa, kald��� yerden devam et
//            else if (!audioSource.isPlaying && isPaused)
//            {
//                audioSource.UnPause();
//                isPaused = false;
//            }
//            // Ses �alm�yorsa ve durdurulmad�ysa, �almaya ba�lat
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
    // T�m ses kaynaklar�n� tutacak bir liste
    private List<AudioSource> audioSources = new List<AudioSource>();
    private bool isPaused = false;

    // Yeni bir ses kayna�� eklemek i�in kullan�lacak fonksiyon
    public void AddAudioSource(AudioSource source)
    {
        if (!audioSources.Contains(source))
        {
            audioSources.Add(source);
        }
    }

    // Belirli bir ses kayna��n� �almak i�in kullan�lacak fonksiyon
    public void PlayAudio(AudioSource newSource)
    {
        // T�m ses kaynaklar�n� durdur
        foreach (AudioSource source in audioSources)
        {
            if (source != newSource && source.isPlaying)
            {
                source.Pause();
            }
            
        }

        // Yeni ses kayna��n� �al
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

