using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    public Text score_text;

    private void Update()
    {
        score_text.text = "Score: " + GameController.score;
    }
}
