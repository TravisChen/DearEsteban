using UnityEngine;
using System.Collections;

public class EndSoundTrigger : MonoBehaviour {
	
	public bool isColliderEnabled = true;
	public GUITexture fin;
	
	private bool fade = false;
	
	public void OnTriggerEnter(Collider other){
        if (isColliderEnabled) {
        	isColliderEnabled = false;
			audio.Play();
			
			fade = true;
			fin.guiTexture.enabled = true;
			
			Color finTextureColor = fin.guiTexture.color;
    		finTextureColor.a = 0.0f;
    		fin.guiTexture.color = finTextureColor;
        }
    }
	
	void Update() {
		
		if( fade )
		{
			Color finTextureColor = fin.guiTexture.color;
			if( finTextureColor.a < 1.0f )
			{
    			finTextureColor.a = finTextureColor.a + 0.01f;
    			fin.guiTexture.color = finTextureColor;
			}
		}
		
	}
}