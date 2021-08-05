using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSubtitle : MonoBehaviour
{
    public Text subtitle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FirstCutScene());
    }

    IEnumerator FirstCutScene()
    {
        //todo: Speaker speaks to the person, can't move
        yield return new WaitForSeconds(2);
        subtitle.text = "Huh?";
        yield return new WaitForSeconds(4);
        subtitle.text = "What is this place?";
        yield return new WaitForSeconds(3);
        subtitle.text = "What's going on here!";
        yield return new WaitForSeconds(3);
        subtitle.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
