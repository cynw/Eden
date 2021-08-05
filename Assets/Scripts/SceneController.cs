using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    public List<GameObject> buildingObjects;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AssignProposalToBuilding());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator AssignProposalToBuilding()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 15));
            int randomIndex = Random.Range(0, buildingObjects.Count);
            BuildingState state = buildingObjects[randomIndex].GetComponent<BuildingState>();
            if (!state.isHasProposal())
            {
                state.SetHasProposal(true);
            }
        }
    }

}
