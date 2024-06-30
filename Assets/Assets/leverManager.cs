using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverManager : MonoBehaviour
{
    public Question_and_answerScript questions;
   
    public bool isCloseToLever;
    public GameObject brickWall1;
    public GameObject brickWall2;
    bool questionStarted;
    public BoxCollider2D leverTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCloseToLever = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isCloseToLever = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(isCloseToLever && Input.GetKeyDown(KeyCode.Space)){
            questions.door = brickWall1;
            questions.door2 = brickWall2;
            questions.boxCollider = leverTrigger;
            questions.boxCollider.enabled = true;
            questions.StartQuestion();
            
        }
        

    }
    
}
