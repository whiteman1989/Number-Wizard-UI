using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]
    private int max = 1000;
    [SerializeField]
    private int min = 1;
    [SerializeField]
    private Text guessText;
    private int curentMax;
    private int curentMin;
    private int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    public void OnPressHigher()
    {
        curentMin = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        curentMax = guess;
        NextGuess();
    }

    private int GuessCalc()
    {
        return Random.Range(curentMin, curentMax);
    }

    private void NextGuess()
    {
        guess = GuessCalc();
        guessText.text = guess.ToString();
        Debug.Log($"New min: {curentMin}, new max {curentMax}.");
    }

    private void StartGame()
    {
        curentMax = max;
        curentMin = min;
        NextGuess();
        curentMax += 1;
    }
}
