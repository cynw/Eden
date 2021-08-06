using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using Unity.FPS.Game;
using Unity.FPS.Gameplay;

namespace Unity.FPS.UI
{
    public class SecondScene : MonoBehaviour
    {
        public GameObject ChoiceButton;
        public Text subtitle;
        public GameObject MenuRoot;
        public GameObject fadeOutPanel;
        public float fadeWait;
        // Start is called before the first frame update
        void Update()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;

            EventSystem.current.SetSelectedGameObject(null);
        }


        public void ChoiceOne()
        {
            subtitle.text = "";            
            UnlockCamera();
            StartCoroutine(ConverOne());
            
        }

        IEnumerator ConverOne()
        {
            subtitle.text = "คุณเป็นใครมาจากไหนน่ะ มีบัตรประจำตัวมั้ย";
            yield return new WaitForSeconds(4);
            subtitle.text = "อ้าว แล้วผมต้องทำไงต่อเนี่ย";
            yield return new WaitForSeconds(2);
            subtitle.text = "ดูมีพิรุธ! ยามมาพาตัวออกไปเร็ว!";
            yield return new WaitForSeconds(2);
            StartCoroutine(GoToMap());
        }

        public void ChoiceTwo()
        {
            subtitle.text = "";
            UnlockCamera();
            StartCoroutine(ConverTwo());
            
        }

        IEnumerator ConverTwo()
        {
            subtitle.text = "ทราบแล้วครับ เชิญนั่งรอเก้าอี้ทางนั้นได้เลยครับ";
            yield return new WaitForSeconds(10);
            subtitle.text = "นี่ครับ รายละเอียดโครงการ";
            yield return new WaitForSeconds(3);
        }

        void UnlockCamera()
        {
            Time.timeScale = 1f;
            ChoiceButton.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        IEnumerator GoToMap()
        {
            if (fadeOutPanel != null)
            {
                Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity);
            }
            yield return new WaitForSeconds(fadeWait);
            SceneManager.LoadScene("Map");
        }

    }
}