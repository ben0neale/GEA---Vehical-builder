using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject MainCam;
    [SerializeField] GameObject CarCam;
    [SerializeField] GameObject block;
    [SerializeField] GameObject wheel;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameState == GameState.Build)
            {
                gameState = GameState.play;
            }
            else if (gameState == GameState.play)
            {
                gameState = GameState.Build;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(block, new Vector3(0, 0, -2), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(wheel, new Vector3(0, 0, -2), Quaternion.Euler(0,0,90));
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
