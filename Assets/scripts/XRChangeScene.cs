using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class XRChangeScene : MonoBehaviour
{
    public int sceneIndexToLoad = 2; // Y�klemek istedi�iniz sahnenin indeksi

    private void OnCollisionEnter(Collision collision)
    {
        // XR Origin veya VR kullan�c� avatar� ile �arp��ma alg�land�
        if (collision.gameObject.CompareTag("Player")) // "Player" etiketi XR Origin veya kullan�c� avatar�na atanmal�d�r
        {
            SceneManager.LoadScene(sceneIndexToLoad);
        }
    }
}
