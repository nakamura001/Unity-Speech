using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Test : MonoBehaviour {
	
	private string talk_text = "こんにちは";
	
	void OnGUI() {
		talk_text = GUI.TextField(new Rect(5, 5, 200, 20), talk_text);
		if (GUI.Button(new Rect(5, 30, 200, 50), "test")) {
			Process process = new Process();
			process.StartInfo.FileName="say";
			process.StartInfo.Arguments = talk_text;
			process.StartInfo.RedirectStandardError=true;
			process.StartInfo.RedirectStandardOutput=true;
			process.StartInfo.CreateNoWindow=true;
			process.StartInfo.WorkingDirectory=Application.dataPath+"/..";
			process.StartInfo.UseShellExecute=false;
			process.Start();
		}
	}
}
