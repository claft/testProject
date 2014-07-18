using UnityEngine;
using UnityEditor;
using System.Collections;

public class BatchBuild
{
		[UnityEditor.MenuItem("Tools/Build Project AllScene Android")]
		public static void BuildProjectAllSceneAndroid ()
		{
				EditorUserBuildSettings.SwitchActiveBuildTarget (BuildTarget.Android);
				string[] allScene = new string[EditorBuildSettings.scenes.Length];
				int i = 0;
				foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
						allScene [i] = scene.path;
						i++;
				}	
				PlayerSettings.bundleIdentifier = "jp.co.hoge.hoge";
				PlayerSettings.statusBarHidden = true;
				string errmsg = BuildPipeline.BuildPlayer (allScene,
	                          "hoge.apk",
	                          BuildTarget.Android,
	                          BuildOptions.None
				);
		        
				if (string.IsNullOrEmpty (errmsg)) {
						Debug.Log ("Build Android succeeded");
				} else {
						Debug.Log ("Build Android failed");
				}
		}
}