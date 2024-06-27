using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QnA_Arrays : MonoBehaviour
{
    public static string[] Questions;
    public static string[,] Answers;
    public static string[] answersForThisQuestion;  
    private static int index;
    private static string question;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        assignQuestions();
        assignAnswers();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { Debug.Log(question); }
    }

    public static void assignQuestions()
    {
        Questions = new string[]{"Which term describes a company's ability to meet its short-term financial obligations?",
                                "What is the process of determining the value of a company called?"};
        System.Random random = new System.Random();
        index = random.Next(0,Questions.Length);
        question = Questions[index];
    }

    public static void assignAnswers()
    {
        Answers = new string[,]
        {
            {"Profit Margin", "Market Share", "Liquidity", "Brand Equity"},
            {"Auditing", "Valuation", "Budgeting", "Forecasting"}
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
