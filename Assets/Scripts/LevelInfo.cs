using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelInfo : MonoBehaviour {

	public GameObject startLine;
	public GameObject finishLine;

	public GameObject ringCollider;

	public List<GameObject> listMarkers;

	//private float maxDistance = 999999f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setForwardDirection(){
		ringCollider.transform.position = finishLine.transform.position;
		ringCollider.transform.rotation = finishLine.transform.rotation;
		ringCollider.transform.localScale = finishLine.transform.localScale;
	}

	public void setReverseDirection(){
		ringCollider.transform.position = startLine.transform.position;
		ringCollider.transform.rotation = startLine.transform.rotation;
		ringCollider.transform.localScale = startLine.transform.localScale;
	}

	public void getNearestMarker(GameObject currentObject){
		float minDistance = 0;

		int index = 0;
		int count = 0;
		int foundIndex = 0;

		if (GameData.Get ().currentLvl <= 10) {
			index = 0;
			count = listMarkers.Count - 1;
		} else {
			index = 1;
			count = listMarkers.Count;
		}

		GameObject nearestMarker = currentObject;
		for (int i = index ; i < count; i++) {

			GameObject marker = listMarkers[i];
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

		if (GameData.Get ().currentLvl > 10) {
			int indexOfMarkers = listMarkers.IndexOf(nearestMarker);

			if(indexOfMarkers != listMarkers.Count-1){
				Vector3 curAngle = currentObject.transform.rotation.eulerAngles;
				curAngle.y = currentObject.transform.rotation.eulerAngles.y + 180f;
				currentObject.transform.rotation = Quaternion.Euler(curAngle.x, curAngle.y, curAngle.z);
			}
		}
	}

// old
//	public void getNearestMarker(GameObject currentObject){
//		float minDistance = 0;
//		GameObject nearestMarker = currentObject;
//		foreach (GameObject marker in listMarkers) {
//			Vector3 delta = currentObject.transform.position - marker.transform.position;
//			if(Mathf.Approximately(minDistance, 0f) == true){
//				minDistance = delta.magnitude;
//				nearestMarker = marker; 
//			}else if(delta.magnitude < minDistance){
//				minDistance = delta.magnitude;
//				nearestMarker = marker; 
//			}
//		}
//
//		Vector3 resultPosition = new Vector3 (nearestMarker.transform.position.x, nearestMarker.transform.position.y + 1f, nearestMarker.transform.position.z);
//
//		currentObject.transform.position = resultPosition;
//		currentObject.transform.rotation = nearestMarker.transform.rotation;
//	}
}
