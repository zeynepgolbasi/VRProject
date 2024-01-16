using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow_Effect : MonoBehaviour
{
    public Image targetImage;
    public float blinkInterval = 1.0f; // Görünüp kaybolma aralýðý (saniye)

    private bool isVisible = true;

    void Start()
    {
        // Baþlangýçta InvokeRepeating fonksiyonunu kullanarak Blink fonksiyonunu çaðýrýn.
        InvokeRepeating("Blink", 0.0f, blinkInterval);
    }

    void Blink()
    {
        // Image'nin görünürlüðünü tersine çevir
        targetImage.enabled = !targetImage.enabled;

        // Görünürlük durumunu güncelle
        isVisible = targetImage.enabled;
    }
}


    //public Image targetImage;
    //public float fadeSpeed = 2.0f; // Görünürlük azaltma hýzý

    //private Color startColor; // Baþlangýçtaki renk deðeri

    //private void Start()
    //{
    //    // Baþlangýçta baþlangýç rengini kaydet
    //    startColor = targetImage.color;

    //    // Baþlangýçta InvokeRepeating fonksiyonunu kullanarak FadeInOut fonksiyonunu çaðýrýn.
    //    InvokeRepeating("FadeInOut", 0.0f, fadeSpeed);
    //}

    //private void FadeInOut()
    //{
    //    // Image'nin alpha deðerini azalt
    //    Color currentColor = targetImage.color;
    //    float newAlpha = Mathf.Clamp01(currentColor.a - 0.1f); // 0.01f, her çaðrýda azaltýlacak miktar
    //    targetImage.color = new Color(currentColor.r, currentColor.g, currentColor.b, newAlpha);

    //    // Eðer alpha deðeri sýfýra ulaþtýysa, baþa dön
    //    if (newAlpha <= 0.0f)
    //    {
    //        targetImage.color = startColor; // Alpha'yý baþlangýç deðerine getir
    //    }
    //}
//}
