using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	// Use this for initialization
	[SerializeField] int max;
    [SerializeField] int min;
	int guess;
	
	void Start () {
		StartGame();
	}
	void StartGame () {
		max = max + 1;
        guess = (max + min) / 2;
    }
	public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
	void NextGuess () {
		guess = (max + min) / 2;
	}
}
