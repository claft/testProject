using UnityEngine;
using System.Collections;

public class fizzbuzz_loop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Fizzbuzz fizzbuzz = new Fizzbuzz ();
		for (int i = 1; i <= 100; i++) {
			print (fizzbuzz.fb (i));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
