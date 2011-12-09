using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

	void Start () {
		Shell.shell("touch", Application.dataPath+"/ushell_was_here");
	}

}
