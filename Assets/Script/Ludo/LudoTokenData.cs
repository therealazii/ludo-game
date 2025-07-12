using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LudoTokenData : MonoBehaviour
{
    public Ludo ludo;
    public int value;

    public void Select() {
        ludo.selectedValue = value;
        gameObject.GetComponent<Button>().interactable = false;
    }
}
