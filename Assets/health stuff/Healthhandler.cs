using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthhandler : MonoBehaviour
{
    public Slider slider;
    public Healthsys healthsys = new Healthsys(100);

  
   public void Update()
    {
        slider.value = healthsys.gethealthperc();
        
    }
    void Awake()
    {
        slider.value = PlayerPrefs.GetFloat("Slider value");
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="enemy") {
            healthsys.Damage(10);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "heal")
        {
            healthsys.heal(7);
            
        }
    }

    public void OnSliderChange(float newValue)
    {
        PlayerPrefs.SetFloat("Slider value", newValue);
    }

}
