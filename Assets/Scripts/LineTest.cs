using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class LineTest : MonoBehaviour {

	Vector3[] vt;

	private IEnumerable<Vector3> GetPoints() {
		
		for (float i = -10; i < 10; i += 0.1f) {
			yield return new Vector3(i, Mathf.Sin(i), 10);
		}

	}

	private void Start() {

		vt = GetPoints().ToArray();
		
		GetComponent<LineRenderer>().positionCount = vt.Length;
		GetComponent<LineRenderer>().SetPositions(vt);
		GetComponent<LineRenderer>().colorGradient = new();
		GetComponent<LineRenderer>().startWidth = .1f;
		GetComponent<LineRenderer>().endWidth = .1f;

	}

	private void Update() {
	}

}
