using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;

    private bool isPlaying = false;

    private void Start()
    {
        // Video oynatma i�lemi bitti�inde tetiklenen olaya VideoFinished fonksiyonu ekledik
        videoPlayer.loopPointReached += VideoFinished;

        // Video durumu ba�lang�� de�eri
        isPlaying = false;

        // �lk ba�ta Raw Image'� gizle
        rawImage.gameObject.SetActive(false);
    }

    public void PlayVideo()
    {
        // Videoyu ba�lat
        videoPlayer.Play();

        // Raw Image'� g�r�n�r yap
        rawImage.gameObject.SetActive(true);

        // Video durumunu g�ncelle
        isPlaying = true;

        // Video oynatma i�lemi bitti�inde tetiklenen olaya VideoFinished fonksiyonun ekledik
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

    private void VideoFinished(VideoPlayer vp)
    {

        // Raw Image'� gizle
        rawImage.gameObject.SetActive(false);

        // Video durumunu g�ncelle
        isPlaying = false;
    }

    public void TogglePlayPause()
    {

        if (!isPlaying)
        {
            // E�er video oynat�lm�yorsa, oynat
            videoPlayer.Play();

            // Raw Image'� g�r�n�r yap
            rawImage.gameObject.SetActive(true);
        }
        else
        {
            // E�er video oynat�l�yorsa, duraklat
            videoPlayer.Pause();
        }

        // Video durumunu g�ncelle
        isPlaying = !isPlaying;
    }
}
