using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<string> openingDialogue;
    public List<string> choiceOneDialogue;
    public List<string> choiceTwoDialogue;


    int dialogueIndex = 0;
    int choiceOneIndex = 0;
    int choiceTwoIndex = 0;

    List<string> currentDialogue;
    List<string> currentChoiceOne;
    List<string> currentChoiceTwo;

    public GameObject choiceOne;
    public GameObject choiceTwo;

    public TMP_Text dialogueBox;
    public TMP_Text choiceOneText;
    public TMP_Text choiceTwoText;

    public string winningMessage;
    public string failingMessage;
    public string winningChoiceOne;
    public string failingChoiceOne;

    public string scenetoLoad;
    // Start is called before the first frame update
    void Start()
    {
        choiceTwo.SetActive(false);
        currentDialogue = openingDialogue;
        dialogueBox.text = currentDialogue[dialogueIndex];
        currentChoiceOne = choiceOneDialogue;
        choiceOneText.text = choiceOneDialogue[choiceOneIndex];
    }

    // Update is called once per frame
    public void advanceDialogueChoiceOne()
    {
        if (currentDialogue == openingDialogue && dialogueIndex == 0)
        {
            dialogueIndex++;
            choiceOneIndex++;
            setDialogueText();
            setChoiceOneText();
            setChoiceTwoText();
            choiceTwo.SetActive(true);
        }
        else if (choiceOneText.text == failingChoiceOne)
        {
            SceneManager.LoadScene(scenetoLoad);
        }
        else if (choiceOneText.text == winningChoiceOne)
        {
            SceneManager.LoadScene(scenetoLoad);
        }
        else if (currentDialogue == openingDialogue && dialogueIndex == 2)
        {
            dialogueIndex++;
            choiceOneIndex++;
            choiceTwoIndex++;
            setDialogueText();
            setChoiceOneText();
            choiceTwo.SetActive(false);
        }
        else if (currentDialogue == openingDialogue && dialogueIndex == 3)
        {
            dialogueIndex++;
            choiceOneIndex++;
            setDialogueText();
            setChoiceOneText();
            setChoiceTwoText();
            choiceTwo.SetActive(true);
        }
        else if (currentDialogue == openingDialogue && dialogueIndex == 4)
        {
            dialogueIndex++;
            choiceOneIndex++;
            choiceTwoIndex++;
            setDialogueText();
            setChoiceOneText();
            setChoiceTwoText();
            choiceTwo.SetActive(true);
        }
        else if (currentDialogue == openingDialogue && dialogueIndex == 5)
        {
            dialogueIndex++;
            choiceOneIndex++;
            setDialogueText();
            setChoiceOneText();
            setChoiceTwoText();
            choiceTwo.SetActive(false);
        }
        else if (currentDialogue == openingDialogue && dialogueIndex == 6)
        {
            dialogueBox.text = winningMessage;
            choiceOneText.text = winningChoiceOne;
            choiceTwo.SetActive(false);
        }
        else
        {
            dialogueIndex++;
            choiceOneIndex++;
            choiceTwoIndex++;
            setDialogueText();
            setChoiceOneText();
            setChoiceTwoText();
            choiceTwo.SetActive(false);
        }
    }

    public void advanceDialogueChoiceTwo()
    {
        if (choiceTwoIndex == 2)
        {
            dialogueBox.text = failingMessage;
            choiceOneText.text = failingChoiceOne;
            choiceTwo.SetActive(false);
        }
        else if (choiceTwoIndex == 3)
        {
            dialogueBox.text = failingMessage;
            choiceOneText.text = failingChoiceOne;
            choiceTwo.SetActive(false);
        }
        else
        {
            advanceDialogueChoiceOne();
        }
    }

    void setDialogueText()
    {
        dialogueBox.text = currentDialogue[dialogueIndex];
    }

    void setChoiceOneText()
    {
        choiceOneText.text = choiceOneDialogue[choiceOneIndex];
    }
    void setChoiceTwoText()
    {
        choiceTwoText.text = choiceTwoDialogue[choiceTwoIndex];
    }
    void setUpChoices()
    {

    }
}
