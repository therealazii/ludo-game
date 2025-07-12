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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = LudoTrack.pos(color, steps, ordinal);
        gameObject.GetComponent<Image>().color = LudoTrack.color(color);
        gameObject.GetComponent<RectTransform>().anchoredPosition = (Vector2)position * diff;
    }

    public void Play() {
        string currentColor = ludo.players.First(p => p.player == ludo.playerTurn).color;

        if (ludo.diceValues.IndexOf(ludo.selectedValue) >= 0 && currentColor == color) {
            if (steps == 0) {
                if (ludo.selectedValue == 6) {
                    steps = 1;
                    ludo.diceValues.Remove(ludo.selectedValue);
                }
            } else {
                steps += ludo.selectedValue;
                ludo.diceValues.Remove(ludo.selectedValue);
            }
        }
    }
}
