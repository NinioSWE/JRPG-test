using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthValue : MonoBehaviour {
    
    public float health = 100;
    public Text healthText;

    private float startHealth;
    private Scrollbar m_Scrollbar;

    private void Start()
    {
        startHealth = health;
        m_Scrollbar = GetComponent<Scrollbar>();
    }
    void Update () {
        if(health > startHealth)
        {
            health = startHealth;
        }
        m_Scrollbar.size = health/startHealth;
        healthText.text = health + "/" + startHealth;
	}
}
