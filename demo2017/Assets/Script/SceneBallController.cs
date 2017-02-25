using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneBallController : MonoBehaviour {
	public Text txtScore;
	public Text txtAttack;
	public Text txtLife;
	// Use this for initialization
	public GameObject obtaclePrefab;
	public GameObject moneyPrefab;
	public GameObject ballPrefab;
	void Start () {
		DoTestObtacle ();
		CreateBall ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateText ();
	}
	void UpdateText(){
		txtScore.text = "Score :" + score.ToString ();
		txtLife.text = "Life : " + life.ToString ();
	}

	public static int score = 0;
	int attack = 10;
	public static int life = 5;
	public void DoPushButton(){
		score++;
		attack += 2;
		txtScore.text = "Score :" + score.ToString ();
		txtAttack.text = "Attack :" + attack.ToString ();
	}

	public void DoChangeScene(){
		SceneManager.LoadScene (0);
	}

	public void DoTestObtacle(){
		StartCoroutine (GameProcess());
	}

	IEnumerator GameProcess(){
		for (int i = 0; i < 20; i++) {
			GameObject obtacle = Instantiate (obtaclePrefab);
			float positionY = Random.Range (-0.55f, 5.55f);
			obtacle.transform.position = new Vector3 (5.52f, positionY, 0);

			GameObject money = Instantiate (moneyPrefab);
			money.transform.position = new Vector3 (5.65f, positionY + 1.33f+Random.Range(-0.01f,0.01f), 0);
			yield return new WaitForSeconds(1);
		}
	}

	void CreateBall(){
		Instantiate (ballPrefab).GetComponent<BallController> ().SetDieCallback (CreateBall);
	}
}
