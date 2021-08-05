using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToBuilding : MonoBehaviour
{

    public string sceneToLoad;

    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public float fadeWait;
    public GameObject building;
    public GameObject exitPoint;
    public VectorValue playerPosition;


    private void Awake()
    {
        if (fadeInPanel != null)
        {
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity);
            Destroy(panel, 1);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeCo());
        }
    }

    public IEnumerator FadeCo()
    {
        if (fadeOutPanel != null)
        {
            Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(fadeWait);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        playerPosition.initialValue = exitPoint.transform.position;
        building.GetComponent<BuildingState>().SetHasProposal(false);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
}
