using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Scrollbar))]
public class ScrollBarTextDisplay : MonoBehaviour {

	[SerializeField] private TextMeshProUGUI targetText;

	public void OnScroll() {
		
		targetText.text = (int)(GetComponent<Scrollbar>().value * 100) + "%";

	}

}