using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public enum GameState {Build, play};
    public GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Build;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameState = GameState.play;
        }   
    }
}
