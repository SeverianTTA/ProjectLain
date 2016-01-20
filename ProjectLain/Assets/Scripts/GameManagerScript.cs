using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour {

	static GameManagerScript Instance;

	// Use this for initialization
	void Start () {
		if (Instance != null) {
			GameObject.Destroy (gameObject);
		} else 
		{
			GameObject.DontDestroyOnLoad (gameObject);
			Instance = this;
		}
	
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Keypad0)) 
		{
			SceneManager.LoadScene (0);
		}
	
		if (Input.GetKeyUp (KeyCode.Keypad1)) 
		{
			SceneManager.LoadScene (1);
		}
	
		if (Input.GetKeyUp (KeyCode.Keypad2)) 
		{
			SceneManager.LoadScene (2);
		}
	
		if (Input.GetKeyUp (KeyCode.Escape)) 
		{
			Application.Quit();
		}
	}
}
