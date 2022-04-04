using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    public TextMeshPro playerLeftText;    
    public TextMeshPro playerRightText;
    // Start is called before the first frame update

    public GameState gameState;

    void Start() { 
    }

    void Update() {
       
    }

    void OnCollisionEnter2D(Collision2D col) {
        // Hit the left wall?
        if (col.gameObject.name == "Wall Left" && gameState.canScore()) {
            gameState.playerRightScore += 1;
            playerRightText.text = gameState.playerRightScore.ToString();
            gameState.setCanScore(false);
        }

        // Hit the right wall?
        if (col.gameObject.name == "Wall Right" && gameState.canScore()) {
            gameState.playerLeftScore += 1;
            playerLeftText.text = gameState.playerLeftScore.ToString();
            gameState.setCanScore(false);
        }
    }


}
