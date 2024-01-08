using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOpenScript : MonoBehaviour
{
    public Text textToShow;

    // Bu fonksiyon, butona basýldýðýnda çaðrýlýr.
    public void OpenText()
    {
        // Metin kutusunu görünür yap.
        textToShow.gameObject.SetActive(true);

        // Metin kutusuna istediðiniz metni atayabilirsiniz.
        textToShow.text = "Merhaba, dünya!";
    }
}

