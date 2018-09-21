﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGooglePlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Checking wether Google Play is up to date.");
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Set a flag here indiciating that Firebase is ready to use by your
                // application.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
