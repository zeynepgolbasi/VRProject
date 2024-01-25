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
        // Video oynatma iþlemi bittiðinde tetiklenen olaya VideoFinished fonksiyonu ekledik
        videoPlayer.loopPointReached += VideoFinished;

        // Video durumu baþlangýç deðeri
        isPlaying = false;

        // Ýlk baþta Raw Image'ý gizle
        rawImage.gameObject.SetActive(false);
    }

    public void PlayVideo()
    {
        // Videoyu baþlat
        videoPlayer.Play();

        // Raw Image'ý görünür yap
        rawImage.gameObject.SetActive(true);

        // Video durumunu güncelle
        isPlaying = true;

        // Video oynatma iþlemi bittiðinde tetiklenen olaya VideoFinished fonksiyonun ekledik
        videoPlayer.loopPointReached += VideoFinished;
    }
    private void Update()
    {
        // Video oynatýlýyorsa ve Raw Image görünürse, videoyu Raw Image'a güncelle
        if (isPlaying && rawImage.gameObject.activeSelf)
        {
            rawImage.texture = videoPlayer.texture;
        }
    }

    private void VideoFinished(VideoPlayer vp)
    {

        // Raw Image'ý gizle
        rawImage.gameObject.SetActive(false);

        // Video durumunu güncelle
        isPlaying = false;
    }

    public void TogglePlayPause()
    {

        if (!isPlaying)
        {
            // Eðer video oynatýlmýyorsa, oynat
            videoPlayer.Play();

            // Raw Image'ý görünür yap
            rawImage.gameObject.SetActive(true);
        }
        else
        {
            // Eðer video oynatýlýyorsa, duraklat
            videoPlayer.Pause();
        }

        // Video durumunu güncelle
        isPlaying = !isPlaying;
    }
}
