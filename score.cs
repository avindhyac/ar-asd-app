using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static score instance;
    public int Score = 0;
    public Text scoreBox;

    private void Awake() 
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        scoreBox.text = Score.ToString();
    }

    public void AddScore() 
    {
        Score += 10;
    }
}
