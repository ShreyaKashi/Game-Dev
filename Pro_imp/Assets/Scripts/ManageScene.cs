using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour {

	void OnMouseDown()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			SceneManager.LoadScene ("SecondaryRed");
		}
	}
}