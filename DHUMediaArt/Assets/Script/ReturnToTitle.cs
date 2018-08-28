using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToTitle : MonoBehaviour {

	public int timeCount;
	// Use this for initialization
	void Start () {
		// 任意に設定した時間の経過後、「GoTitle」メソッドを呼び出す（ポイント）
		Invoke("GoTitle", timeCount);
	}
	
	void GoTitle(){
		SceneManager.LoadScene("Title");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
