﻿using UnityEngine;

public class FallDown : MonoBehaviour
{   
    [SerializeField]
    private float fallSpeed = 4.5f;

    void Update(){
        if(transform.position.y < -4f){
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D other){
       if(other.gameObject.tag == "Player"){
          Destroy(gameObject);
       }
   }
}
