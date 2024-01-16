using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;


public class DisplayText : MonoBehaviour
{
    private List<TextMeshProUGUI> textMeshProList = new List<TextMeshProUGUI>();

    public void AddText(TextMeshProUGUI newText)
    {
        if (!textMeshProList.Contains(newText))
        {
            textMeshProList.Add(newText);
        }
    }
    void Start()
    {
        // Ba�lang��ta t�m TextMeshPro nesnelerini gizle
        foreach (TextMeshProUGUI textMeshPro in textMeshProList)
        {
            textMeshPro.gameObject.SetActive(false);
        }
    }
    public void ShowText(TextMeshProUGUI targetText)
    {
        // T�m TextMeshPro nesnelerini gizle
        foreach (TextMeshProUGUI textMeshPro in textMeshProList)
        {
            textMeshPro.gameObject.SetActive(false);
        }

        // Belirli bir TextMeshPro nesnesini g�ster
        if (targetText != null && textMeshProList.Contains(targetText))
        {
            targetText.gameObject.SetActive(true);
        }
    }

}


