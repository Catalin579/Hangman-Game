using UnityEngine;

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
    }
}
