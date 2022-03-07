/*Luke Lesimple
 * Assignment 5A
 * finish level trigger
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finishline : MonoBehaviour
{
    public Text wintext;

    private void Start()
    {
        wintext.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && ScoreManager.score == 10)
        {
            wintext.enabled = true;
        }
    }
}
