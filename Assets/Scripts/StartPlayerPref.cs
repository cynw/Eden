using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayerPref : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Map", 0);
        PlayerPrefs.SetFloat("CurrentExp", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
