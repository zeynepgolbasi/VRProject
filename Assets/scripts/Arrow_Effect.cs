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
       //blink fonk çaðýr.
       //0.0f fonksiyonu hemen çaðýr
       
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

