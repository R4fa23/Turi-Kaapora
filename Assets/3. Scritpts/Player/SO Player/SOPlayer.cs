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
}
