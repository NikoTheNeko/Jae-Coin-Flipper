using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using ModularMotion;



public class ChangeText : MonoBehaviour{

    #region Public Variables

    public UIMotion UIController;

    public TMP_Text ResultsText;

    public Animator CoinAnimations;

    #endregion

    #region Private Variables
    private bool HasFlipped = false;
    #endregion

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

    }

    public void ChangeResultsText(){
        //Checks if the coin was flipped (this is so we can avoid the text changing when you undo)
        //if(!HasFlipped){
            
            //Flips a coin, then changes the text
            if(FlipACoin() == 0){
                ResultsText.text = "Heads";
                CoinAnimations.SetInteger("CoinValue", 0);
            } else {
                ResultsText.text = "Tails";
                CoinAnimations.SetInteger("CoinValue", 1);
            }

        StartCoroutine(HoldForAnimations());

        //}

        //Sets has flipped to it's opposite
        HasFlipped = !HasFlipped;
    }


    /**
        RNG funny guy that generates a 1 or a 0
        0 = (no) Head(?)
        1 = (under) Tails
    **/
    private int FlipACoin(){
        //Literally all it does
        //Generate a number from 0 to 1
        //If it's below .5, then head
        //if it above then tail
        float CoinNumber = UnityEngine.Random.Range(0,2);
        return (int)CoinNumber;
        
    }

    #region Coroutines

    IEnumerator HoldForAnimations(){
        yield return new WaitForSeconds(1);
        CoinAnimations.SetInteger("CoinValue", 2);
    }

    #endregion
}
