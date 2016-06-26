﻿using UnityEngine;
using System.Collections;

public class StateSwitcher : MonoBehaviour {

	public bool switchToIntro = false;
	public bool switchToLauncher = false;

	void Update()
	{
		if (switchToIntro)
			GM.state.Change(StateManager.WorldState.Intro);
		if (switchToLauncher)
			GM.state.Change (StateManager.WorldState.Launcher);

		switchToIntro = false;
		switchToLauncher = false;
	}
}
