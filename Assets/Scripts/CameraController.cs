using UnityEngine;

public class CameraController : MonoBehaviour {
	//Player object to maintain focus on
	[SerializeField]
	private GameObject _player;
	//Amount of delay when player first moves or stops for camera to react
	[SerializeField]
	private float damping = 2;
	//Distance away from player to maintain
	private Vector3 _offset;

	void Start() {
		//Set distance between camera and player
		_offset = this.transform.position - _player.transform.position;
	}

	//LateUpdate() occurs after Update()
	void LateUpdate() {
		//After players position updates, calculate the new position for the camera
		Vector3 desiredPosition = _player.transform.position + _offset;
		//Move between current camera position and desired position in a certain amount of time based on frame time and damping
		Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
		//Set the camera's new position to maintain the correct distance from the player
		this.transform.position = position;
		//Center the camera at the player
		this.transform.LookAt(_player.transform.position);
	}
}