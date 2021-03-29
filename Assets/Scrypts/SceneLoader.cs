﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    const int StartSceneIndex = 0;

    public void LoadNextScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(StartSceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
