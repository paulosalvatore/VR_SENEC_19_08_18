using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

	private Rigidbody rb;
	public float velocidade = 2f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		rb.velocity = new Vector3(
			h * velocidade,
			rb.velocity.y,
			v * velocidade
		);
	}
}
