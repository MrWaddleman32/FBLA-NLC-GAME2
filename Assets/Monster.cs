using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public DialogueTrigger trigger;
    public Question_and_answerScript question;
    public BoxCollider2D dialogueStarter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            trigger.StartDialogue();
            dialogueStarter.enabled = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (question != null)
        {
            question.numOfQuestion = 2;
            question.StartQuestion();
        }
    }


}
