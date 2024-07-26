using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	[SerializeField] private Transform mainCamera;
	[SerializeField] private Canvas    settingCanvas;
	[SerializeField] private Canvas    mainCanvas;

	private OnClickCanvasMove canvasMoveToSettingScript;
	private OnClickCanvasMove canvasMoveToMainScript;

	private void Awake() {

		canvasMoveToSettingScript = gameObject.AddComponent<OnClickCanvasMove>();
		canvasMoveToSettingScript.TargetObject = mainCamera;
		canvasMoveToSettingScript.TargetCanvas = settingCanvas;

		canvasMoveToMainScript = gameObject.AddComponent<OnClickCanvasMove>();
		canvasMoveToMainScript.TargetObject = mainCamera;
		canvasMoveToMainScript.TargetCanvas = mainCanvas;

	}
	
	//=================================================================================| Main Screen Menu Buttons

	public void OnStartButtonPressed() {
		SceneManager.LoadScene("FourierTransformation");
	}

	public void OnSettingButtonPressed() {
        canvasMoveToSettingScript.OnButtonClick();
	}

	public void OnExitButtonPressed() {
		Application.Quit();
	}
    
	//=================================================================================| Hyper Links

	public void OnGithubButtonPressed() {
		Application.OpenURL("https://github.com/Neeko-onTheRoad");
	}

	//=================================================================================| ETC

	public void OnGotoMainButtonPressed() {
		canvasMoveToMainScript.OnButtonClick();
	}

}

public class ScrollManager : MonoBehaviour {

	[SerializeField] private PostProcessVolume volume;

	//=================================================================================| Setting Scroll Bar

	public void OnSettingBloomLevelScroll() {
		volume.profile.GetSetting<Bloom>().intensity.value = GetComponent<Scrollbar>().value * 10f;
	}
	
	public void OnSFXVoliumScroll() {
		
	}

	public void OnMusicVoliumScroll() {
		
	}
}
