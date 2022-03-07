/*Luke Lesimple
 * Assignment 5A
 * Adds to score when gem collected
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{


    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.score++;

 
    }

}
