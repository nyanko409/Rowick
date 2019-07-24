using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayMovie : MonoBehaviour
{
    public VideoClip videoClip;

    VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        var audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.playOnAwake = false;
        videoPlayer.clip = videoClip;
        videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);

        videoPlayer.loopPointReached += FinishMovie;
        videoPlayer.Play();
    }

    void Update()
    {
        //if (Input.GetButtonDown("Jump"))
        //{
        //    if (videoPlayer.isPlaying)
        //    {
        //        videoPlayer.Pause();
        //    }
        //    else
        //    {
        //        videoPlayer.Play();
        //    }
        //}
    }

    void FinishMovie(VideoPlayer vp)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
