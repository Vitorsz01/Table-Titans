using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public int scorePlayerRight;
    public int scorePlayerLeft;
    public GUIStyle style;
    // Start is called before the first frame update
    void OnGUI()
    {
        float x = Screen.width/2f;
        float y = 30f;
        float width = 300f;
        float heigth = 20f;
        string text = scorePlayerLeft + " | " + scorePlayerRight;
        GUI.Label(new Rect(x-(width/2f), y, width, heigth), text, style);
    }

}
