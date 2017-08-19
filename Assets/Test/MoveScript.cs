using UnityEngine;
using System.Collections;
public class MoveScript : MonoBehaviour {

	[SerializeField]
	private float speed;

	void Update() {
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}