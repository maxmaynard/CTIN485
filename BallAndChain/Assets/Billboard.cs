using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {
    Camera camera;
	// Use this for initialization
	void Start () {
        camera = FindObjectOfType<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(camera.transform);
	}
}
