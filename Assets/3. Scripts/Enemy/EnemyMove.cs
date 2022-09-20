using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    SOEnemy soEnemy;
    SOSave soSave;
    NavMeshAgent navMeshAgent;
    Transform player;
    bool detected;
    bool initialMove;
    SOEnemy.State lastState;
    bool firstEnable;
    Vector3 firstLocal;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        lastState = SOEnemy.State.STOPPED;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        navMeshAgent.SetDestination(transform.position);
        soEnemy = GetComponent<EnemyManager>().soEnemy;
        soSave = GetComponent<EnemyManager>().soSave;
        navMeshAgent.speed = soEnemy.vel;
        OnEnable();
        firstLocal = transform.position;
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) < soEnemy.distanceDetectation && !detected)
        {
            Detect();
        }        

        if(soEnemy.state == SOEnemy.State.WALKING)
        {
            navMeshAgent.SetDestination(player.position);
            if(lastState != soEnemy.state)
            {
                lastState = soEnemy.state;
                soEnemy.MoveStart();
            }
            
        }
        else
        {
            navMeshAgent.SetDestination(transform.position);
        }
        
    }

    void Detect()
    {
        soEnemy.state = SOEnemy.State.WALKING;
        detected = true;
        navMeshAgent.SetDestination(player.position);
        soEnemy.MoveStart();
    }

    public void Restart()
    {
        detected = false;
        lastState = SOEnemy.State.STOPPED;
        transform.position = firstLocal;
        if(gameObject.activeInHierarchy) navMeshAgent.SetDestination(transform.position);
        
    }



    void OnEnable()
    {
        //navMeshAgent.SetDestination(transform.position);
        if(firstEnable)
        {
            soEnemy.SummonEvent.AddListener(Detect);
            soSave.RestartEvent.AddListener(Restart);
        }
        firstEnable = true;
    }
    void OnDisable()
    {
        soEnemy.SummonEvent.RemoveListener(Detect);
        soSave.RestartEvent.RemoveListener(Restart);
    }

}
