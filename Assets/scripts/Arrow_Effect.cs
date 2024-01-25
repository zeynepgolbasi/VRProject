using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow_Effect : MonoBehaviour
{
    public Image targetImage;
    public float blinkInterval = 1.0f; // G�r�n�p kaybolma aral��� (saniye)

    private bool isVisible = true;

    void Start()
    {
       //blink fonk �a��r.
       //0.0f fonksiyonu hemen �a��r
       
        InvokeRepeating("Blink", 0.0f, blinkInterval);
    }

    void Blink()
    {
        // Image'nin g�r�n�rl���n� tersine �evir
        targetImage.enabled = !targetImage.enabled;

        // G�r�n�rl�k durumunu g�ncelle
        isVisible = targetImage.enabled;
    }
}

