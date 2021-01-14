using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score_manager : MonoBehaviour
{
    public static int Score ;
    public Text txtscore;
    void Start()
    {
        Score = 0;
    }
   
    // Update is called once per frame
    void Update()
    {
        txtscore.text ="Score : "+Score.ToString();
        
    }
}
