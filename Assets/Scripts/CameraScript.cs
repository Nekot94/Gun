using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public float offsetZ;
    [SerializeField] private GameObject cannon;

    private void Start ()
    {
        offsetZ = cannon.transform.localScale.z * 15;
        LookAtCannon();
	}
	

    private void LookAtCannon()
    {
        Vector3 temp = transform.position;
        temp.z = cannon.transform.position.x - offsetZ;
        transform.position = temp;
    }
}
