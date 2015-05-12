using UnityEngine;
using System.Collections;

public class MeshOutSide : MonoBehaviour {

	public MeshFilter filter;

	public MeshCollider meshCollider;

	public Vector3 niz = default(Vector3);
	public Vector3 verh = default(Vector3);

	private float offset_y = 12f;
	// Use this for initialization
	void Start () {
		Vector3[] mas = filter.mesh.vertices;

		Vector3[] newMas = new Vector3[mas.Length];

//		for (int i = 0; i < 21; i++) {
//			Debug.Log((i+1).ToString()+mas[i].ToString());
//		}

		int k = 1;

		for (int i = 0; i < mas.Length; i++) {

			if(k == 1 || k == 4 || k == 5 || k == 8 || k == 9 || k == 12)
				newMas[i] = new Vector3(mas[i].x, mas[i].y + offset_y, mas[i].z);
			else
				newMas[i] = new Vector3(mas[i].x, mas[i].y, mas[i].z);

			k++;
			if(k > 12)
				k=1;
		}

		Mesh newMesh = new Mesh ();

		newMesh.vertices = newMas;
		newMesh.triangles = filter.mesh.triangles;

		meshCollider.sharedMesh = newMesh;

		//filter.mesh.vertices = newMas;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
