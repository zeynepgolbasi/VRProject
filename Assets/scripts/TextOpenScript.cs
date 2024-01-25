using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

    public class TextOpenScript : MonoBehaviour
    {
        public TextMeshProUGUI textToShow;

        
        public void ToggleTextVisibility()
        {
            // Text Mesh Pro ��esinin g�r�n�rl�k durumunu tersine �evir.
            if (textToShow.gameObject.activeSelf)
            {
                // E�er metni g�r�n�r yap�yorsa, gizle.
                textToShow.gameObject.SetActive(false);
            }
            else
            {
                // E�er metni gizli yap�yorsa, g�r�n�r yap.
                textToShow.gameObject.SetActive(true);

            }
        }
    }



