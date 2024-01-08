using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOpenScript : MonoBehaviour
{
    public Text textToShow;

    // Bu fonksiyon, butona bas�ld���nda �a�r�l�r.
    public void OpenText()
    {
        // Metin kutusunu g�r�n�r yap.
        textToShow.gameObject.SetActive(true);

        // Metin kutusuna istedi�iniz metni atayabilirsiniz.
        textToShow.text = "Merhaba, d�nya!";
    }
}

