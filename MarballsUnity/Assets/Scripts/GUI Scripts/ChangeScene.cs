﻿using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void changeToScene (int sceneToChangeTo) {
		Application.LoadLevel(sceneToChangeTo);
	}
}
