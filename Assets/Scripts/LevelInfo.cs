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

	public Vector3 getNearestMarker(GameObject currentObject){
		float minDistance = 0;
		Vector3 resultPosition = default(Vector3);
		foreach (GameObject marker in listMarkers) {
			Vector3 delta = currentObject.transform.position - marker.transform.position;
			if(Mathf.Approximately(minDistance, 0f) == true){
				minDistance = delta.magnitude;
				resultPosition = marker.transform.position; 
			}else if(delta.magnitude < minDistance){
				minDistance = delta.magnitude;
				resultPosition = marker.transform.position; 
			}
		}

		resultPosition = new Vector3 (resultPosition.x, resultPosition.y + 1f, resultPosition.z);

		return resultPosition;
	}
}
