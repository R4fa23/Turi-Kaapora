using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "SOPlayerAttack", menuName = "ScriptableObjects/Characters/Player/Attack")]
public class SOPlayerAttack : ScriptableObject
{
    public float attackDuration;
    public float attackCooldown;
    public float attackComboFinalDuration;
    public float attackComboFinalCooldown;
    [HideInInspector]
    public float attackDamage;
    public float comboTime;
    [HideInInspector]
    public float comboDamage;
    public float damagedCooldown;
    [HideInInspector]
    public float currentCooldown;
    [HideInInspector]
    public float currentDuration;
    [HideInInspector]
    public float currentDamage;
    [HideInInspector]
    public int comboIndex = 0;
    [HideInInspector]
    public float specialDamage;
    public float specialDuration;
    [HideInInspector]
    public float specialCooldown;
    [HideInInspector]
    public float specialTime;
    [HideInInspector]
    public float cooldownReduction;
    public float repulsionSpecialForce;
    [HideInInspector]
    public bool hitKill;


    [System.NonSerialized]
    public UnityEvent AttackStartEvent;
    [System.NonSerialized]
    public UnityEvent<GameObject> EnemyDieEvent;
    [System.NonSerialized]
    public UnityEvent SpecialStartEvent;
    [System.NonSerialized]
    public UnityEvent SpecialFinishEvent;

    private void OnEnable() {
        if(AttackStartEvent == null)
            AttackStartEvent = new UnityEvent();

        if(EnemyDieEvent == null)
            EnemyDieEvent = new UnityEvent<GameObject>();

        if(SpecialStartEvent == null)
            SpecialStartEvent = new UnityEvent();
        
        if(SpecialFinishEvent == null)
            SpecialFinishEvent = new UnityEvent();
    }

    public void AttackStart()
    {
        if(comboIndex == 2)
        {
            currentDamage = comboDamage;
            currentCooldown = attackComboFinalCooldown;
            currentDuration = attackComboFinalDuration;
        }
        else{
            currentDamage = attackDamage;
            currentCooldown = attackCooldown;
            currentDuration = attackDuration;
        }
        AttackStartEvent.Invoke();
    }

    public void EnemyDie(GameObject enemy)
    {
        EnemyDieEvent.Invoke(enemy);
    }

    public void SpecialStart()
    {
        SpecialStartEvent.Invoke();
    }

    public void SpecialFinish()
    {
        SpecialFinishEvent.Invoke();
    }

    public void ReduceCooldown()
    {
        specialTime += cooldownReduction;
    }
}
