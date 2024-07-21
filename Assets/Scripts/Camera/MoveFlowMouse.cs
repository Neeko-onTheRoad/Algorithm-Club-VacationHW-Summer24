using DG.Tweening;
using UnityEngine;

public class MoveFlowMouse : MonoBehaviour {

	[SerializeField] private float flowScale = 1f;
	[SerializeField] private float flowSpeed = 1f;

	private Vector3 OriginalPosition;
	private Vector3 CameraOffset;

	private void Start() {
		OriginalPosition = transform.localPosition;
	}

	private void Update() {

		CameraOffset  = Input.mousePosition;
		CameraOffset -= new Vector3(Screen.width, Screen.height) * .6f;
		CameraOffset *= .00025f * flowScale;
		CameraOffset.z = 0f;

		transform.DOKill();
		transform.DOLocalMove(CameraOffset + OriginalPosition, .25f / flowSpeed).SetEase(Ease.OutExpo);

	}

}