using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {
	private Transform tr;
	private NetworkView _networkView;

	void Awake(){
		tr = GetComponent<Transform> ();
		_networkView = GetComponent<NetworkView> ();

		if (_networkView.isMine) {
			Camera.main.GetComponent<SmoothFollow>().target = tr;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
