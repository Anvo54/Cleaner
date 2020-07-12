using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class gameManager
{
    static int rightScore;
    static int leftScore;

    public static int GetRightScore(){
        return rightScore;
    }
    public static int GetLeftScore(){
        return leftScore;
    }
    public static int SetRightScore(int value){
        return rightScore += value;
    }
    public static int SetLeftScore(int value){
        return leftScore += value;
    }
    public static int RemoveRightScore(){
        return rightScore--;
    }
    public static int RemoveLeftScore(){
        return leftScore--;
    }

}
