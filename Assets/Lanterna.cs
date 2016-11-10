using UnityEngine;
using System.Collections;

public class Lanterna : MonoBehaviour {

    private AndroidJavaClass ajc;

    // Use this for initialization
    void Start () {
        Debug.Log("Androidtion is to be called");


        ajc = new AndroidJavaClass("br.eti.francisco.lightcontrolmodule.LightControlUtil");
        ajc.CallStatic("lightOn");
        Debug.Log("lightOn is called");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
