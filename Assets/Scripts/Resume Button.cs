using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeButton : MonoBehaviour
{
    public void MainResumeButton()
    {
        AudioManager.instance.StopMusic();
        SceneManager.LoadSceneAsync(2);

    }
}
