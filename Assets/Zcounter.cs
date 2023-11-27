using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Zcounter : MonoBehaviour
{
    public TMP_Text  textcounter;

    int kills;

    public void Update()
    {
        showkill();
    }
    private void showkill()
    {
        textcounter.text = kills.ToString();
        if (kills >= 20)
        {
            SceneManager.LoadScene(2);

        }
    }

    public void addkill()
    {
        kills++;
    }
         








}
