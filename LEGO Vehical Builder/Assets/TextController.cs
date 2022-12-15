using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ModeText;
    [SerializeField] GameController GameControllerRef;
    [SerializeField] TextMeshProUGUI controlsText;

    // Update is called once per frame
    void Update()
    {
        if (GameControllerRef.gameState == GameController.GameState.Build)
        {
            ModeText.text = "Mode: BUILD";
            controlsText.fontSize = 22;
        }
        else if (GameControllerRef.gameState == GameController.GameState.play)
        {
            ModeText.text = "Mode: PLAY";
            controlsText.fontSize = 0;
        }

    }
}
