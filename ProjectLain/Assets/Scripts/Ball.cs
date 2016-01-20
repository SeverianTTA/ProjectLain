using UnityEngine;
using System.Collections;
namespace Level02
{
public class Ball : MonoBehaviour {
		
		public float thrust;

		// Use this for initialization
	void Start () {
			Rigidbody go = GetComponent<Rigidbody> ();
			go.AddForce (0, 0,thrust );
	}
	
	// Update is called once per frame
		void FixedUpdate () {
			
	}

		void OnCollisionEnter(Collision col)
		{
			if (col.gameObject.tag == "Wall") 
			{
				Rigidbody go = GetComponent<Rigidbody> ();
				go.AddForce (0, 0,thrust );
			}

		}
	
	
	}
}