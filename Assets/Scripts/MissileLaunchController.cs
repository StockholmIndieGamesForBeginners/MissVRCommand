using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLaunchController : MonoBehaviour {

    public SteamVR_TrackedObject trackedObject;
    public GameObject missile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObject.index);

        if( device.GetTouch( SteamVR_Controller.ButtonMask.Trigger))
        {
            GameObject localMissile = Instantiate(missile, transform.position, transform.rotation);

        }
    }
}
