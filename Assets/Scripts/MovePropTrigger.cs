using UnityEngine;
using System.Collections;

public class MovePropTrigger : MonoBehaviour {
	
	public bool isColliderEnabled = true;	
	public GameObject prop;
   	public Transform start;
    public Transform end;
	public float speed;
    public bool move = false;
	
	public void OnTriggerEnter(Collider other){
        if (isColliderEnabled) {
        	isColliderEnabled = false;
			move = true;
    	}
    }

    void Update() 
    {
    	if (move)
        {
        	prop.transform.position = Vector3.Lerp(start.position, end.position, speed * Time.deltaTime);
            float dist = Mathf.Abs(Vector3.Distance(prop.transform.position, end.position));
			if(dist < 50)
            {
           		move = false;
				Destroy(prop);
            }
        }
    }
}