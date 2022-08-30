using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public string description;
    public SOPlayer soPlayer;
    PlayerMap playerMap;
    bool movement;
    bool canDash = true;
    bool canAttack = true;
    
    //Esse script deve ser o único que usa o enum como condição, ele gerencia o input map
    //e é nele que serão chamados as funções de context

    void Awake()
    {
        soPlayer.soPlayerHealth.life = soPlayer.soPlayerHealth.maxLife;
        soPlayer.soPlayerAttack.currentCooldown = soPlayer.soPlayerAttack.attackCooldown;
        soPlayer.soPlayerAttack.currentDamage = soPlayer.soPlayerAttack.attackDamage;
        soPlayer.soPlayerAttack.currentDuration = soPlayer.soPlayerAttack.attackDuration;
        soPlayer.state = SOPlayer.State.STOPPED;

        playerMap = new PlayerMap();

        //Forma de chamar as funções sem precisar associar manualmente no inspector
        playerMap.Default.Enable();
        playerMap.Default.Movement.started += MovementStarted;
        playerMap.Default.Movement.canceled += MovementCanceled;
        playerMap.Default.Dash.started += DashStarted;
        playerMap.Default.Attack.started += AttackStarted;

    }
    
    //O jogador só pode se mover se estiver parado ou se já estiver se movendo
    //O dash tem a prioridade de ações, mas pra usar o jogador precisa estar andando
    //O dash pode interromper o ataque
    //O estado base é parado
    void Update()
    {
        //Debug.Log(soPlayer.state);
        if(movement) MovementPerformed(); //Forma pra que rode todo frame enquanto o botão estiver apertado

    }

    //-------------------------------MOVIMENTAÇÃO--------------------------------- 
    public void MovementStarted(InputAction.CallbackContext context)
    {
        movement = true;
        /*
        if(soPlayer.state == SOPlayer.State.STOPPED)
        {
            soPlayer.state = SOPlayer.State.WALKING;
            soPlayer.soPlayerMove.MoveStart();
            
        }
        else if(soPlayer.state == SOPlayer.State.DASHING)
        {
            soPlayer.soPlayerMove.MoveStart();
        }
        */
    }

    public void MovementPerformed()
    {
        if(soPlayer.state == SOPlayer.State.STOPPED || soPlayer.state == SOPlayer.State.WALKING)
        {
            soPlayer.state = SOPlayer.State.WALKING;
            soPlayer.soPlayerMove.MoveStart();
            
        }
    }
    public void MovementCanceled(InputAction.CallbackContext context) {
        movement = false;

        if(soPlayer.state == SOPlayer.State.WALKING)
        {
            soPlayer.state = SOPlayer.State.STOPPED;
            soPlayer.soPlayerMove.MoveEnd();
        }
        /*
        else if(soPlayer.state == SOPlayer.State.DASHING)
        {
            soPlayer.soPlayerMove.MoveEnd();
        }
        */
        
    }
    //-------------------------------DASH--------------------------------- 
    public void DashStarted(InputAction.CallbackContext context)
    {
        if(canDash)
        {
            canDash = false;
            StartCoroutine(DashCooldown());
            soPlayer.state = SOPlayer.State.DASHING;
            soPlayer.soPlayerMove.DashStart();
        }
    }

    IEnumerator DashCooldown()
    {
        yield return new WaitForSeconds(soPlayer.soPlayerMove.dashCooldown + soPlayer.soPlayerMove.dashDuration);
        canDash = true;
    }
    //-------------------------------ATAQUE--------------------------------- 
    public void AttackStarted(InputAction.CallbackContext context)
    {
        if(soPlayer.state == SOPlayer.State.STOPPED || soPlayer.state == SOPlayer.State.WALKING && canAttack)
        {
            canAttack = false;
            StartCoroutine(AttackCooldown());
            soPlayer.state = SOPlayer.State.ATTACKING;
            soPlayer.soPlayerAttack.AttackStart();
        }
    }
    IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(soPlayer.soPlayerAttack.currentCooldown + soPlayer.soPlayerAttack.currentDuration);
        if(soPlayer.soPlayerAttack.currentCooldown == soPlayer.soPlayerAttack.damagedCooldown) soPlayer.soPlayerAttack.currentCooldown = soPlayer.soPlayerAttack.attackCooldown;
        canAttack = true;
    }

    void ChangeCooldown()
    {
        StopAllCoroutines();
        canAttack = false;
        soPlayer.soPlayerAttack.currentCooldown = soPlayer.soPlayerAttack.damagedCooldown;
        StartCoroutine(AttackCooldown());
    }
    public void OnEnable()
    {
        soPlayer.soPlayerHealth.HealthChangeEvent.AddListener(ChangeCooldown);
    }
    public void OnDisable()
    {
        soPlayer.soPlayerHealth.HealthChangeEvent.RemoveListener(ChangeCooldown);
    }
}
