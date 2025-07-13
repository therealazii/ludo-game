using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ludo : MonoBehaviour
{
    public List<PlayerInfo> players = new List<PlayerInfo>();
    public List<LudoPiece> allPiece = new List<LudoPiece>();
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

    public Image gradient;

    public List<Color> sColors = new List<Color>();

    public GameObject winner_board;
    public TMP_Text winner_text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerTurn = players[totalTurns%players.Count].player;
        turnDisplay.text = "It's " + playerTurn + "'s turn";
        Color gradientColor = players[totalTurns%players.Count].actualColor;
        gradient.color = new Color(gradientColor.r, gradientColor.g, gradientColor.b, 0.15f);
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
            bool availablePieces = lp.All(piece => (piece.steps == 0 || piece.steps >= 57));
            if (lp.All(piece => (piece.steps == 0 || piece.steps >= 57)) && diceValues.All(s => s != 6)) {
                diceValues.Clear();
            }

            allTokensMoved = (diceValues.Count == 0) ? true : false;
        }

        player1_color.color = players[0].actualColor;
        player2_color.color = players[1].actualColor;

        player1_text.text = players[0].player;
        player2_text.text = players[1].player;

        LudoTokenData b1 = dice.button_1.gameObject.GetComponent<LudoTokenData>();
        LudoTokenData b2 = dice.button_2.gameObject.GetComponent<LudoTokenData>();

        if (diceRolled && !allTokensMoved) {
            if (selectedValue == 0) {
                if (diceValues.Count == 1) {
                    if (b1.value == diceValues[0]) {
                        Image img = b1.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img.color = sColors[1];

                        Image img2 = b2.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img2.color = sColors[0];
                    } else if (b2.value == diceValues[0]) {
                        Image img = b1.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img.color = sColors[0];

                        Image img2 = b2.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img2.color = sColors[1];
                    }
                } else if (diceValues.IndexOf(6) >= 0) {
                    if (b1.value == 6) {
                        Image img = b1.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img.color = sColors[1];

                        Image img2 = b2.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img2.color = sColors[0];
                    } else if (b2.value == 6) {
                        Image img = b1.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img.color = sColors[0];

                        Image img2 = b2.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img2.color = sColors[1];
                    }
                }
            } else {
                if (diceValues.IndexOf(selectedValue) >= 0) {
                    if (b1.value == selectedValue) {
                        Image img = b1.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img.color = sColors[1];

                        Image img2 = b2.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img2.color = sColors[0];
                    } else if (b2.value == selectedValue) {
                        Image img = b1.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img.color = sColors[0];

                        Image img2 = b2.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
                        img2.color = sColors[1];
                    }
                }
            }
        } else {
            Image img = b1.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
            img.color = sColors[0];

            Image img2 = b2.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
            img2.color = sColors[0];
        }

        for (int i = 0; i < players.Count; i++) {
            if (players[i].piece.All(piece => (piece.steps >= 57))) {
                winner_board.SetActive(true);
                winner_text.text = players[i].player + " is the winner!";
            }
        }
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
