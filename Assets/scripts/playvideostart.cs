using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class playvideostart : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;
    private bool isPlaying = false;
    // Start is called before the first frame update
    public void Start()
    {

        // Ba�lang��ta videoyu �al
        PlayVideo();


        // Video oynatma i�lemi bitti�inde tetiklenen olaya VideoFinished fonksiyonunu ba�lay�n
        videoPlayer.loopPointReached += VideoFinished;
    }
    private void Update()
    {
        // Video oynat�l�yorsa ve Raw Image g�r�n�rse, videoyu Raw Image'a g�ncelle
        if (isPlaying && rawImage.gameObject.activeSelf)
        {
            rawImage.texture = videoPlayer.texture;
        }
    }
    public void PlayVideo()
    {
        isPlaying = true;

        // E�er video oynat�lm�yorsa, oynat
        videoPlayer.Play();

        // Raw Image'� g�r�n�r yap
        rawImage.gameObject.SetActive(true);

    }
    private void VideoFinished(VideoPlayer vp)
    {
        // Video oynatma i�lemi bitti�inde bu fonksiyon �a�r�l�r

        // Raw Image'� gizle
        rawImage.gameObject.SetActive(false);

        // Video durumunu g�ncelle
        isPlaying = false;
    }

}
