using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreDeath : MonoBehaviour
{
    public Text txt;
    void Start()
    {
        txt.text = score_manager.Score.ToString();
    }


}
