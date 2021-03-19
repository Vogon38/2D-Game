using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	private Rigidbody2D		playerRb;
	
	public float 			speed;
	public float			jumpForce;
		
	void Start () {

		playerRb = GetComponent<Rigidbody2D>();
	
	}
	
	void Update () {

		float h =Input.GetAxisRaw("Horizontal");
		float speedY = playerRb.velocity.y;

		playerRb.velocity = new Vector2(h*speed, speedY);

	}
}
