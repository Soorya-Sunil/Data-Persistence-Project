using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        DataManager.Instance.PlayerName = PlayerNameInput.text;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // Original code to quit unity player.
#endif
    }
}