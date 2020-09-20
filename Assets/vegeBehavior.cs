using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vegeBehavior : MonoBehaviour{
	
	public Rigidbody2D rb;
	public float vitesse;
	public float maxJump;
	private bool isGrounded = false;
    // Start is called before the first frame update
    void Start(){
        rb.velocity += new Vector2(vitesse, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up") && isGrounded){
			Jump();
		}
    }
	
	void Jump(){
		rb.velocity += new Vector2(0, maxJump);
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.CompareTag("Ground")){
			isGrounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D col){
		if(col.gameObject.CompareTag("Ground")){
			isGrounded = false;
		}
	}

}

