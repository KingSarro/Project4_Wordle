using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordleView : MonoBehaviour{
    Cells cells;
    [SerializeField] GameObject[] rows;

    public void Setup(){
        cells.Setup();
    }
    private void UpdateView(){
        
    }

}
