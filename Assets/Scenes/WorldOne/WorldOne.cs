using UnityEngine;
using UnityEngine.UI;

public class WorldOne : MonoBehaviour
{
    [SerializeField]
    private AudioClip _mainTheme;

    [SerializeField]
    private AudioClip _clickSound;

    [SerializeField]
    private GameObject _btnPause;

    [SerializeField]
    private GameObject _btnBack;

    [SerializeField]
    private GameObject _objectPanelPause;

    [SerializeField]
    private GameObject _objectPlay;

    [SerializeField]
    private GameObject _objectPause;

    [SerializeField]
    private GameObject _btnLeft,
        _btnRight,
        _btnJump,
        _btnFire;

    void Start()
    {
        _objectPanelPause.SetActive(false);
        _objectPause.SetActive(false);

        ManagerSound.PlayTheme(_mainTheme);
    }

    public void PauseMusic()
    {
        if (ManagerSound.Instance.GetIsMusicPlaying())
        {
            ManagerSound.Instance.PauseMusic();
            _objectPlay.SetActive(false);
            _objectPause.SetActive(true);
        }
        else
        {
            ManagerSound.Instance.PlayMusic();
            _objectPlay.SetActive(true);
            _objectPause.SetActive(false);
        }
    }

    public void PlayClick()
    {
        ManagerSound.PlaySound(_clickSound);
    }

    public void OpenPanel()
    {
        _objectPanelPause.SetActive(true);
        _btnPause.SetActive(false);
        _btnBack.SetActive(false);
        _btnLeft.SetActive(false);
        _btnRight.SetActive(false);
        _btnJump.SetActive(false);
        _btnFire.SetActive(false);
    }

    public void ClosePanel()
    {
        _objectPanelPause.SetActive(false);
        _btnPause.SetActive(true);
        _btnBack.SetActive(true);
        _btnLeft.SetActive(true);
        _btnRight.SetActive(true);
        _btnJump.SetActive(true);
        _btnFire.SetActive(true);
    }

    public void PrewScene()
    {
        ManagerScene.Instance.BackSceneManager();
    }

    public void OpenGitHub()
    {
        OpenUrl.MyUrl("https://github.com/theerudito");
    }
}
