using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpecial : MonoBehaviour
{
    public SOPlayer soPlayer;
    SphereCollider sphereCollider;
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpecialStart()
    {
        sphereCollider.enabled = true;
        meshRenderer.enabled = true;
        StartCoroutine(StopSpecial());
    }

    void SpecialEnd()
    {
        sphereCollider.enabled = false;
        meshRenderer.enabled = false;
        soPlayer.state = SOPlayer.State.STOPPED;
    }

    IEnumerator StopSpecial()
    {
        yield return new WaitForSeconds(soPlayer.soPlayerAttack.specialDuration);
        SpecialEnd();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyManager>().soEnemy.ChangeLife(-soPlayer.soPlayerAttack.specialDamage);
            other.GetComponent<EnemyManager>().soEnemy.Repulsion();
        }
    }

    void OnEnable()
    {
        soPlayer.soPlayerAttack.SpecialStartEvent.AddListener(SpecialStart);
    }
    void OnDisable()
    {
        soPlayer.soPlayerAttack.SpecialStartEvent.RemoveListener(SpecialStart);
    }
}
