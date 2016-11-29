using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyText : MonoBehaviour {
    public Text Mytext;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Mytext.text = Time.deltaTime.ToString();
	}
}
