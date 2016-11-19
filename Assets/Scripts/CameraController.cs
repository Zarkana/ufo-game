using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

  public GameObject player;

  private Vector3 offset;

	// Use this for initialization
	void Start () {
    //transform references the transform of the object that this script is attached to
    offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
  {
    transform.position = player.transform.position + offset;
	}
}
