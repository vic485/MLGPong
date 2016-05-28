using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static int playerScore1 = 0;    // Player 1's score
    static int playerScore2 = 0;    // Player 2's score
    public int EnemyScore = 0;  // Score clone for single player game

    public Text playerScore1Text;   // Text to display p1 score
    public Text playerScore2Text;   // Text to display p2 score
    public GameObject ScoreSounds;  // Object to play sounds on score

    private ScoreTexts sT;  // Manager of the texts displayed on score
    private ScoreImages sI; // Manager of the images displayed on score
    private ComboText cT;   // Manager of the combo texts
    private int p1Combo = 0;    // size of current combo for p1
    private int p2Combo = 0;    // size of current combo for p2

    void Awake()
    {
        // Assign private variables
        sT = this.gameObject.GetComponent<ScoreTexts>();
        sI = this.gameObject.GetComponent<ScoreImages>();
        cT = this.gameObject.GetComponent<ComboText>();
    }

    // this is called when a player scores
    public void Score(string wallName)
    {
        sT.Display();
        sI.Spawn();
        Instantiate(ScoreSounds);
        if (wallName == "WallRight")
        {
            playerScore1++;
            p1Combo++;
            p2Combo = 0;
        }
        else
        {
            playerScore2++;
            p2Combo++;
            p1Combo = 0;
        }
        UpdateScore();
        if (p1Combo == 3 || p2Combo == 3)   // Starts the combos if conditions are met
            cT.StartCombo(3);
        else if (p1Combo == 5 || p2Combo == 5)
            cT.StartCombo(5);
        else if (p1Combo == 10 || p2Combo == 10)
            cT.StartCombo(10);
    }

    // Updates the texts with current score
    void UpdateScore()
    {
        EnemyScore = playerScore2;
        playerScore1Text.text = "" + playerScore1;
        playerScore2Text.text = "" + playerScore2;
    }

    // Resets the game. May be removed in the future
    public void Reset()
    {
        playerScore1 = 0;
        playerScore2 = 0;
        UpdateScore();
    }
}