using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ludo : MonoBehaviour
{
    public List<PlayerInfo> players = new List<PlayerInfo>();
    public string playerTurn;
    public int totalTurns = 0;

    public List<int> diceValues = new List<int>();
    public int selectedValue;

    public bool diceRolled = false;
    public bool allTokensMoved = false;

    public TMP_Text turnDisplay;
    public Dice dice;

    public Image player1_color;
    public Image player2_color;

    public TMP_Text player1_text;
    public TMP_Text player2_text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerTurn = players[totalTurns%players.Count].player;
        turnDisplay.text = "It's " + playerTurn + "'s turn";
        if (diceRolled && allTokensMoved) {
            totalTurns++;
            dice.dice.interactable = true;
            dice.button_1.interactable = false;
            dice.button_2.interactable = false;
            diceRolled = false;
            allTokensMoved = false;
        }

        if (diceRolled && !allTokensMoved) {
            dice.button_1.interactable = true;
            dice.button_2.interactable = true;
            List<LudoPiece> lp = players.First(p => p.player == playerTurn).piece;
            if (lp.All(piece => piece.steps == 0) && diceValues.All(s => s != 6)) {
                diceValues.Clear();
            }

            allTokensMoved = (diceValues.Count == 0) ? true : false;
        }

        player1_color.color = players[0].actualColor;
        player2_color.color = players[1].actualColor;

        player1_text.text = players[0].player;
        player2_text.text = players[1].player;

    }
}

[System.Serializable]
public class PlayerInfo
{
    public string player;
    public string color;
    public Color actualColor;
    public List<LudoPiece> piece = new List<LudoPiece>();
}
