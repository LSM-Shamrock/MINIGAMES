using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStrartButton : MonoBehaviour
{
    public GameType gameType;

    private Button _button;
    private Button Button
    {
        get
        {
            if (_button == null)
                _button = GetComponent<Button>();
            return _button;
        }
    }

    private Text _text;
    private Text Text
    {
        get
        {
            if (_text == null)
                _text = GetComponentInChildren<Text>();
            return _text;
        }
    }

    private void Awake()
    {
        Text.text = gameType.ToString();
        Button.onClick.RemoveAllListeners();
        Button.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        SceneManager.LoadScene($"{gameType}_Start");
    }
}
