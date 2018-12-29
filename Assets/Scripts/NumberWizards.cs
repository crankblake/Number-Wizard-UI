using UnityEngine;
using System.Collections;
using TMPro;
using System.Linq;

public class NumberWizards : MonoBehaviour {
	// Use this for initialization
	[SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
	int guess;
	
	void Start () {
		StartGame();
	}
	void StartGame () {
        NextGuess();
    }
	public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
	void NextGuess () {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
