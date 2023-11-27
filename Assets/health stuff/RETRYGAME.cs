using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RETRYGAME : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(0);


    }

    public void quitG()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

    }

}
