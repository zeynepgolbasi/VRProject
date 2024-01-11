using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOpenScript : MonoBehaviour
{
    public Text textToShow;
    public void OpenText()
    {
        // Metin kutusunu görünür yap.
        textToShow.gameObject.SetActive(!textToShow.gameObject.activeSelf);

        // Eðer metin kutusu görünür deðilse metni kapat
        if (!textToShow.gameObject.activeSelf)
        {
            textToShow.text = "";
        }
       
    }
}

