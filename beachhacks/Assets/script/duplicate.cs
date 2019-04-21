using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicate : MonoBehaviour {


    public GameObject pillar_pair_prefab;
    public float randomnum;
    public static bool isBeat = false;
    // Update is called once per frame
    void Update()
    {
        if (isBeat)
        {
            StartCoroutine(SpawnPillarAfterDelay());
            isBeat = false;
        }
    }

    bool spawning = false;
    IEnumerator SpawnPillarAfterDelay()
    {
        spawning = true;
        yield return new WaitForSeconds(7.0f);

        GameObject.Instantiate(
            pillar_pair_prefab,
            new Vector3(10, UnityEngine.Random.Range(-2, randomnum), 0),
            Quaternion.identity
            );

        spawning = false;
    }
}


