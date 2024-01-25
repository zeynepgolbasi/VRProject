using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class XRChangeScene : MonoBehaviour
{
    public int sceneIndexToLoad = 2; // Yüklemek istediðiniz sahnenin indeksi

    private void OnCollisionEnter(Collision collision)
    {
        // XR Origin veya VR kullanýcý avatarý ile çarpýþma algýlandý
        if (collision.gameObject.CompareTag("Player")) 
        {
            SceneManager.LoadScene(sceneIndexToLoad);
        }
    }
}
