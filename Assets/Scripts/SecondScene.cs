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

        public Text Button1;
        public Text Button2;
        public bool isSecondClick;
        // Start is called before the first frame update
        void Update()
        {
            LockCamera();
        }


        public void ChoiceOne()
        {
            if (isSecondClick)
            {
                subtitle.text = "";
                UnlockCamera();
                StartCoroutine(ConverOne2());
            }
            else
            {
                subtitle.text = "";
                UnlockCamera();
                StartCoroutine(ConverOne());
            }
        }

        IEnumerator ConverOne()
        {
            subtitle.text = "คุณเป็นใครมาจากไหนน่ะ มีบัตรประจำตัวมั้ย";
            yield return new WaitForSeconds(4);
            subtitle.text = "อ้าว แล้วผมต้องทำไงต่อเนี่ย";
            yield return new WaitForSeconds(2);
            subtitle.text = "ดูมีพิรุธ! ยามมาพาตัวออกไปเร็ว!";
            yield return new WaitForSeconds(1);
            StartCoroutine(GoToMap());
        }

        IEnumerator ConverOne2()
        {
            subtitle.text = "ทราบแล้วครับ กรุณารอสักครู่ครับ";
            yield return new WaitForSeconds(3);
            subtitle.text = "";
            yield return new WaitForSeconds(4);
            subtitle.text = "ขอโทษที่ให้รอครับ นี่รายละเอียดโครงการที่คุณณัฐวรรณให้มาครับ";
            yield return new WaitForSeconds(3);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("ProposalViewer");
        }

        public void ChoiceTwo()
        {
            if (isSecondClick)
            {
                subtitle.text = "";
                UnlockCamera();
                StartCoroutine(ConverTwo2());
            }
            else
            {
                subtitle.text = "";
                UnlockCamera();
                StartCoroutine(ConverTwo());
            }
            
        }

        IEnumerator ConverTwo()
        {
            subtitle.text = "ไม่ทราบว่าได้ติดต่อล่วงหน้าไว้หรือไม่ครับ";
            yield return new WaitForSeconds(4);
            
            //Second Click
            isSecondClick = true;
            Button1.text = "ครับ ติดต่อไว้เมื่อเช้า";
            Button2.text = "ไม่ได้ติดต่อไว้ครับ";
            ChoiceButton.SetActive(true);
            LockCamera();

            /*subtitle.text = "";
            yield return new WaitForSeconds(5);
            subtitle.text = "นี่ครับ รายละเอียดโครงการ";
            yield return new WaitForSeconds(3);*/
        }

        IEnumerator ConverTwo2()
        {

            subtitle.text = "งั้นไม่ได้ครับ ถ้าไม่ได้ติดต่อล่วงหน้า ไม่อนุญาติให้พบครับ";
            yield return new WaitForSeconds(3);
            subtitle.text = "อ้าว! มีแบบนี้ด้วยเหรอ";
            yield return new WaitForSeconds(2);
            subtitle.text = "ยามครับ มาพาเขาออกไป";
            yield return new WaitForSeconds(2);
            subtitle.text = "เห้ย!";
            yield return new WaitForSeconds(2);
            subtitle.text = "";
            yield return new WaitForSeconds(2);
            StartCoroutine(GoToMap());
        }

        void UnlockCamera()
        {
            Time.timeScale = 1f;
            ChoiceButton.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void LockCamera()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;

            EventSystem.current.SetSelectedGameObject(null);
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