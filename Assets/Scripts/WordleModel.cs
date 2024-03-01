using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordleModel : MonoBehaviour{
    private WordleController controller;
    private WordleView view;

    private int currentAttempt;
    private int[,] cells = new int[6, 5];

    private TextAsset possibleAnswersAsset;
    private TextAsset allowedWordsAsset;
    private string[] possibleAnswers;
    private string[] allowedWords;
    private string correctAnswer;


    private void SetUp(){

    }
    private void IsValidGuess(string guess){

    }
    private void UpdateCells(){

    }


}
