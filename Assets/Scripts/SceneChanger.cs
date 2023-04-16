using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public Button button;
    public int totalLevels = 3;
    private int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        // Storing the current scene index
        currentScene = SceneManager.GetActiveScene().buildIndex;
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        Debug.Log("Button Clicked\nMoving to Next Level");
        if(currentScene == totalLevels)
        {
            Debug.Log("Coming back to the Main Menu...\n");
            SceneManager.LoadScene(0);  
        } 
        else
        {
            SceneManager.LoadScene(currentScene + 1);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
