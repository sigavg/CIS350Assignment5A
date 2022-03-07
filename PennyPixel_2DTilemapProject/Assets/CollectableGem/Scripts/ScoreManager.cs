/*Luke Lesimple
 * Assignment 5A
 * Displays score
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoredisplay;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoredisplay = GameObject.FindGameObjectWithTag("scoredisplay").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoredisplay.text = "Score: " + score;
    }
}
