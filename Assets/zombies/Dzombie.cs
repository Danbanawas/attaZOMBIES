using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class Dzombie : MonoBehaviour
{
    private Movement playerJumpScript;
    [SerializeField] private TMP_Text Zcounter;
    
    private int Zombies = 0;
    Raycastgun hitit;
   
    // Start is called before the first frame update
    void Start()
    {
        playerJumpScript = GetComponent<Movement>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag==("enemy"))
        {
            Destroy(collision.gameObject);
            Zombies++;
            
            if (Zombies>= 50)
            {
                SceneManager.LoadScene(2);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Zcounter.text = ("" + Zombies);


    }
}
