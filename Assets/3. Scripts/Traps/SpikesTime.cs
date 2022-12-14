using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public class SpikesTime : MonoBehaviour
{
    public SOPlayer soPlayer;
    public SOSave soSave;
    public GameObject spikes;
    public float durationSpike;
    public float delaySpike;
    bool charging;

    [SerializeField] VisualEffect vfx;

    void Start()
    {
        spikes.SetActive(false);
    }    

    void StartCharge()
    {
        charging = true;
        StartCoroutine(UpSpikes());
    }

    IEnumerator UpSpikes()
    {
        yield return new WaitForSeconds(delaySpike);
        spikes.SetActive(true);
        FMODUnity.RuntimeManager.PlayOneShot("event:/Perigos/Espinhos", transform.position);
        vfx.Reinit();
        vfx.SendEvent("OnPlay");
        StartCoroutine(DownSpikes());
    }

    IEnumerator DownSpikes()
    {
        yield return new WaitForSeconds(durationSpike);
        spikes.SetActive(false);
        charging = false;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(!soPlayer.soPlayerHealth.dead)
            {
                if(!charging)
                {
                    StartCharge();
                }
            }
        }
    }

    void Restart()
    {
        StopAllCoroutines();
        spikes.SetActive(false);
        charging = false;
    }

    void OnEnable()
    {
        soSave.RestartEvent.AddListener(Restart);
    }
    void OnDisable()
    {
        soSave.RestartEvent.RemoveListener(Restart);
    }
}
