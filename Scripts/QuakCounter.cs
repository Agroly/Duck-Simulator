using UnityEngine;
using UnityEngine.UI;

public class QuackCounter : MonoBehaviour
{
    private static QuackCounter _instance;
    private int _quackCount = 0;

    [SerializeField] private Text quackText;

    public static QuackCounter Instance
    {
        get
        {
            if (_instance == null)
            {
             _instance = new GameObject("QuackCounter").AddComponent<QuackCounter>();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void IncrementQuackCount()
    {
        _quackCount++;
        UpdateQuackCountUI();
    }

    private void UpdateQuackCountUI()
    {
        if (quackText != null)
        {
            quackText.text = $"Кряков: {_quackCount}";
        }
    }
}
