using TMPro;
using UnityEngine;

public class ButtonCreator : MonoBehaviour
{
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
            newButton.GetComponent<LetterButton>().SetButton(lettersToUse[i]);
        }
    }

}
