using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityChoice : MonoBehaviour {
    private Text abilityNameText;
    public AbilityBlueprint LightningBolt;
    public delegate void attackEnemy(int i);
    public event attackEnemy onEnemyAttack;

    // Use this for initialization
    void Start () {
        abilityNameText = GetComponentInChildren<Text>();
        abilityNameText.text = LightningBolt.name;
	}
	
	// Update is called once per frame
	void Update () {

	}
   public void abilityDoesDamage()
    {
        if (onEnemyAttack != null)
        {
            onEnemyAttack(0);
        }
    }
}
