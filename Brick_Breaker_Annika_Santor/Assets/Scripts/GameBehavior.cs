using UnityEngine;
using TMPro;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior Instance;

    private Utilities.GameState _gameMode;

    public Utilities.GameState GameMode
    {
        get => _gameMode;

        set
        {
            _gameMode = value;
            _pauseUI.enabled = GameMode != Utilities.GameState.Play;
        }
    }
    
    [SerializeField] private GameObject _ballPrefab;

    [SerializeField] private TMP_Text _pauseUI;

    [SerializeField] private TMP_Text _scoreUI;
    
    private int _score;
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    private void Start()
    {
        
        GameMode = Utilities.GameState.Play;

        _score = 0;
        
        Serve();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameMode = GameMode == Utilities.GameState.Play ? Utilities.GameState.Pause : Utilities.GameState.Play;
        }
    }
    
    private void Serve()
    {
        Instantiate(_ballPrefab, Vector3.zero, Quaternion.identity);
    }
    

    public int Score
    {
        get  => _score;
        
        set
        {
            _score = value;
            _scoreUI.text = Score.ToString();
        }
    }

    public void Scored()
    {
        _score++;
        _scoreUI.text = Score.ToString();
    }
    
    public void Restart()
    {
        Invoke(nameof(Serve), 2.0f);
    }
}
