using DG.Tweening;
using UnityEngine;

class OnClickCanvasMove : MonoBehaviour {

	[SerializeField] private Transform targetObject;
	[SerializeField] private Canvas    targetCanvas;

	[SerializeField] private float distance       = 10f;
	[SerializeField] private float transformSpeed = 1f;

	public void OnButtonClick() {
		
		RectTransform targetTransform = targetCanvas.GetComponent<RectTransform>();

		Vector3 targetPosition   = targetTransform.position;
		Vector3 targetEularAngle = targetTransform.eulerAngles;

		Quaternion rotation  = Quaternion.Euler(targetEularAngle);
		Vector3    forward   = rotation * Vector3.forward;
		Vector3    resultPos = targetPosition - forward * distance;
		
		Vector3    direction = targetPosition - resultPos;
		Quaternion lookPoint = Quaternion.LookRotation(direction);


		targetObject.transform.DOMove(resultPos, .5f / transformSpeed).SetEase(Ease.InOutExpo);
		targetObject.transform.DORotate(lookPoint.eulerAngles, .5f / transformSpeed).SetEase(Ease.InOutExpo);

	}

}