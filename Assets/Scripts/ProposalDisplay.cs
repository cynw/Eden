using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProposalDisplay : MonoBehaviour
{

    public GameObject projectName;
    public GameObject projectSubname;
    public GameObject projectDescription;
    public GameObject displayBudget;
    public GameObject realBudget;
    private bool isFake;

    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public GameObject rightAnswerPanel;
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

    // Start is called before the first frame update
    void Start()
    {
        Proposal p = ProposalDataSource.getRandomProposal();
        int indexOfSpace = p.title.IndexOf(" ");
        string mainTitle = p.title.Substring(0, indexOfSpace);
        string subTitle = p.title.Substring(indexOfSpace, p.title.Length -indexOfSpace- 1);
        projectName.GetComponent<Text>().text = mainTitle;
        projectSubname.GetComponent<Text>().text = subTitle;
        projectDescription.GetComponent<Text>().text = p.description;
        realBudget.GetComponent<Text>().text = formatBudget(p.budget);
        isFake = true;
        float displayBuget = p.budget;
        if (isFake)
        {
            displayBuget = p.budget * 3;
        }
        
        displayBudget.GetComponent<Text>().text = formatBudget(displayBuget);
        
    }

    public void AnswerNormal()
    {
        if (isFake)
        {
            wrongAnswerPanel.SetActive(true);
        }
        else
        {
            rightAnswerPanel.SetActive(true);
            PlayerPrefs.SetFloat("CurrentExp", 0);
        }
    }

    public void AnswerAbNormal()
    {
        if (isFake)
        {
            rightAnswerPanel.SetActive(true);
            PlayerPrefs.SetFloat("CurrentExp", 0);
        }
        else
        {
            wrongAnswerPanel.SetActive(true);
        }
    }

    public void Close()
    {
        StartCoroutine(FadeCo());
    }

    private string formatBudget(float budget)
    {
        if (Mathf.Log10(budget) > 6)
        {
            return Mathf.Floor(budget / 1000000) + " ล้านบาท";
        }
        else
        {
            return budget + " บาท";
        }
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
