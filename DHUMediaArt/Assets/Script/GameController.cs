using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ★追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	// ★追加
	public Text timeLabel;
	public float timeCount;

	// ★追加
	void Start () {
		timeLabel.text = "TIME;" + timeCount;
	}

	// ★追加
	void Update () {

		timeCount -= Time.deltaTime;

		// ToString("0")は小数点を切り捨て
		// 小数点1位まで表示するにはToString("n1")
		// 小数点2位まで表示するにはToString("n2")
		timeLabel.text = "TIME;" + timeCount.ToString("0");

		if(timeCount < 0){
			SceneManager.LoadScene("GameOver");
		}
	}
}