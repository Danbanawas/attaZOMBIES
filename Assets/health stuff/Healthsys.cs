using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[Serializable]
public class Healthsys 
{
   public float HealthPoint;
   public float maxHealth;
  

    public Healthsys(int maxHealth)
    {
        this.maxHealth = maxHealth;
        HealthPoint = maxHealth;
    }
   public float getHealth() { return HealthPoint; }
    public float gethealthperc() { return HealthPoint/maxHealth;}
    public void Damage(int damageAmount) {
        HealthPoint -= damageAmount;
        if (HealthPoint <= 0) { HealthPoint = 0;
            if (HealthPoint <= 80)
            {
                SceneManager.LoadScene(1);
            }
        }

    }
    public void heal(int healAmount)
    {
        HealthPoint += healAmount;
        if(HealthPoint > maxHealth) { HealthPoint = maxHealth; }
    }

   
    
    }
