using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Levels : MonoBehaviour {

	public List<GameObject> listLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setLevel(int numLevel){
		for (int i = 0; i < listLevel.Count; i++) {
			if(i == numLevel){
				listLevel[i].SetActive(true);
			}else{
				listLevel[i].SetActive(false);
			}
		}
	}

	public void offAllLevels(){
		foreach (GameObject go in listLevel) {
			go.SetActive(false);
		}
	}
}
