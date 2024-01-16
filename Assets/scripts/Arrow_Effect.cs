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
        // Ba�lang��ta InvokeRepeating fonksiyonunu kullanarak Blink fonksiyonunu �a��r�n.
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


    //public Image targetImage;
    //public float fadeSpeed = 2.0f; // G�r�n�rl�k azaltma h�z�

    //private Color startColor; // Ba�lang��taki renk de�eri

    //private void Start()
    //{
    //    // Ba�lang��ta ba�lang�� rengini kaydet
    //    startColor = targetImage.color;

    //    // Ba�lang��ta InvokeRepeating fonksiyonunu kullanarak FadeInOut fonksiyonunu �a��r�n.
    //    InvokeRepeating("FadeInOut", 0.0f, fadeSpeed);
    //}

    //private void FadeInOut()
    //{
    //    // Image'nin alpha de�erini azalt
    //    Color currentColor = targetImage.color;
    //    float newAlpha = Mathf.Clamp01(currentColor.a - 0.1f); // 0.01f, her �a�r�da azalt�lacak miktar
    //    targetImage.color = new Color(currentColor.r, currentColor.g, currentColor.b, newAlpha);

    //    // E�er alpha de�eri s�f�ra ula�t�ysa, ba�a d�n
    //    if (newAlpha <= 0.0f)
    //    {
    //        targetImage.color = startColor; // Alpha'y� ba�lang�� de�erine getir
    //    }
    //}
//}
