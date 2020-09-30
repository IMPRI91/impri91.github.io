using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{

    public string videoName;

    private VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = transform.GetComponent<VideoPlayer>();
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoName+".mp4");
    }

    public void StartVideo()
    {
            videoPlayer.Play();
    }

    public void StopVideo()
    {
            videoPlayer.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
