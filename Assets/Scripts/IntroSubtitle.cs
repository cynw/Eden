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
        subtitle.text = "ห้ะ";
        yield return new WaitForSeconds(2);
        subtitle.text = "";
        yield return new WaitForSeconds(2);
        subtitle.text = "ที่นี่ที่ไหน?";
        yield return new WaitForSeconds(3);
        subtitle.text = "เกิดอะไรขึ้นเนี่ย!";
        yield return new WaitForSeconds(3);
        subtitle.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
