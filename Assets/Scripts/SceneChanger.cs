using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public Button L1_button;
    public Button L2_button;
    public Button L3_button;
    public Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        /*L1_button= gameObject.GetComponent<Button>();
        L2_button= gameObject.GetComponent<Button>();
        L3_button= gameObject.GetComponent<Button>();*/

        // Storing the current scene index
        if(L1_button!=null) { L1_button.onClick.AddListener(LoadLevel1); }
        if (L2_button != null) { L2_button.onClick.AddListener(LoadLevel2); }
        if (L3_button != null) { L3_button.onClick.AddListener(LoadLevel3); }
        if (backButton != null) { backButton.onClick.AddListener(ReturnToMain); }
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }
    public void ReturnToMain()
    {
        SceneManager.LoadScene(0);
    }
}
