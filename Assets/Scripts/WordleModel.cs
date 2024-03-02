using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//using System.Array;

public class WordleModel : MonoBehaviour{
    private int currentAttempt;
    private int[,] cells = new int[5, 6];

    [SerializeField] TextAsset possibleAnswersAsset;
    [SerializeField] TextAsset allowedWordsAsset;
    private string[] possibleAnswers;
    private string[] allowedWords;
    private string correctAnswer;
    public string userGuess;


    private void Start(){
        //Spilts the text files up by their newline character and saves them to an array
        possibleAnswers = possibleAnswersAsset.text.Split('\n');
        allowedWords = allowedWordsAsset.text.Split('\n');

        //Found this to convert Everything to Uppercase
        possibleAnswers = System.Array.ConvertAll(possibleAnswers, x => x.ToUpper());
        allowedWords = System.Array.ConvertAll(allowedWords, x => x.ToUpper());

        //Sets the current attempt to 1
        currentAttempt = 1;
        
        Setup();
        //DEBUG:
        Debug.Log("Possible Answers: " + possibleAnswers.Length);
        Debug.Log("");
        Debug.Log("allowed words: " + allowedWords.Length);
        Debug.Log("");
        Debug.Log("Debug: PossibleAnswer 1: " + possibleAnswers[0]);
    }


    public void Setup(){

        currentAttempt = 1;
        //Gets a random answer from the possible answers list
        correctAnswer = possibleAnswers[Random.Range(0, possibleAnswers.Length)].ToUpper();
    }
    public bool IsValidGuess(string guess){
        //If the guess is not in the list of possible (which would return -1), return false
        if(System.Array.IndexOf(possibleAnswers, guess.ToUpper()) == -1 && System.Array.IndexOf(allowedWords, guess.ToUpper()) == -1){
            return false;
        }
        else{
            return true;
        }
    }
    private void UpdateCells(){

    }


}
