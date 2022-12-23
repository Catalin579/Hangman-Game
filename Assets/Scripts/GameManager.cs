using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<string> solvedList = new List<string>();
    public string[] unsolvedWord;

    public GameObject letterPrefab;
    public Transform letterHolder;

    void Start()
    {
        Initialize();
    }

    void Update()
    {

    }

    void Initialize()
    {

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
