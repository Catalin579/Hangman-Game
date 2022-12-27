using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public List<string> solvedList = new List<string>();
    public string[] unsolvedWord;

    public GameObject letterPrefab;
    List<TMP_Text> letterHolderList = new List<TMP_Text>();
    public Transform letterHolder;

    public Category[] categories;


    void Awake()
    {
        instance = this;
    }

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

    public void InputFromButton(string requestedLetter)
    {
        // CHECK IF THE GAME IS NOT OVER YET

        // SEARCH MECHANIC FOR SOLVED LIST
        CheckLetter(requestedLetter);
    }


    void CheckLetter(string requestedLetter)
    {
        bool letterFound = false;
        // FIND THE LETTER IN THE SOLVED LIST
        for (int i = 0; i < solvedList.Count; i++)
        {
            if (solvedList[i] == requestedLetter)
            {
                letterHolderList[i].text = requestedLetter;
                unsolvedWord[i] = requestedLetter;
                letterFound = true;
            }
        }

        if (!letterFound)
        {
            // MISTAKE STUFF - GRAPHIC REPRESENTATION


            // DO GAME OVER
        }

        // CHECK IF GAME WON
        Debug.Log("Game Won?: " + CheckIfWon());
    }

    bool CheckIfWon()
    {
        for (int i = 0; i < unsolvedWord.Length; i++)
        {
            if (unsolvedWord[i] != solvedList[i])
            {
                return false;
            }
        }

        return true;
    }
}
