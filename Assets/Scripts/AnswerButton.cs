using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnswerNormal()
    {
        SceneManager.LoadScene("Map");
    }

    public void AnswerAbNormal()
    {
        SceneManager.LoadScene("Map");
    }
}
