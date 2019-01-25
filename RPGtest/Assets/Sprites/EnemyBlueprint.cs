using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyBlueprint: MonoBehaviour
{
    public string name;
    public int hp;
    public List<AbilityBlueprint> abilities = new List<AbilityBlueprint>();
    public delegate void attackHeroes(int i);
    public event attackHeroes onAttackHeroes;


    private void Start()
    {
        
    }

    void Update()
    {
    }
    void EnemyAttack()
    {
        if (onAttackHeroes != null)
        {
            onAttackHeroes(0);
        }
    }
}
