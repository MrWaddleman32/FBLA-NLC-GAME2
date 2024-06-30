using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public TextMeshProUGUI instructionText;
    public PlayerController controller;
    public GameObject confirmQuitPanel;
    public GameObject optionsPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!DialogueManager.isActive && controller.canMove)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                optionsPanel.SetActive(true);
            }
        }
    }

    public IEnumerator clearInstructionText()
    {
        yield return new WaitForSeconds(3);
        instructionText.text = string.Empty;
    }

    public void QuitBTNClicked()
    {
        confirmQuitPanel.SetActive(true);
    }


    public void IfNoClicked()
    {
        confirmQuitPanel.SetActive(false);
    }

    public void ifYesClicked()
    {
        SceneManager.LoadScene(0);
    }
    public void ifBackClicked()
    {
        optionsPanel.SetActive(false);
    }

}
