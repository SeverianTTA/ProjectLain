
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace StartMenu
{
	
public class LevelManager : MonoBehaviour {
		public InputField iField;
		public string scene;
//		public void onClick()
//		{
//			string sceneChoice = UserImput ();
//			Application.LoadLevel (sceneChoice);
//
//		}
//
//
//
//
//		string UserImput()
//		{
//			InputField userField;
//
//
//			string scene = userField.text;
//			return scene;
//		
//		}
//
//










		public void SelectScene()
	{
			

			string scene = iField.text;	

			SceneManager.LoadScene(scene);
		}


	public void ExitGame()
	{
		Application.Quit ();
	}

}
}