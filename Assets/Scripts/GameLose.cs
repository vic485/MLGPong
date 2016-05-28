using UnityEngine;

public class GameLose : MonoBehaviour
{
    GameManager gm;  // The game manager object
    public int playTo = 10; // The score the game is played to
    public string[] levels; // The levels that can be loaded when the game is lost

    void Awake()
    {
        gm = GetComponent<GameManager>();
    }

    void Update()
    {
        // If the game is lost
        if (gm.EnemyScore == playTo)
        {
            int randLvl = Random.Range(0, levels.Length);   // Chooses the level to load
            Application.LoadLevel(levels[randLvl]); // Loads the level
        }
    }
}