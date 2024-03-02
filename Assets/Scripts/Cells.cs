using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Cells : MonoBehaviour{
    private TMP_Text userInput;
    private char letter;
    public Color color;
    [SerializeField] int row;
    [SerializeField] int col;

    public int[,] gridPlace;

    // Start is called before the first frame update
    private void Start(){
        userInput = gameObject.GetComponent<TMP_Text>();
        gridPlace = new int[row, col];
        Setup();
    }

    public void changeSpace(int r, int c, char letter){
        row = r;
        col = c;
        this.letter = letter;

        userInput.text = letter.ToString();
    }

    public void Setup(){
        letter = '_';
        userInput.text = letter.ToString();
    }

}
