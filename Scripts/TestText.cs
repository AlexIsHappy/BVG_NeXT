using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TestText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var instruction = GetComponent<Text>();
        instruction.text = "12 %";
    }

    int cntdwn1 = 3500;
    int cntdwn2 = 4000;
}
