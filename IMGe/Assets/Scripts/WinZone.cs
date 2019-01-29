using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "Player")
		{
			Debug.Log("Gewonnen");

			SceneManager.LoadScene("Win");
		}
	}
}
