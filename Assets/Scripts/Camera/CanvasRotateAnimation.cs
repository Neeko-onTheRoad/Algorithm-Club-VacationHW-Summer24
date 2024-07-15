using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class CanvasRotateAnimation : MonoBehaviour {

	[SerializeField] private float   rotationSpeed = 1f;
	[SerializeField] private float   rotationScale = 1f;
	[SerializeField] private Vector2 rotationRatio = new(1f, 1f);


	private float         angle;
	private Vector3       startAngle;
	private RectTransform rectTransform;

	private void Awake() {
		rectTransform = GetComponent<RectTransform>();
	}

	private void Start() {
		startAngle = rectTransform.eulerAngles;
	}

	private void Update() {

		angle += Time.deltaTime * rotationSpeed;

		if (angle >= 2 * Mathf.PI) {
			angle -= 2 * Mathf.PI;
		}

		Vector3 additionalEulerAngle = new(
			Mathf.Sin(angle),
			Mathf.Cos(angle)
		);

		additionalEulerAngle *= rotationScale;
		additionalEulerAngle *= rotationRatio;

		rectTransform.eulerAngles = startAngle + additionalEulerAngle;
	}

}