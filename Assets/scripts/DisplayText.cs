using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;


public class DisplayText : MonoBehaviour
{
    private List<TextMeshProUGUI> textMeshProList = new List<TextMeshProUGUI>();//TextMeshProlarý listede tut!

    public void AddText(TextMeshProUGUI newText)
    {
        if (!textMeshProList.Contains(newText))
        {
            textMeshProList.Add(newText);
        }
    }//TextMeshPro ekleme fonksiyonu
    void Start()
    {
        // Baþlangýçta tüm TextMeshPro nesnelerini gizle
        foreach (TextMeshProUGUI textMeshPro in textMeshProList)
        {
            textMeshPro.gameObject.SetActive(false);
        }
    }
    public void ShowText(TextMeshProUGUI targetText)
    {
        // Tüm TextMeshPro nesnelerini gizle
        foreach (TextMeshProUGUI textMeshPro in textMeshProList)
        {
            textMeshPro.gameObject.SetActive(false);
        }

        //istenilen TextMeshPro nesnesini göster
        if (targetText != null && textMeshProList.Contains(targetText))
        {
            targetText.gameObject.SetActive(true);
        }
    }

}


