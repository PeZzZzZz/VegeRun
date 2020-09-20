using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour{

    public GameObject Perso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     	transform.position = new Vector3(Perso.transform.position.x + 40.5f,0,-100);  
    }
}
