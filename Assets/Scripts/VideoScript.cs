using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoScript : MonoBehaviour
{
    [SerializeField] VideoPlayer vPlayer;

    // Start is called before the first frame update
    void Start()
    {
        vPlayer.loopPointReached += WhenVideoFinish;
    }

    void WhenVideoFinish(VideoPlayer vp)
    {
        SceneManager.LoadSceneAsync(1);
    }

}
