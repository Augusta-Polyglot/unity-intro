using UnityEngine;
using System.Collections;

public class MoveRightAndLeft : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow) || 
		   Input.GetKey(KeyCode.RightArrow)){

			float magnitude = speed * Time.deltaTime;

			if(Input.GetKey(KeyCode.LeftArrow)){
				magnitude = magnitude * -1;
			}

			this.transform.position = new Vector2(
				this.transform.position.x + magnitude,
				this.transform.position.y);
		}
	}










}
