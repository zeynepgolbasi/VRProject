using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOpenScript : MonoBehaviour
{
    public Text textToShow;
    public void OpenText()
    {
        // Metin kutusunu g�r�n�r yap.
        textToShow.gameObject.SetActive(!textToShow.gameObject.activeSelf);

        // E�er metin kutusu g�r�n�r de�ilse metni kapat
        if (!textToShow.gameObject.activeSelf)
        {
            textToShow.text = "";
        }
       
    }
}

