using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarotteAmount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CarotteAmount") + "";   
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey("a")){
	Debug.Log("Panier Sauvegarde");
	PlayerPrefs.SetInt("CarotteAmount", int.Parse(gameObject.GetComponent<Text>().text));
      }
    }
}
