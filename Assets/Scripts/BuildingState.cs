using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingState : MonoBehaviour
{
    public GameObject arrowObject;
    public GameObject entryPoint;
    public GameObject exitPoint;
    private bool hasProposal;

    // Start is called before the first frame update
    void Start()
    {
        entryPoint.SetActive(false);
        arrowObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHasProposal(bool hasProposal)
    {
        arrowObject.SetActive(hasProposal);
        entryPoint.SetActive(hasProposal);
        this.hasProposal = hasProposal;
        Debug.Log("SetHasProposal");
    }


    public bool isHasProposal()
    {
        return hasProposal;
    }
}
