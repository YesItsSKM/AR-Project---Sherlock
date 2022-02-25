using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;


[RequireComponent(typeof(ARRaycastManager))]
public class ToggleARPlanes : MonoBehaviour
{
    private ARPlaneManager planeManager;
    public ARTapToPlace aRTapToPlace;

    [SerializeField] private Text toggleButtonText;
    [SerializeField] private Button toggleButton;

    bool planesDisabled = false;

    private void Awake()
    {
        planeManager = GetComponent<ARPlaneManager>();
        toggleButtonText.text = "Disable";

        toggleButton.gameObject.SetActive(false);
    }

    private void Update()
    {
        
        if ((aRTapToPlace.isObjectPlaced == true) && (planesDisabled == false))
        {
            toggleButton.gameObject.SetActive(true);
        }
        
        if (planeManager.enabled == false)
        {
            toggleButton.gameObject.SetActive(false);
        }
    }


    public void TogglePlaneDetection()
    {
        planeManager.enabled = !planeManager.enabled;
        string toggleButtonMessage = "";

        //Debug.LogError(toggleButton.gameObject);

        if (planeManager.enabled)
        {
            toggleButtonMessage = "Disable";
            SetAllPlanesActive(true);

            planesDisabled = true;
        }
        else
        {
            toggleButtonMessage = "Enable";
            SetAllPlanesActive(false);

            planesDisabled = false;
        }

        toggleButtonText.text = toggleButtonMessage;
    }

    private void SetAllPlanesActive(bool value)
    {

        foreach(var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(value);
        }
    }
}
