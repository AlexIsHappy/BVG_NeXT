using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumPeopleText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var instruction = GetComponent<Text>();
        instruction.text = "24";
    }
}
