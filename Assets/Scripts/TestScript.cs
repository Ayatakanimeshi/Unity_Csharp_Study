using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //??????????
    //??????????????????????

    void Start()
    {
        int scoreA = 100;
        int scoreB = 150;
        int scoreC = 170;
        int scoreD = 200;

        Debug.Log(SumScore(scoreA, scoreB));
        Debug.Log(SumScore(scoreA, scoreB, scoreC));
        Debug.Log(SumScore(scoreA, scoreB, scoreC, scoreD));
    }

    //???????????????
    int SumScore(int score1, int score2)
    {
        int totalScore;

        totalScore = score1 + score2;

        return totalScore;
    }

    //???????????????
    int SumScore(int score1, int score2, int score3)
    {
        int totalScore;

        totalScore = score1 + score2 + score3;

        return totalScore;
    }

    //???????????????
    int SumScore(int score1, int score2, int score3, int score4)
    {
        int totalScore;

        totalScore = score1 + score2 + score3 + score4;

        return totalScore;
    }
}
