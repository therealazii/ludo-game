using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LudoPiece : MonoBehaviour
{
    public string color;
    public int ordinal = 0;
    public int steps = 0;
    public Vector2Int position;
    public float diff;

    public Ludo ludo;
    public int selectedValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TMP_Text count = transform.GetChild(0).gameObject.GetComponent<TMP_Text>();
        int countInt = ludo.allPiece.Count(s => s.position == position);
        count.text = (countInt == 1) ? null : countInt.ToString();
        position = LudoTrack.pos(color, steps, ordinal);
        gameObject.GetComponent<Image>().color = LudoTrack.color(color);
        gameObject.GetComponent<RectTransform>().anchoredPosition = (Vector2)position * diff;
    }

    public void Play() {
        string currentColor = ludo.players.First(p => p.player == ludo.playerTurn).color;

        if (ludo.selectedValue == 0) {
            if (ludo.diceValues.Count == 1) {
                selectedValue = ludo.diceValues[0];
            } else if (ludo.diceValues.IndexOf(6) >= 0) {
                selectedValue = 6;
            }
        } else {
            selectedValue = ludo.selectedValue;
        }

        if (ludo.diceValues.IndexOf(selectedValue) >= 0 && currentColor == color) {

            if (steps == 0) {
                if (selectedValue == 6) {
                    steps = 1;
                    ludo.diceValues.Remove(selectedValue);
                    ludo.selectedValue = 0;
                }
            } else {
                steps += selectedValue;
                ludo.diceValues.Remove(selectedValue);
                ludo.selectedValue = 0;
            }

            foreach (LudoPiece obj in ludo.allPiece) {
                if (obj != this && obj.color != color) {
                    Vector2Int offense = LudoTrack.pos(color, steps, ordinal);
                    Vector2Int defence = LudoTrack.pos(obj.color, obj.steps, obj.ordinal);

                    if (defence == offense) {
                        obj.steps = 0;
                        steps = 57;
                    }
                }
            }
        }
    }
}
