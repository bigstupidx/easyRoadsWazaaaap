using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelInfo : MonoBehaviour {

	public List<GameObject> listMarkers;

	//private float maxDistance = 999999f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void getNearestMarker(GameObject currentObject){
		float minDistance = 0;
		GameObject nearestMarker = currentObject;
		foreach (GameObject marker in listMarkers) {
			Vector3 delta = currentObject.transform.position - marker.transform.position;
			if(Mathf.Approximately(minDistance, 0f) == true){
				minDistance = delta.magnitude;
				nearestMarker = marker; 
			}else if(delta.magnitude < minDistance){
				minDistance = delta.magnitude;
				nearestMarker = marker; 
			}
		}

		Vector3 resultPosition = new Vector3 (nearestMarker.transform.position.x, nearestMarker.transform.position.y + 1f, nearestMarker.transform.position.z);

		currentObject.transform.position = resultPosition;
		currentObject.transform.rotation = nearestMarker.transform.rotation;
	}
}
