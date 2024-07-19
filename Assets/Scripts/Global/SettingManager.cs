using UnityEngine;

public class Setting : MonoBehaviour {

	[HideInInspector] public float BloomLevel = 40f;
	[HideInInspector] public float MusicVol   = 40f;
	[HideInInspector] public float SFXVol     = 40f;

	private void Start() {
		
		DontDestroyOnLoad(this);

	}

}
