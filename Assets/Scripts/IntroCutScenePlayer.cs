using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroCutscenePlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName = "Gameplay";

    void Start()
    {
        string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, "intro.mp4");
        videoPlayer.url = videoPath;

        videoPlayer.loopPointReached += OnVideoEnd;
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += OnPrepared;
    }

    void OnPrepared(VideoPlayer vp)
    {
        videoPlayer.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
