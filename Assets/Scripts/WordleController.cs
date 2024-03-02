using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WordleController : MonoBehaviour{
    [SerializeField] WordleModel model;
    [SerializeField] WordleView view;
    [SerializeField] TMP_InputField input;

    private void GameSetup(){
        //input = gameObject.GetComponent<InputField>();
        //Calls the setup function on the model and the view
        model.Setup();
        view.Setup();
    }
    public void SubmitGuess(){
        Debug.Log("Submit was pressed");
        model.userGuess = input.text;
        Debug.Log("Guess: " + model.userGuess);

        if((input.text != null || input.text!= "") && input.text.Length == 5){
            Debug.Log("Text is not null");
            if ( model.IsValidGuess(input.text.ToUpper()) ){
                Debug.Log("Guess is valid");
            }
            else{
                Debug.Log("Guess is not valid");
            }
        }
        else{
            Debug.Log("Text is null or less than 5 characters");
        }
    

        //TODO: Call isGuessValid() for guess validity
        //TODO: update model.currentAttempt
        //TODO: update model.userGuess
        //TODO: Call model.UpdateCells() to update the cells
        //TODO: Call view.UpdateView()

    }
    private void WinGame(){
        //TODO: Check is the current guess equals the correct answer
        //TODO: Reveal a reset button to restart the game
    }
    private void LoseGame(){
        //TODO: Checks if the max number of attempts has been reached and the current guess is not equal to the correct answer
        //TODO: Reveal a reset button to restart the game
    }

}
