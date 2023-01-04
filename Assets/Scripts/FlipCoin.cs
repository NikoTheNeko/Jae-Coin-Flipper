using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCoin : MonoBehaviour{

    #region Public Variables
    #endregion

    #region Private Variables
    #endregion

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    /**
        RNG funny guy that generates a 1 or a 0
        0 = (no) Head(?)
        1 = (under) Tails
    **/
    public int FlipACoin(){
        //Literally all it does
        //Generate a number from 0 to 1
        //If it's below .5, then head
        //if it above then tail
        if(Random.Range(0,1) <= 0.5f){
            return 0;
        } else {
            return 1;
        }
        
    }
}
