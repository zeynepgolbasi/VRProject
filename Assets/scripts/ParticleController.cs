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
        // Butona týklandýðýnda çalýþacak kod
        if (!particleSystemStarted)
        {
            // Particle System'i baþlat
            if (particleSystemToStart != null)
            {
                particleSystemToStart.Play();
                particleSystemStarted = true;

                // Invoke ile belirli bir süre sonra StopParticleSystems metodunun çaðýrdýk
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
