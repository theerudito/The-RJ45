using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private AudioClip _mainTheme;

    [SerializeField]
    private AudioClip _clickSound;

    [SerializeField]
    private GameObject _objectConfig;

    [SerializeField]
    private GameObject _objectPanelConfig;

    [SerializeField]
    private GameObject _objectPlay;

    [SerializeField]
    private GameObject _objectPause;

    private void Start()
    {
        _objectPanelConfig.SetActive(false);
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
        _objectPanelConfig.SetActive(true);
        _objectConfig.SetActive(false);
    }

    public void ClosePanel()
    {
        _objectPanelConfig.SetActive(false);
        _objectConfig.SetActive(true);
    }


    public void WorldOne()
    {
        ManagerScene.Instance.LoadSceneManager();
    }
}
