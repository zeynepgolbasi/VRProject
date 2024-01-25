using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class PlaySound : MonoBehaviour
{
    // T�m ses kaynaklar�n� listede tut
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

