using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameState", order = 1)]
public class GameState : ScriptableObject
{
    public int playerLeftScore;
    public int playerRightScore;

    public bool passDivider;

    // Start is called before the first frame update
    public void OnEnable()
    {
        playerLeftScore = 0;
        playerRightScore = 0;
        passDivider = false;
    }

    public void setCanScore(bool canScore) {
        passDivider = !canScore;
    }

    public bool canScore() {
        return !passDivider;
    }
}
