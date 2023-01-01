using UnityEngine;
using UnityEngine.UI;

public class LetterButton : MonoBehaviour
{
    string letter;

    public void SetButton(string _letter)
    {
        letter = _letter;
    }

    public void SendLetter(bool isThatAHint) // BUTTON INPUT OR HINT
    {
        Debug.Log("My letter is: " + letter);
        GameManager.instance.InputFromButton(letter, isThatAHint);
        ButtonCreator.instance.RemoveLetter(this);
        GetComponent<Button>().interactable = false;
    }
}
