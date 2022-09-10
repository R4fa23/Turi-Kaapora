using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camp : MonoBehaviour
{
    public int waves;
    public int[] enemyPerWave;

    [HideInInspector]
    public SOCamp soCamp;
    bool completed;
    public GameObject[] doors;
    public GameObject[] cabin;
    public GameObject[] firstEnemies;
    int enemyCount;
    int indexCabin;
    bool firstEnable;
    void Awake()
    {
        if(waves != enemyPerWave.Length) enemyPerWave = new int[waves];
        if(firstEnemies.Length > 0) enemyPerWave[0] = firstEnemies.Length;
        soCamp = (SOCamp)ScriptableObject.CreateInstance(typeof(SOCamp));
        SetConfiguration();
    }

    private void Start() 
    {
        OnEnable();
    }
    

    void SetConfiguration()
    {
        soCamp.waves = waves;
        soCamp.enemyPerWaves = enemyPerWave;

    }

    void StartCamp()
    {
        foreach(GameObject d in doors)
        {
            d.SetActive(true);
        }

        if(firstEnemies.Length > 0)
        {
            foreach(GameObject e in firstEnemies)
            {
                e.GetComponent<EnemyManager>().soEnemy.Summon();
            }
        }
        else
        {
            SummonEnemies();
        }
    }

    void SummonEnemies()
    {
        if(enemyCount < enemyPerWave[soCamp.actualWave])
        {
            cabin[indexCabin].GetComponent<Cabin>().SummonEnemy();
            indexCabin++;
            if(indexCabin >= cabin.Length) indexCabin = 0;
            enemyCount++;
            StartCoroutine(SummonDelay());
        }
    }

    void NextWave()
    {
        enemyCount = 0;
        SummonEnemies();
    }

    void ConclusionCamp()
    {
        enemyCount = 0;
        foreach(GameObject d in doors)
        {
            d.SetActive(false);
        }
        completed = true;
    }

    IEnumerator SummonDelay()
    {
        yield return new WaitForSeconds(1);
        SummonEnemies();
    }

    void EnemyDied()
    {
        soCamp.DieEnemy();
    }

    public void OnEnable()
    {
        if(firstEnable)
        {
            soCamp.EnterCampEvent.AddListener(StartCamp);
            soCamp.NextWaveEvent.AddListener(NextWave);
            soCamp.ConclusionCampEvent.AddListener(ConclusionCamp);
            foreach(GameObject e in firstEnemies)
            {
                    e.GetComponent<EnemyManager>().soEnemy.DieEvent.AddListener(EnemyDied);
            }
        }
        firstEnable = true;
    }
    public void OnDisable()
    {
        soCamp.EnterCampEvent.RemoveListener(StartCamp);
        soCamp.NextWaveEvent.RemoveListener(NextWave);
        soCamp.ConclusionCampEvent.RemoveListener(ConclusionCamp);
        foreach(GameObject e in firstEnemies)
        {
                e.GetComponent<EnemyManager>().soEnemy.DieEvent.RemoveListener(EnemyDied);
        }
    }
}
