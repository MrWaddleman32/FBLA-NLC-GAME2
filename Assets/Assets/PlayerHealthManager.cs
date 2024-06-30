using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3; 
    public int currentHealth; 

    public Image[] heartImages; 

    void Start()
    {
        currentHealth = maxHealth; 
        UpdateUI(); 
    }

    void UpdateUI()
    {
        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < currentHealth)
                heartImages[i].enabled = true; 
            else
                heartImages[i].enabled = false; 
        }
    }

    public void DecreaseHealth()
    {
        currentHealth--; 
        UpdateUI(); 

        if (currentHealth <= 0)
        {
            // Handle game over or any other logic when health reaches zero
            Debug.Log("Game Over");
            SceneManager.LoadScene(5);
            // You can add more logic here like resetting the game or showing a game over screen.
        }
    }
}