using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthValue : MonoBehaviour {
    
    public float startHealth = 100;
    public Text healthText;

   static private float health;
    private Scrollbar m_Scrollbar;

    private void Start()
    {
        health = startHealth;
        m_Scrollbar = GetComponent<Scrollbar>();
    }
    void Update () {
        if(health > startHealth)
        {
           startHealth = health;
        }
        else if (health <= 0)
        {
            SceneManager.LoadScene("main");
        }
        m_Scrollbar.size = health/startHealth;
        healthText.text = health + "/" + startHealth;
	}

    public static void TakeDamage(float damage)
    {
        health -= damage;
    }
}
