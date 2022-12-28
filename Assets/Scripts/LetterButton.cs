using UnityEngine;
using UnityEngine.UI;

public class LetterButton : MonoBehaviour
{
    string letter;

    public void SetButton(string _letter)
    {
        letter = _letter;
    }

    public void SendLetter()
    {
        Debug.Log("My letter is: " + letter);
        GameManager.instance.InputFromButton(letter);
        ButtonCreator.instance.RemoveLetter(this);
        GetComponent<Button>().interactable = false;
    }
}
