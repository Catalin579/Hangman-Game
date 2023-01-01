using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonCreator : MonoBehaviour
{
    public static ButtonCreator instance;
    public GameObject buttonPrefab;
    string[] lettersToUse = new string[26]
    {
        "A", "B", "C", "D", "E", "F",
        "G", "H", "I", "J", "K", "L",
        "M", "N", "O", "P", "Q", "R",
        "S", "T", "U", "V", "W", "X",
        "Y", "Z"
    };
    public Transform buttonHolder;

    List<LetterButton> letterList = new List<LetterButton>();

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        PopulateKeyboard();
    }

    void PopulateKeyboard()
    {
        for (int i = 0; i < lettersToUse.Length; i++)
        {
            GameObject newButton = Instantiate(buttonPrefab, buttonHolder, false);
            newButton.GetComponentInChildren<TMP_Text>().text = lettersToUse[i];
            LetterButton myLetter = newButton.GetComponent<LetterButton>();
            myLetter.SetButton(lettersToUse[i]);

            letterList.Add(myLetter);
        }
    }

    public void RemoveLetter(LetterButton theButton)
    {
        letterList.Remove(theButton);
    }

    public void UseHint()
    {
        if (GameManager.instance.GameOver() || GameManager.instance.maxHints <= 0)
        {
            Debug.Log("No Hints Left!");
            return;
        }
        GameManager.instance.maxHints -= 1;
        int randomIndex = Random.Range(0, letterList.Count);
        letterList[randomIndex].SendLetter(true);
    }
}
