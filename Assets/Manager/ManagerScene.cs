using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public static ManagerScene Instance { get; private set; }

    [SerializeField]
    private Animator sceneAnimation;

    [SerializeField]
    float timeToWait;
    [SerializeField]
    private int sceneNumber;

    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            sceneAnimation = GetComponentInChildren<Animator>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadSceneManager()
    {
        sceneNumber = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(LoadNextScene(sceneNumber));
    }

    public void BackSceneManager()
    {
        sceneNumber = SceneManager.GetActiveScene().buildIndex - 1;
        StartCoroutine(LoadNextScene(sceneNumber));
    }

    public void ReloadSceneManager()
    {
      // reloadScene = SceneManager.GetActiveScene().name;
        StartCoroutine(ReloadScene(SceneManager.GetActiveScene().name));
    }


    public IEnumerator LoadNextScene(int scene)
    {
        sceneAnimation.SetTrigger("fadeOut");
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(scene);
    }

    public IEnumerator ReloadScene(string scene)
    {
        sceneAnimation.SetTrigger("fadeOut");
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(scene);
    }

    
}
