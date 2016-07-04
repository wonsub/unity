using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	
	}
	
	
    //update 처리 이후에 처리됨
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	
	}
}
