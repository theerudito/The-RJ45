using UnityEngine;

public class Index : MonoBehaviour
{
    [SerializeField]
    private AudioClip _mainTheme;

    [SerializeField]
    private AudioClip _clickSound;

    private void Start()
    {
        ManagerSound.PlayTheme(_mainTheme);
    }

    public void PlayGame()
    {
       ManagerScene.Instance.LoadSceneManager();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayClick()
    {
        ManagerSound.PlaySound(_clickSound);
    }
}
