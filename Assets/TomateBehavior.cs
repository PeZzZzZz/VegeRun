using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomateBehavior : MonoBehaviour
{
    public int value = 5;
    private GameObject UI; 

   // Start is called before the first frame update
    void Start()
    {
      UI =  GameObject.FindGameObjectWithTag("TomateAmount");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
       if(col.gameObject.CompareTag("Player")){
	  int TomateUI = int.Parse(UI.GetComponent<Text>().text) + value;
	  UI.GetComponent<Text>().text = TomateUI + "";
	  Destroy(gameObject);
       }
    }
}
