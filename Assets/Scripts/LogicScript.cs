using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int p1score=0;
    public int p2score=0;
    public Text p1text;
    public Text p2text;
    public Ball Ball;
    public p2 player2;
    public p1 player1;
    public AudioSource goal;

    [ContextMenu("add p1 score")]
    public void addscore1()
    {
        p1score++;
        p1text.text = p1score.ToString();
        Ball.restart();
        player1.restart();
        player2.restart();
        goal.Play();
    }
    public void addscore2()
    {
        p2score++;
        p2text.text = p2score.ToString();
        Ball.restart();
        player1.restart();
        player2.restart();
        goal.Play();
    }

}

