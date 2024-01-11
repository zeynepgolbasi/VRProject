using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

    // Bu fonksiyon, butona her týklandýðýnda çaðrýlýr.
    public class TextOpenScript : MonoBehaviour
    {
        public TextMeshProUGUI textToShow;

        // Bu fonksiyon, butona her týklandýðýnda çaðrýlýr.
        public void ToggleTextVisibility()
        {
            // Text Mesh Pro öðesinin görünürlük durumunu tersine çevir.
            if (textToShow.gameObject.activeSelf)
            {
                // Eðer metni görünür yapýyorsa, gizle.
                textToShow.gameObject.SetActive(false);
            }
            else
            {
                // Eðer metni gizli yapýyorsa, görünür yap.
                textToShow.gameObject.SetActive(true);

            }
        }
    }



