using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {

    public void Exit()
    {
        Application.Quit();
    }

    public void Gameplay()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
