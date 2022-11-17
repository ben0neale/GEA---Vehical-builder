using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject MainCam;
    [SerializeField] GameObject CarCam;
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

        if (gameState == GameState.Build)
        {
            CarCam.SetActive(false);
            MainCam.SetActive(true);
        }

        if (gameState == GameState.play)
        {
            MainCam.SetActive(false);
            CarCam.SetActive(true);
        }
    }
}
