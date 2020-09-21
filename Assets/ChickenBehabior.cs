using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChickenBehabior : MonoBehaviour
{
 
    private GameObject UI;

   // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("ChickenAmount");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col){
	   if(col.gameObject.CompareTag("Player")){
	   Destroy(gameObject);
	}
    }
}
