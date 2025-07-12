using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dice : MonoBehaviour
{
    public RectTransform die_1;
    public RectTransform die_2;

    [Header("The sprites")]
    public List<GameObject> faces = new List<GameObject>();
    public float rollTime = 5f;
    public float changeRatePerSecond = 10f;
    public float velocityMultiplier = 10f;
    public float angularMultiplier = 10f;

    Vector2 init_pos1;
    Vector2 init_pos2;
    public Button dice;

    public Button button_1;
    public Button button_2;
    
    public TMP_Text select1;
    public TMP_Text select2;

    public Ludo ludo;

    [Header("The buttons")]
    public float initButtonY;
    public float finalButtonY;
    public AnimationCurve curve;
    public float buttonDuration = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        init_pos1 = die_1.anchoredPosition;
        init_pos2 = die_2.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool rolling = false;
    float start = 0f;
    float changeFace = 0f;

    float vM;
    float aM;
    
    public void RollDice() {
        if (rolling == false) {
            dice.interactable = false;
            button_1.interactable = false;
            button_2.interactable = false;
            vM = velocityMultiplier;
            aM = angularMultiplier;
            start = 0;
            rolling = true;

            int x = Random.Range(1, 7);
            int y = Random.Range(1, 7);
            StartCoroutine(IRollDice(x, y));
        }
    }

    IEnumerator IRollDice(int x, int y) {
        Vector2 vect1 = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        Vector2 vect2 = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        float rotate1 = Random.Range(-1f, 1f);
        float rotate2 = Random.Range(-1f, 1f);

        int rand1 = 0;
        int rand2 = 0;
        
        while (rolling == true) {
            start += Time.deltaTime;
            changeFace += Time.deltaTime;

            if (rollTime-start-1f>0) {
                vM = ((rollTime-start-1f)/rollTime)*velocityMultiplier;
                aM = ((rollTime-start-1f)/rollTime)*angularMultiplier;
                if (changeFace >= 1/changeRatePerSecond) {
                    rand1 = Random.Range(1, 6);
                    rand2 = Random.Range(1, 6);
                    changeFace = 0f;
                }
            } else {
                rand1 = x;
                rand2 = y;
                vM = 0f;
                aM = 0f;
            }

            die_1.anchoredPosition += vect1 * vM * Time.deltaTime;
            die_2.anchoredPosition += vect2 * vM * Time.deltaTime;

            die_1.Rotate(0f, 0f, (aM * rotate1 * Time.deltaTime));
            die_2.Rotate(0f, 0f, (aM * rotate2 * Time.deltaTime));

            for (int i = 0; i < die_1.GetChild(0).childCount; i++) {
                die_1.GetChild(0).GetChild(i).gameObject.SetActive((i+1 == rand1) ? true : false);
            }
            for (int i = 0; i < die_2.GetChild(0).childCount; i++) {
                die_2.GetChild(0).GetChild(i).gameObject.SetActive((i+1 == rand2) ? true : false);
            }

            if (start > rollTime) {
                die_1.anchoredPosition = init_pos1;
                die_2.anchoredPosition = init_pos2;

                die_1.localRotation = Quaternion.Euler(0f, 0f, 0f);
                die_2.localRotation = Quaternion.Euler(0f, 0f, 0f);

                select1.text = rand1.ToString();
                select2.text = rand2.ToString();

                button_1.gameObject.GetComponent<LudoTokenData>().value = rand1;
                button_2.gameObject.GetComponent<LudoTokenData>().value = rand2;

                ludo.diceValues.Add(rand1);
                ludo.diceValues.Add(rand2);

                ludo.diceRolled = true;

                start = 0;
                StartCoroutine(IRevealNumbers());

                rolling = false;
            }

            yield return null;
        }
        yield return null;
    }

    IEnumerator IRevealNumbers() {

        while (start < buttonDuration) {
            start += Time.deltaTime;
            float pos = Mathf.Lerp(initButtonY, finalButtonY, curve.Evaluate(start/buttonDuration));
            Debug.Log(start);

            RectTransform b1 = button_1.gameObject.GetComponent<RectTransform>();
            RectTransform b2 = button_2.gameObject.GetComponent<RectTransform>();

            b1.anchoredPosition = new Vector2(b1.anchoredPosition.x, pos);
            b2.anchoredPosition = new Vector2(b2.anchoredPosition.x, pos);

        }

        if (start > buttonDuration) {

        }
        yield return null;
    }
}
