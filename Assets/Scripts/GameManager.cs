using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<string> solvedList = new List<string>();
    public string[] unsolvedWord;

    public GameObject letterPrefab;
    List<TMP_Text> letterHolderList = new List<TMP_Text>();
    public Transform letterHolder;

    public Category[] categories;


    void Start()
    {
        Initialize();
    }

    void Update()
    {

    }

    void Initialize()
    {
        //PICK A CATEGORY FIRST
        int cIndex = Random.Range(0, categories.Length);
        int wIndex = Random.Range(0, categories[cIndex].wordList.Length);

        //PICK A WORD FROM LIST OR CATEGORY
        string pickedWord = categories[cIndex].wordList[wIndex];

        //SPLIT THE WORD INTO SINGLE LETTERS
        string[] splittedWord = pickedWord.Select(l => l.ToString()).ToArray();
        unsolvedWord = new string[splittedWord.Length];
        foreach (string letter in splittedWord)
        {
            solvedList.Add(letter);
        }

        //CREATE THE VISUAL
        for (int i = 0; i < solvedList.Count; i++)
        {
            GameObject tempLetter = Instantiate(letterPrefab, letterHolder, false);
            letterHolderList.Add(tempLetter.GetComponent<TMP_Text>());
        }
    }

    void CheckLetter(string requestedLetter)
    {

    }

    public void InputFromButton(string requestedLetter)
    {

    }

    bool CheckIfWon()
    {
        return true;
    }
}
