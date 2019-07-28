using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCallAndroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (GUILayout.Button("Echo"))
        {
            AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
            string str = jo.Call<string>("Echo","123");
            Debug.Log(str);
            GUI.Label(new Rect(20, 20, 500, 500), str);
        }

    }
}
