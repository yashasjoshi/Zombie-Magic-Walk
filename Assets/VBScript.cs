using System.Collections;
using UnityEngine;
using Vuforia;

public class VBScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	private GameObject zombie;
	// Use this for initialization
	void Start () {
		vbButtonObject = GameObject.Find ("Walk");
		zombie = GameObject.Find ("zombie");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){

		zombie.GetComponent<Animation> ().Play ();
		Debug.Log ("Button Down !!!");

	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){

		zombie.GetComponent<Animation> ().Stop ();

	}
}
