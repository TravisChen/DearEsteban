using UnityEngine;
using System.Collections;

public class SoundTrigger : MonoBehaviour {
	
	public bool isColliderEnabled = true;
	
	public void OnTriggerEnter(Collider other){
        if (isColliderEnabled) {
        	isColliderEnabled = false;
			audio.Play();
        }
    }
}