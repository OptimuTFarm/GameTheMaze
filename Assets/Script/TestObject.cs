using UnityEngine;
using System.Collections;
using Parse;

public class TestObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ParseObject testUser = new ParseObject("GameUser");
		testUser["userRef"] = 1;
		testUser["username"] = "admin";
		testUser["password"] = "admin";
		testUser["email"] = "keng_15850@hotmail.com";
		testUser.SaveAsync();
		
		ParseObject testScore = new ParseObject("GameScore");
		testScore["scoreRef"] = 1;
		testScore["score"] = 100;
		testScore.SaveAsync();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
