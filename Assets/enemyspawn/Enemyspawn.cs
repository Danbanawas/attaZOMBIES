using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawn: MonoBehaviour
{
    public GameObject prefab;
    public int CountofCubes;
    private IEnumerator coroutine;
    public float spawnRate;

    IEnumerator Start()
    {
        while (true)
        {
            for (int i = 0; i < CountofCubes; i++)
            {
                Instantiate(prefab, new Vector3(Random.Range(-25.0f, 25.0f), 0.5f, Random.Range(-25.0f, 25.0f)), Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
