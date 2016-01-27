using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ChangeColorOnImage : MonoBehaviour {

	// Use this for initialization

	public Image Image1;

	void Start () {
	
	}
	
	// Update is called once per frame
	public void ChangeColorWhite () 
	{
		Image1.color = Color.white;
	}
	public void ChangeColorRed () 
	{
		Image1.color = Color.red;
	}
	public void ChangeColorBlue () 
	{
		Image1.color = Color.blue;
	}
	public void ChangeColorGreen () 
	{
		Image1.color = Color.green;
	}

}
