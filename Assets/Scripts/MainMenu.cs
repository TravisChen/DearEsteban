using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public GUITexture begin;
	public GUITexture logo;
	public GameObject player;
	
	private bool fade = false;
	
	public void OnMouseDown() {
		
		player.GetComponent<MouseLook>().enabled = true;
		player.GetComponent<CharacterMotor>().enabled = true;
		fade = true;
		
	}
	
    void Update() {
		
		if( fade )
		{
			Color logoTextureColor = logo.guiTexture.color;
    		logoTextureColor.a = logoTextureColor.a - 0.05f;
    		logo.guiTexture.color = logoTextureColor;
			
			Color beginTextureColor = begin.guiTexture.color;
			beginTextureColor.a = logoTextureColor.a - 0.05f;
    		begin.guiTexture.color = beginTextureColor;
			
			if( logoTextureColor.a <= 0 )
			{
				Destroy(begin);
				Destroy(logo);			}
		}
		
	}
}