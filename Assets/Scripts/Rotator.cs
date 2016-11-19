using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
  

  //Use Update when not using forces
	void Update ()
  {
    transform.Rotate(new Vector3(0,0,45) * Time.deltaTime);
	}
}
