using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RevMobAdManager : MonoBehaviour {

	// Enter Your RevMob Ad IDs
	private static readonly Dictionary<string, string> REVMOB_APP_IDS = new Dictionary<string, string> () {
		{ "Android", ""},
		{ "IOS", "" }
	};

	private static RevMob revmob;
	private static RevMobBanner banner;
	private static RevMobBanner loadedBanner;
	private static RevMobFullscreen fullscreen;

	void OnGUI() {
		if(GUILayout.Button("Start Session"))
		{
			#if !UNITY_EDITOR
			revmob = RevMob.Start (REVMOB_APP_IDS, gameObject.name);
			#endif
		}
		if(GUILayout.Button("Create Intertitial"))
		{
			#if !UNITY_EDITOR
			fullscreen = revmob.CreateFullscreen ();
			#endif
		}
		if(GUILayout.Button("Display Interstitial"))
		{
			#if !UNITY_EDITOR
			if (fullscreen == null)
				fullscreen = revmob.CreateFullscreen ();

			fullscreen.Show ();
			#endif
		}
		if(GUILayout.Button("Create Banner"))
		{
			#if !UNITY_EDITOR
			loadedBanner = revmob.CreateBanner ();
			#endif
		}
		if(GUILayout.Button("Show Banner"))
		{
			#if !UNITY_EDITOR
			loadedBanner.Show ();               
			#endif
		}
		if(GUILayout.Button("Hide Banner"))
		{
			#if !UNITY_EDITOR
			loadedBanner.Hide ();
			#endif
		}
	}
}
