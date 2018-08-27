using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour {

	private CharacterController controller;
	private Vector3 moveDirection = Vector3.zero;
	public float speed = 2F;
	public float gravity = 9.8f;
	public float speedZ;

	// ★追加（横移動のスピード）
	public float speedX;

	// ★追加（旋回のスピード）
	public float turnSpeed;

	void Start(){
		Invoke("ChangeScene", 10F);
		// Invoke("DestroyObject", 2F);
		controller = GetComponent<CharacterController> ();
	}

	// void DestroyObject(){
	// 	Destroy (gameObject, 2F);
    // }

	void ChangeScene(){
        SceneManager.LoadScene ("AutumnScene");
    }

	void Update(){
		transform.position += transform.forward * Time.deltaTime * speed;
		
		if (controller.isGrounded) {
			moveDirection.z = Input.GetAxis ("Vertical") * Time.deltaTime * speedZ;

			// （★）下記のコードをコメントアウトしましょう。
			transform.Rotate (0, Input.GetAxis ("Horizontal") * 2, 0);

			// ★追加
			// 左右キーで水平横移動
			moveDirection.x = Input.GetAxis("Horizontal") * Time.deltaTime * speedX;

			// ★追加
			// マウスの左右移動で旋回
			transform.Rotate(0, Input.GetAxis("Mouse X") * turnSpeed, 0);

		} 
		// if (gameObject == null){
		// 	SceneManager.LoadScene ("AutumnScene");
		// }

		moveDirection.y -= gravity * Time.deltaTime;

		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection);
	}
}