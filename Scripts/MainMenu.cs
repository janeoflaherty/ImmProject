using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
  
    public void StartGame()
    {
       // loading in the first level of the game 
        SceneManager.LoadScene("SharkEscapeL1"); 
    }

}
