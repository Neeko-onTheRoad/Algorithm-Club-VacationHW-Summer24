using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDestroy : MonoBehaviour {

	public void Start() {
		DontDestroyOnLoad(this);
	}

}
