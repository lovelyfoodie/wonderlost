using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float _movementSpeed;
	[SerializeField]
	private float _turningSpeed; 

	private PlayahAnimatorCtrl _charaCtrl; 

	void Start() {

		_charaCtrl = GetComponent<PlayahAnimatorCtrl> ();
	}

	
	// Update is called once per frame
	void Update () {
		
		//Rotate Player by the turning speed * the fraction of a second that has passed in a frame 
		float horizontal = Input.GetAxis ("Horizontal") * _turningSpeed * Time.deltaTime;
		transform.Rotate (0, horizontal, 0);

		//Move Player by the movement speed * the fraction of a second that has passed in a frame
		float vertical = Input.GetAxis ("Vertical") * _movementSpeed * Time.deltaTime;

		//update up down aka movement
		transform.Translate (0, 0, vertical);


		//based on verticle value if 0 then stopped otherwise moving either direction 
		if (vertical == 0) {
			_charaCtrl.StopWalking ();
		} 
		else {
			_charaCtrl.BeginWalking ();
		}



	}
}
