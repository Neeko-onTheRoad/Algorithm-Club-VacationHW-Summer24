using DG.Tweening;
using UnityEngine;

class OnClickCanvasMove : MonoBehaviour {

	public Transform TargetObject;
	public Canvas    TargetCanvas;

	public float Distance       = 10f;
	public float TransformSpeed = 1f;

	public void OnButtonClick() {
		
		RectTransform targetTransform = TargetCanvas.GetComponent<RectTransform>();

		Vector3 targetPosition   = targetTransform.position;
		Vector3 targetEularAngle = targetTransform.eulerAngles;

		Quaternion rotation  = Quaternion.Euler(targetEularAngle);
		Vector3    forward   = rotation * Vector3.forward;
		Vector3    resultPos = targetPosition - forward * Distance;
		
		Vector3    direction = targetPosition - resultPos;
		Quaternion lookPoint = Quaternion.LookRotation(direction);


		TargetObject.transform.DOMove(resultPos, .5f / TransformSpeed).SetEase(Ease.InOutExpo);
		TargetObject.transform.DORotate(lookPoint.eulerAngles, .5f / TransformSpeed).SetEase(Ease.InOutExpo);

	}

}