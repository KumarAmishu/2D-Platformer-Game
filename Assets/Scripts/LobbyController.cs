using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour

{
    public Button buttonplay;

    private void Awake()
    {
        buttonplay.onClick.AddListener(PlayGame);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

}
