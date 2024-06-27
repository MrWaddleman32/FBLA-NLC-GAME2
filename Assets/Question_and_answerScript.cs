using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Question_and_answerScript : MonoBehaviour
{
    public static string[] Questions;
    public static string[,] Answers;
    public static string[] answersForThisQuestion = new string[4];
    private static int index;
    private static string question;
    public GameObject panel;
    System.Random random = new System.Random();
    int randomAnswerGen;
    int correctAnswerIndex;
    string correctAnswer;
    public Text questionText;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    public Text answer4;
    public PlayerHealth health;
    public PlayerController movementController;
    private GameObject clickedBTN;
    public GameObject trigger;
    public GameObject door;
    public GameObject door2;
    private Text BTNText;
    int questionNum = 1;
    public int numOfQuestion = 1;
    // Start is called before the first frame update
    public void Start()
    {
        assignQuestions();
        assignAnswers();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartQuestion();
        }
    }

    public void StartQuestion()
    {
        {
            panel.SetActive(true);
            movementController.canMove = false;
            movementController.movement = Vector2.zero;
        }
    }

    public void assignQuestions()
    {
        Questions = new string[]{"Which term describes a company's ability to meet its short-term financial obligations?",
                                "What is the process of determining the value of a company called?",
                                "What does SWOT analysis primarily assess?"};
        index = random.Next(0, Questions.Length);
        questionText.text = "In order to move on, you must answer this question: \n" + Questions[index];
    }

    public void assignAnswers()
    {
        Answers = new string[,]
        {
            {"Profit Margin", "Market Share", "Liquidity", "Brand Equity"},
            {"Auditing", "Valuation", "Budgeting", "Forecasting"},
            {"Market demand","Competitor pricing", "Internal strengths and weaknesses", "Consumer preferences"}
        };

        for (int i = 0; i < Answers.GetLength(1); i++)
        {
            answersForThisQuestion[i] = Answers[index,i];
            Debug.Log(answersForThisQuestion[i]);
        }
        randomAnswerGen = random.Next(1,4);
        if (index == 0)
        {
            correctAnswerIndex = 2;
/*            for (int i = 0;i < Answers.GetLength(0); i++)
            {

            }*/
            if (randomAnswerGen == 1)
            {
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer1.text = answersForThisQuestion[correctAnswerIndex];
                answer2.text = answersForThisQuestion[0];
                answer3.text = answersForThisQuestion[1];
                answer4.text = answersForThisQuestion[3];
            }
            if (randomAnswerGen == 2)
            {
                answer1.text = answersForThisQuestion[0];
                answer2.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer3.text = answersForThisQuestion[3]; 
                answer4.text = answersForThisQuestion[1];
            }
            if (randomAnswerGen == 3)
            {
                answer1.text = answersForThisQuestion[1]; 
                answer2.text = answersForThisQuestion[3]; 
                answer3.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer4.text = answersForThisQuestion[0];
            }
            if (randomAnswerGen == 4)
            {
                answer1.text = answersForThisQuestion[3]; 
                answer2.text = answersForThisQuestion[1];
                answer3.text = answersForThisQuestion[0]; 
                answer4.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
            }
        }
        else if (index == 1)
        {
            correctAnswerIndex = 1;
/*            for (int i = 0;i < Answers.GetLength(0); i++)
            {

            }*/
            if (randomAnswerGen == 1)
            {
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer1.text = answersForThisQuestion[correctAnswerIndex];
                answer2.text = answersForThisQuestion[0];
                answer3.text = answersForThisQuestion[2];
                answer4.text = answersForThisQuestion[3];
            }
            if (randomAnswerGen == 2)
            {
                answer1.text = answersForThisQuestion[0];
                answer2.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer3.text = answersForThisQuestion[3]; 
                answer4.text = answersForThisQuestion[2];
            }
            if (randomAnswerGen == 3)
            {
                answer1.text = answersForThisQuestion[2]; 
                answer2.text = answersForThisQuestion[3]; 
                answer3.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer4.text = answersForThisQuestion[0];
            }
            if (randomAnswerGen == 4)
            {
                answer1.text = answersForThisQuestion[3]; 
                answer2.text = answersForThisQuestion[2];
                answer3.text = answersForThisQuestion[0]; 
                answer4.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
            }
        }

        if (index == 2)
        {
            correctAnswerIndex = 2;
            if (randomAnswerGen == 1)
            {
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer1.text = answersForThisQuestion[correctAnswerIndex];
                answer2.text = answersForThisQuestion[0];
                answer3.text = answersForThisQuestion[1];
                answer4.text = answersForThisQuestion[3];
            }
            if (randomAnswerGen == 2)
            {
                answer1.text = answersForThisQuestion[0];
                answer2.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer3.text = answersForThisQuestion[3];
                answer4.text = answersForThisQuestion[1];
            }
            if (randomAnswerGen == 3)
            {
                answer1.text = answersForThisQuestion[1];
                answer2.text = answersForThisQuestion[3];
                answer3.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
                answer4.text = answersForThisQuestion[0];
            }
            if (randomAnswerGen == 4)
            {
                answer1.text = answersForThisQuestion[3];
                answer2.text = answersForThisQuestion[1];
                answer3.text = answersForThisQuestion[0];
                answer4.text = answersForThisQuestion[correctAnswerIndex];
                correctAnswer = answersForThisQuestion[correctAnswerIndex];
            }
        }
    }


    public void ClickedCorrectAnswer()
    {
        clickedBTN = EventSystem.current.currentSelectedGameObject;
        BTNText = clickedBTN.GetComponentInChildren<Text>();
        if (BTNText.text.Equals(correctAnswer))
        {
            questionText.text = "Correct, Nice Job!";
            StartCoroutine(ExitQuestionPanel());
        }
        else
        {
            questionText.text = "Wrong, try again";
            health.DecreaseHealth();
        }




    }

    IEnumerator ExitQuestionPanel()
    {
        if (questionNum < numOfQuestion)
        {
            yield return new WaitForSeconds(2);
            assignQuestions();
            assignAnswers();
            StartQuestion();
            questionNum++;
        }
        else
        {
            yield return new WaitForSeconds(2);
            panel.SetActive(false);
            movementController.startMoving();
            if (door != null)
            {
                door.SetActive(false);
                door2.SetActive(false);
            }
            trigger.SetActive(false);
            questionNum = 1;
            numOfQuestion = 1;
            Destroy(gameObject);
        }
    }


}
