using UnityEngine;

public class PlayahAnimatorCtrl : MonoBehaviour {

	private Animator _characterAnimator;

	void Start(){
		_characterAnimator = GetComponent<Animator> ();
	}

	public void BeginWalking(){
		_characterAnimator.SetBool ("isWalking", true);
	}
	public void StopWalking(){
		_characterAnimator.SetBool ("isWalking", false);
	}

}