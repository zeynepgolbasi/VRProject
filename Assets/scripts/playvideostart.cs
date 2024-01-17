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

        // Baþlangýçta videoyu çal
        PlayVideo();


        // Video oynatma iþlemi bittiðinde tetiklenen olaya VideoFinished fonksiyonunu baðlayýn
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
    public void PlayVideo()
    {
        isPlaying = true;

        // Eðer video oynatýlmýyorsa, oynat
        videoPlayer.Play();

        // Raw Image'ý görünür yap
        rawImage.gameObject.SetActive(true);

    }
    private void VideoFinished(VideoPlayer vp)
    {
        // Video oynatma iþlemi bittiðinde bu fonksiyon çaðrýlýr

        // Raw Image'ý gizle
        rawImage.gameObject.SetActive(false);

        // Video durumunu güncelle
        isPlaying = false;
    }

}
