using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityChoice : MonoBehaviour {
    private Text abilityNameText;
    public AbilityBlueprint LightningBolt;

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
        HealthValue.TakeDamage(LightningBolt.damage);
    }
}
