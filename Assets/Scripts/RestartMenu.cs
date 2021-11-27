using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartMenu : MonoBehaviour
{
    public Text score_text;
    
    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score: " + GameController.score;
    }
}
