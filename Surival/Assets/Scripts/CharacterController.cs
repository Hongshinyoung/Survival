using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static CharacterController _instance;
    public static CharacterController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("CharactetController").AddComponent<CharacterController>();
            }
            return _instance;
        }
    }

    private Player _player;
    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }


    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != null)
        {
            Destroy(gameObject);
        }
    }
}
