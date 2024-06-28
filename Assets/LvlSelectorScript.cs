using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelectorScript : MonoBehaviour
{
    public GameObject lvl1btn;
    public GameObject lvl2btn;
    public GameObject lvl3btn;

    public void StartLevel1()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void StartLevel2()
    {
        SceneManager.LoadSceneAsync(3);
    }
    private void Start()
    {
        showLevel2();
        showLevel3();
    }

    public void showLevel2()
    {
        if (chest.lvl1Completed)
        {
            lvl2btn.SetActive(true);
            lvl1btn.SetActive(false);
        }
    }
    public void showLevel3()
    {

    }

}
