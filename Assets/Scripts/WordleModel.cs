using System;
using System.Linq;
using UnityEngine;

public class WordleModel : MonoBehaviour{
    private int currentAttempt;
    bool isGameWon;
    bool isGameOver;
    private int[,] cells = new int[5, 6];

    [SerializeField] TextAsset possibleAnswersAsset;
    [SerializeField] TextAsset allowedWordsAsset;
    private string[] possibleAnswers;
    private string[] allowedWords;
    private string correctAnswer;
    public string userGuess;


    private void Start(){
        //Splits the text files up by their newline character and saves them to an array
        possibleAnswers = possibleAnswersAsset.text.Trim().Split('\n');
        allowedWords = allowedWordsAsset.text.Trim().Split('\n');

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
        correctAnswer = possibleAnswers[UnityEngine.Random.Range(0, possibleAnswers.Length)].ToUpper();
    }
    public bool IsValidGuess(string guess){
        string g = guess.ToUpper();
        string pa = possibleAnswers[0];
        string s = "ABACK";
        Debug.Log("--------------------------------");
        Debug.Log("g: -" + g + "-");
        Debug.Log("gTrim:-" + g.Trim() + "-");
        Debug.Log("g.length:" + g.Length);
        Debug.Log("++++++++++++++++++++++++++++++++");
        Debug.Log("pa: -" + pa + "-");
        Debug.Log("paTrim:-" + pa.Trim() + "-");
        Debug.Log("pa.length:" + pa.Length); //FIXME: The length is returning 6, which would automatically make nothing compared to this true
        Debug.Log("pa.trim().length:" + pa.Trim().Length);
        int i = 0;
        foreach(char c in pa){
            Debug.Log(i + ": " + c);
            i++;
        }//FIXME: There is a white space at the end, which should be removed
        Debug.Log("++++++++++++++++++++++++++++++++");
        Debug.Log("s: -" + s + "-");
        Debug.Log("sTrim:-" + s.Trim() + "-");
        Debug.Log("s.length:" + s.Length);

        
        Debug.Log("--------------------------------");
        Debug.Log( ".Equals: " + (s.Equals(possibleAnswers[0]) ? "True": "False") );
        Debug.Log( " == : " + (s == possibleAnswers[0] ? "True": "False") );
        Debug.Log( " IndexOf: " + ((Array.IndexOf(possibleAnswers, s) != -1) ? "True": "False") );

        bool isPos, isAllowed;
        isPos = possibleAnswers.Any(answer => answer == guess);
        isAllowed = allowedWords.Any(word => word == guess);
        Debug.Log("--------------------------------");
        if(isPos || isAllowed){
            Debug.Log("Guess is valid");
            return true;
        }
        else{
            Debug.Log("Guess is invalid");
            return false;
        }
    }

    private void UpdateCells(){

    }


}
