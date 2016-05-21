using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	protected float mJumpSpeed = 12.0f;
	public    bool  isLanding = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isLanding) {
			if (Input.GetMouseButtonDown(0)) {
				this.isLanding = false;
				this.GetComponent<Rigidbody>().velocity = Vector3.up * this.mJumpSpeed;
			}
		}
	}
	
	// 他のゲームオブジェクトと当たったら
	void OnCollisionEnter(Collision collistion)
	{
		if (collistion.gameObject.tag == "Floor") {
			this.isLanding = true;
		}
	}
}
