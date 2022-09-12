using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public SOPlayer soPlayer;
    public int damage;
    public float distance;
    public float vel;
    Vector3 firstLocal;
    Vector3 finalLocal;
    Vector3 target;
    bool started;
    // Start is called before the first frame update
    void Start()
    {
        started = true;
        firstLocal = transform.position;
        finalLocal = transform.position + (transform.forward * distance);
        target = finalLocal;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawLine(transform.position, transform.position + (transform.forward * 10), Color.red);
        transform.position = Vector3.MoveTowards(transform.position, target, vel * Time.deltaTime);

        if(transform.position == target)
        {
            if(target == firstLocal) target = finalLocal;
            else if(target == finalLocal) target = firstLocal;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            soPlayer.soPlayerHealth.HealthChange(-damage);
        }
    }

    void OnDrawGizmos()
    {
        if(!started)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + (transform.forward * distance));
        }
    }
}
