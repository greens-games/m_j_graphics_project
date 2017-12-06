using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector3 move_speed = Vector3.zero;
	public int health = 100;
	public Vector3 jump_speed = Vector3.zero;

	//int test =  transform.position.y;

	// Use this for initialization
	void Start () {
		move_speed.x = 0.1f;
		jump_speed.y = 0.1f;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			if(gameObject.GetComponent<SpriteRenderer> ().flipX) {
				gameObject.GetComponent<SpriteRenderer> ().flipX = false;
			}
			transform.position += move_speed;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			flip();
			transform.position -= move_speed;
		}

		if (health == 0) {
			Destroy(gameObject);
		}

	
	}

	void FixedUpdate() {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += jump_speed;
		}
	}

	void TakeDamage() {
			health -= 1;
	}

	void flip() {
		gameObject.GetComponent<SpriteRenderer> ().flipX = true;
	}
}
