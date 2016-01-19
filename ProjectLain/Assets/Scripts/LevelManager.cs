using UnityEngine;
using System.Collections;
namespace StartMenu
{
	
public class LevelManager : MonoBehaviour {

	public void LoadScene(string name)
	{
		Application.LoadLevel (name);
	}


//		need to set name property
//		public void SelectScene(string name)
//		{
//			Application.
//		}


	public void ExitGame()
	{
		Application.Quit ();
	}

}
}