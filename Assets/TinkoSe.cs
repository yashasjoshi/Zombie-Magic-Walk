using System.Collections;
using UnityEngine;
using Vuforia;

public class TinkoSe : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject[] vbButtonObject;
	private GameObject zombie;
	// Use this for initialization
	void Start () {
		GameObject[] vbButtonObject = new GameObject[2];
		vbButtonObject[0] = GameObject.Find ("Walk");
		vbButtonObject[1] = GameObject.Find ("attack");
		zombie = GameObject.Find ("zombie");
		for(int i=0;i<2;i++)
		vbButtonObject[i].GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){

		if (vb.name == "Ẅalk")
			zombie.GetComponent<Animation> ().Play("attack");
		if (vb.name == "attach")
			zombie.GetComponent<Animation> ().Play ("walk");
		Debug.Log ("Button Down !!!");

	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){

		zombie.GetComponent<Animation> ().Stop ();

	}
}
