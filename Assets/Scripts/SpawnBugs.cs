using System.Collections;
using UnityEngine;
using System.Threading;
using UnityEngine.Advertisements;

public class SpawnBugs : MonoBehaviour
{   
    public GameObject bug;
    // Start is called before the first frame update
    void Start()
    {    
        StartCoroutine (Spawn());
    }
    IEnumerator Spawn(){
        while(!Player.lose){
                Instantiate(bug, new Vector2(Random.Range(-2.2f, 2.2f), 6f), Quaternion.identity);
                yield return new WaitForSeconds(0.8f);
           
        }
    }
}
