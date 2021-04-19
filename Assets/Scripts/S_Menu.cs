using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Map_Menu");
    }

    public void ToSelect()
    {
        SceneManager.LoadScene("Map_Select");
    }

    public void ToGameE()
    {
        SceneManager.LoadScene("Map_Game_E");
    }

    public void ToGameN()
    {
        SceneManager.LoadScene("Map_Game_N");
    }

    public void ToGameH()
    {
        SceneManager.LoadScene("Map_Game_H");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
