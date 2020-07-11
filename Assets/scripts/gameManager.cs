using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class gameManager
{
    static int score;
    static float time;

    public static int GetScore(){
        return score;
    }
    public static int SetScore(int value){
        return score += value;
    }
}
