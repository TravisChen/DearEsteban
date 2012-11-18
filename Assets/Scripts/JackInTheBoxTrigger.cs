using UnityEngine;
using System.Collections;

public class JackInTheBoxTrigger : MonoBehaviour {
	
	public bool isColliderEnabled = true;	

	public GameObject prop;
	public GameObject renderProp;
	public Transform start;
	public Transform end;
	
	private GameObject player;
	private Vector3 initStart;
	private bool pop = false;
	
	void Start()
	{
		initStart = start.position;
		player = GameObject.FindWithTag("Player");
	}
	
	public void OnTriggerEnter(Collider other) {
        if (isColliderEnabled) {
        	isColliderEnabled = false;
			pop = true;
    	}
    }
	
    void Update() 
    {

		Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - renderProp.transform.position );
    	prop.transform.rotation = Quaternion.Slerp(prop.transform.rotation, targetRotation, 0.5f);
		
		if( pop )
		{
			if( renderProp.renderer.isVisible )
			{
				prop.transform.position = Vector3.Lerp(renderProp.transform.position, end.position, 0.005f);
			}
			else
			{
				prop.transform.position = initStart;
			}
		}
    }
}