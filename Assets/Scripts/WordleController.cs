using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WordleController : MonoBehaviour{
    [SerializeField] WordleModel model;
    [SerializeField] WordleView view;
    private InputField input;

    private void GameSetup(){
        model.Setup();
        view.Setup();
    }
    public void SubmitGuess(){
        //if the text input is not empty and has 5 characters
        if(input != null){
            //Checks if the guess is valid
            if(model.IsValidGuess(input.text.ToString().ToUpper()) == true){
                Debug.Log("Word is in file");
                //Saves the value of input to userGuess;
                model.userGuess = input.ToString().ToUpper();
            }
            else{
                Debug.Log("Word is not found in our word list. #2");
            }
        }
        //FIXME: All Instances trigger this
        else{
            Debug.Log("Word is not found in our word list. #1");
        }
    }
    private void WinGame(){

    }
    private void LoseGame(){

    }

}
