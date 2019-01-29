using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
	//private static float accelerometerUpdateInterval = 1.0f / 60.0f;
	private float maxPosX;

	void Start () {
		maxPosX = 4.5f;
	}

	void Update () {
		float gradX = Input.acceleration.y;
		float newX = transform.position.x + 40 * gradX * Time.deltaTime;
		newX = newX > maxPosX ? maxPosX : newX;
		newX = newX < -maxPosX ? -maxPosX : newX;
		transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
	}

	void OnTriggerEnter(Collider col)
	{
		Handheld.Vibrate();
	}
}
