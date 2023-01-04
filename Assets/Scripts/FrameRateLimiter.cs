using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateLimiter : MonoBehaviour{

    #region Public Variables
    [Header("FPS Value")]
    [Tooltip("This is the FPS the game will be locked to.")]
    public int TargetFPS = 30;

    #endregion

    #region Private Variables
    #endregion

    // Start is called before the first frame update
    void Start(){
        //Locks FPS
        Application.targetFrameRate = TargetFPS;
    }

    // Update is called once per frame
    void Update(){
        
    }
}
