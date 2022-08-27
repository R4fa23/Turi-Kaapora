using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class SOPlayer : ScriptableObject
{
    public SOPlayerHealth soPlayerHealth;
    public SOPlayerMove soPlayerMove;
    public SOPlayerAttack soPlayerAttack;
    public enum State { STOPPED, WALKING, DASHING }
    public State state = State.STOPPED;
    
    //Os estados do enum devem apenas ser usados para condição de controles e de ação no script Player Manager, 
    //e não como condição de ações nos outros scripts 
}
