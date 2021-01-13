using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score_manager : MonoBehaviour
{
    public static int Score = 0;
    public Text txtscore;
   
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Score);
        txtscore.text ="Score : "+Score.ToString();
        
    }
}
