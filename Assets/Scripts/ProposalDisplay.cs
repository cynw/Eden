using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProposalDisplay : MonoBehaviour
{
    private bool isFake;

    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public GameObject rightAnswerInBasicPanel;
    public GameObject wrongAnswerInBasicPanel;
    public GameObject rightAnswerInComaprePanel;
    public GameObject wrongAnswerInComparePanel;
    public GameObject selectProposalPanel;
    public GameObject comparePanel;
    public float fadeWait;

    private void Awake()
    {
        if (fadeInPanel != null)
        {
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity);
            Destroy(panel, 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isFake = true;
    }

    public void AnswerNormal()
    {
        Debug.Log("AnswerNormal");
        if (isFake)
        {
            wrongAnswerInBasicPanel.SetActive(true);
            wrongAnswerInComparePanel.SetActive(true);
        }
        else
        {
            rightAnswerInBasicPanel.SetActive(true);
            rightAnswerInComaprePanel.SetActive(true);
            PlayerPrefs.SetFloat("CurrentExp", 0);
            PlayerPrefs.SetInt("LevelUp", 1);
        }
    }

    public void AnswerAbNormal()
    {
        Debug.Log("AnswerAbNormal");
        if (isFake)
        {
            rightAnswerInBasicPanel.SetActive(true);
            rightAnswerInComaprePanel.SetActive(true);
            PlayerPrefs.SetFloat("CurrentExp", 0);
            PlayerPrefs.SetInt("LevelUp", 1);
        }
        else
        {
            wrongAnswerInBasicPanel.SetActive(true);
            wrongAnswerInComparePanel.SetActive(true);
        }
    }

    public void CompareStats()
    {
        Debug.Log("CompareStats");
        comparePanel.SetActive(false);
        selectProposalPanel.SetActive(true);
    }

    public void BackToProposal()
    {
        Debug.Log("BackToProposal");
        comparePanel.SetActive(false);
        selectProposalPanel.SetActive(false);
    }

    public void CompareProposal()
    {
        Debug.Log("CompareProposal");
        comparePanel.SetActive(true);
        selectProposalPanel.SetActive(false);
    }

    public void Close()
    {
        StartCoroutine(FadeCo());
    }

    private IEnumerator FadeCo()
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
