using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ModeText;
    [SerializeField] GameController GameControllerRef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControllerRef.gameState == GameController.GameState.Build)
        {
            ModeText.text = "Mode: BUILD";
        }
        else if (GameControllerRef.gameState == GameController.GameState.play)
        {
            ModeText.text = "Mode: PLAY";
        }
    }
}
