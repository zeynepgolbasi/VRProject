using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
   public ParticleSystem particleSystemToStart; // Unity Editor üzerinde atanacak

    private bool particleSystemStarted = false;

   public void Start()
    {
        // İstediğiniz bir yerde bu metodu çağırabilirsiniz
        PlayParticleSystem();
    }

    void PlayParticleSystem()
    {
        // Butona tıklandığında çalışacak kod
        if (!particleSystemStarted)
        {
            // Particle System'i başlat
            if (particleSystemToStart != null)
            {
                particleSystemToStart.Play();
                particleSystemStarted = true;

                // Invoke ile belirli bir süre sonra StopParticleSystems metodu çağrılır
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
