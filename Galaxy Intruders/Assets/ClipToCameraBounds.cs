using UnityEngine;
using System.Collections;

public class ClipToCameraBounds : MonoBehaviour {

	private float minPos;
	private float maxPos;

	private SpriteRenderer dude;

	// Use this for initialization
	void Start () {
	
		dude = this.GetComponent<SpriteRenderer>();

		float halfTheDude = dude.bounds.size.x/2;

		minPos = Camera.main.ScreenToWorldPoint(
			Vector3.zero).x + halfTheDude;

		maxPos = Camera.main.ScreenToWorldPoint(
			new Vector3(Camera.main.pixelWidth,0)).x
			- halfTheDude;

	}
	
	// Update is called once per frame
	void Update () {


	}

	void LateUpdate(){
		this.transform.position = new Vector2(
			Mathf.Clamp(this.transform.position.x,
		            minPos,
		            maxPos),
			this.transform.position.y);
	}
}
