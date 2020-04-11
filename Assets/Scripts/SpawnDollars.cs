using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SpawnDollars : MonoBehaviour
{
    public GameObject dollar;
    // Start is called before the first frame update
    void Start()
    {   
        StartCoroutine (DollarsSpawn());
    }
    IEnumerator DollarsSpawn(){
        while(!Player.lose){
            Instantiate(dollar, new Vector2(Random.Range(-2.2f, 2.2f), 6f), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
