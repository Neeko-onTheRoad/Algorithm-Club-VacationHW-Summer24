using DG.Tweening;
using UnityEngine;

public class WaveControllerMove : MonoBehaviour {
	
	[SerializeField] private float transitionSpeed = 1f;

	public KeyCode TransitionKey = KeyCode.Tab;

	private bool  isShowing         = false;
	private float originalPositionX = new();

	private void Start() {
		originalPositionX = transform.position.x;
	}

	private void Update() {
		if (Input.GetKeyDown(TransitionKey)) {
			if (isShowing) {
				isShowing = false;	
				transform.DOMoveX(originalPositionX, .5f / transitionSpeed).SetEase(Ease.InOutExpo);
			}
			else {
				isShowing = true;
				transform.DOMoveX(-6.8f, .5f / transitionSpeed).SetEase(Ease.InOutExpo);
			}
		}
	}


}