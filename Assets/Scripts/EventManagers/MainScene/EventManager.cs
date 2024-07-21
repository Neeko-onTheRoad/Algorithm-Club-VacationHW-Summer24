using Unity.VisualScripting;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

	[SerializeField] private Transform         mainCamera;
	[SerializeField] private Canvas            settingCanvas;
	[SerializeField] private Canvas            mainCanvas;

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

	public void OnStartButtonPressed() {
		
	}

	public void OnSettingButtonPressed() {
        canvasMoveToSettingScript.OnButtonClick();
	}

	public void OnExitButtonPressed() {
		Application.Quit();
	}
    
	public void OnGithubButtonPressed() {
		Application.OpenURL("https://github.com/Neeko-onTheRoad");
	}

	public void OnGotoMainButtonPressed() {
		canvasMoveToMainScript.OnButtonClick();
	}

}
