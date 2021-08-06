using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerButton : MonoBehaviour
{

    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public GameObject wrongAnswerPanel;
    public float fadeWait;

    private void Awake()
    {
        if (fadeInPanel != null)
        {
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity);
            Destroy(panel, 1);
        }
    }

    public void AnswerNormal()
    {
        wrongAnswerPanel.SetActive(true);
    }

    public void AnswerAbNormal()
    {
        wrongAnswerPanel.SetActive(true);
    }

    public void Close()
    {
        StartCoroutine(FadeCo());
    }

    public IEnumerator FadeCo()
    {
        if (fadeOutPanel != null)
        {
            Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(fadeWait);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Map");
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
}
