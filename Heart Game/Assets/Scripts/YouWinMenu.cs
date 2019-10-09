using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWinMenu : MonoBehaviour
{
    public static YouWinMenu Instance;
    public GameObject container;
    public Button nextLevelButton;
    public Button dismissButton;

    //Reserved function for checkbox when turned on
    private void OnEnable()
    {
        //This assigns a listener to the previously created button, passing the HandleNextLevel function (as the 'function' of it)
        nextLevelButton.onClick.AddListener(HandleNextLevelPressed);
        dismissButton.onClick.AddListener(Hide);
    }

    //Reserved function for checkbox when turned off
    //Allows for memory saving by disabling the listener (which constantly listens for input)
    private void OnDisable()
    {
        //This disassociates the listener from the button
        nextLevelButton.onClick.RemoveListener(HandleNextLevelPressed);
        dismissButton.onClick.RemoveListener(Hide);
    }

    private void HandleNextLevelPressed()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        //Instruction to load scene of nextSceneIndex, which ^ attributes to current + 1
        SceneManager.LoadScene(nextSceneIndex);
    }

    private void Awake()
    {
        //This statement assigns itself to the created Instance
        Instance = this;
    }

    public void Show()
    {
        container.SetActive(true);
    }

    public void Hide()
    {
        container.SetActive(false);
    }
}
