using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Levels : MonoBehaviour {

	public List<GameObject> listLevel;

	// Use this for initialization
	void Start () {
		//offAllLevels ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setLevel(int numLevel){
		listLevel[getIndexLevel(numLevel)].SetActive(true);

//		for (int i = 0; i < listLevel.Count; i++) {
//			if(i == numLevel){
//				listLevel[i].SetActive(true);
//			}else{
//				listLevel[i].SetActive(false);
//			}
//		}
	}

	public GameObject getLevel(int numLevel){
//		if (numLevel < listLevel.Count) {
			return listLevel [getIndexLevel(numLevel)];
//		} else
//			return null;
	}

	public void offLevel(int numLevel){
		listLevel[getIndexLevel(numLevel)].SetActive(false);
	}

	public void offAllLevels(){
		foreach (GameObject go in listLevel) {
			go.SetActive(false);
		}
	}

	private int getIndexLevel(int numLevel){
		int indexLevel = -1;
		
		if (numLevel < 10)
			indexLevel = numLevel;
		else
			indexLevel = numLevel - 10;

		return indexLevel;
	}
}
