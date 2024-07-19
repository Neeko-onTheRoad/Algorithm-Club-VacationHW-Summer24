using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

[RequireComponent(typeof(Scrollbar))]
public class BloomLevelScrollBar : MonoBehaviour {

	[SerializeField] private PostProcessVolume volume;

	public void OnScroll() {
		
		volume.profile.GetSetting<Bloom>().intensity.value = GetComponent<Scrollbar>().value * 10f;

	}

}
