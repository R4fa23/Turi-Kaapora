using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class SOPlayerMove : ScriptableObject
{
    public float vel;
    public float dashVel;
    public float dashDuration;
    public float dashCooldown;

    [System.NonSerialized]
    public UnityEvent MoveStartEvent;
    [System.NonSerialized]
    public UnityEvent MoveEndEvent;
    [System.NonSerialized]
    public UnityEvent DashStartEvent;


    private void OnEnable() {
        if(MoveStartEvent == null)
            MoveStartEvent = new UnityEvent();
        
        if(MoveEndEvent == null)
            MoveEndEvent = new UnityEvent();

        if(DashStartEvent == null)
            DashStartEvent = new UnityEvent();
    }

    public void MoveStart(){
        MoveStartEvent.Invoke();
    }
    public void MoveEnd(){
        MoveEndEvent.Invoke();
    }
    public void DashStart(){
        DashStartEvent.Invoke();
    }
}
