using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
   public ParticleSystem particleSystemToStart; 

    private bool particleSystemStarted = false;

   public void Start()
    {
        PlayParticleSystem();
    }

    void PlayParticleSystem()
    {
        // Butona t�kland���nda �al��acak kod
        if (!particleSystemStarted)
        {
            // Particle System'i ba�lat
            if (particleSystemToStart != null)
            {
                particleSystemToStart.Play();
                particleSystemStarted = true;

                // Invoke ile belirli bir s�re sonra StopParticleSystems metodunun �a��rd�k
                Invoke("StopParticleSystems", particleSystemToStart.main.duration);
            }
        }
    }

    void StopParticleSystems()
    {
        // Particle System'i durdur
        if (particleSystemToStart != null)
        {
            particleSystemToStart.Stop();
            particleSystemStarted = false;
        }
    }
}
