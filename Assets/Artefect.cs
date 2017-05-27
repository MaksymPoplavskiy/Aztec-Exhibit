using UnityEngine;
using System.Collections;

public class Artefect : MonoBehaviour {
    public float turnspeed = -1 / 5;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, turnspeed, 0);
  //      Quaternion rotation = Quaternion.Euler(0, 1, 0);
  //      Vector3 myVector = Vector3.one;
 //       Vector3 rotateVector = rotation * myVector;
    }
}
