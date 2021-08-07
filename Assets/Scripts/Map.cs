using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class Map : MonoBehaviour
{
    public Text subtitle;
    public GameObject MainCamera;
    public GameObject FirstCamera;
    public GameObject Timeline;
    public PlayableDirector director;
    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
        if (PlayerPrefs.GetInt("Map") != 1)
        {
            PlayerPrefs.SetInt("Map", 1);
            // add code here to start the video
            
        }
        StartCoroutine(FirstTimeMap());
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FirstTimeMap()
    {
        FirstCamera.SetActive(false);
        MainCamera.SetActive(true);
        subtitle.text = "โอเค ตอนนี้น่าจะปลอดภัย";
        yield return new WaitForSeconds(3);
        subtitle.text = "ถ้าคุณอยากได้ความทรงจำกลับมา คุณต้องเก็บรวบรวม proposal";
        yield return new WaitForSeconds(3);
        subtitle.text = "แล้วคุณจะได้ความทรงจำกลับมาทีละเล็กน้อย แต่วิธีที่จะทำให้คุณปลอดภัยที่สุดก็คือ";
        yield return new WaitForSeconds(4);
        subtitle.text = "ไปให้ถึงตึกหลังนั้น";
        //move camera
        FirstCamera.SetActive(true);
        MainCamera.SetActive(false);

        //continue explaining
        yield return new WaitForSeconds(2);
        FirstCamera.SetActive(false);
        MainCamera.SetActive(true);

        subtitle.text = "โอเค ตอนนี้เราตามลูกศรใกล้ๆไปก่อนนะ";
        yield return new WaitForSeconds(3);
        subtitle.text = "";
    }
}
