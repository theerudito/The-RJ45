using UnityEngine;

public class ManagerSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSourceMainTheme;

    [SerializeField]
    private AudioSource _audioSourceClick;

    [SerializeField]
    private bool isMusicPlaying;

    public static ManagerSound Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool GetIsMusicPlaying()
    {
        return isMusicPlaying;
    }

    public static void PlayTheme(AudioClip _mainTheme)
    {
        Instance._audioSourceMainTheme.clip = _mainTheme;
        Instance._audioSourceMainTheme.Play();
        Instance.isMusicPlaying = true;
    }

    public static void PlaySound(AudioClip _clickSound)
    {
        Instance._audioSourceClick.PlayOneShot(_clickSound);
    }

    public void PlayMusic()
    {
        _audioSourceMainTheme.UnPause();
        isMusicPlaying = true;
    }

    public void PauseMusic()
    {
        _audioSourceMainTheme.Pause();
        isMusicPlaying = false;
    }
}
