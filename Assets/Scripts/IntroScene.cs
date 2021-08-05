using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public GameObject firstCam;
    public Text subtitle;
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("MainSceneBun");
        //firstCam.SetActive(false);
    }
    
    void Start()
    {
        StartCoroutine(FirstCutScene());
    }

    IEnumerator FirstCutScene()
    {
        //todo: Speaker speaks to the person, can't move
        subtitle.text = "Huh?";
        yield return new WaitForSeconds(4);
        subtitle.text = "What is this place?";
        yield return new WaitForSeconds(3);
        subtitle.text = "What's going on here!";
    }

}

/*ublic class IntroScene : MonoBehaviour
{
    public GameObject firstCam;
    public GameObject secondCam;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CamWakeup());
    }

    IEnumerator CamWakeup()
    {
        yield return new WaitForSeconds(6);
        secondCam.SetActive(true);
        firstCam.SetActive(false);
    }
    // Update is called once per frame
    *//*void Update()
    {
        
    }*//*
}*/
