using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExpController : MonoBehaviour
{
    public Image ExpFillImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ExpFillImage.fillAmount = PlayerPrefs.GetFloat("CurrentExp") / 10f;
    }
}
