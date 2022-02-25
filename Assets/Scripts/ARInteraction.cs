using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using TMPro;
using UnityEngine.XR.ARSubsystems;
using System.Collections;

public class ARInteraction : MonoBehaviour
{

    //[SerializeField] Camera playerCam;
    [SerializeField] Text action;
    //[SerializeField] private Button grabButton;

    RaycastHit hitObj;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    [SerializeField] float SPEED = 10f;

    public MoveObjects moveObjects;
    private string evidenceName = "";

    [SerializeField] Text debugText;

    //float range = 1f;

    IEnumerator HoldOnObject()
    {
        yield return new WaitForSeconds(2f);
    }

    private void Start()
    {
        //grabButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hitObj, 100f))
        {
            /*
                if(hitObj.transform.tag != "AR Plane")
                {
                    action.text = hitObj.transform.name;

                    //hitObj.transform.position;
                    //print(hitObj.transform.name);
                }
            */

            debugText.text = hitObj.transform.name;

            if (hitObj.transform.tag == "Evidence")
            {
                //hitObj.transform.position = Vector3.MoveTowards(hitObj.transform.position, hitObj.transform.position + new Vector3(0, 1f, 0), Time.deltaTime * SPEED);

                action.color = new Color(220, 0, 0);

                var selection = hitObj.transform;
                
                selection.localScale = new Vector3(3, 3, 3);

                //selection.localScale = Vector3.Lerp (selection.localScale, selection.localScale * 3, Time.deltaTime * 10);

                StartCoroutine("HoldOnObject");
                hitObj.transform.gameObject.SetActive(false);

                //grabButton.gameObject.SetActive(true);

                evidenceName = hitObj.transform.name.ToString();

                moveObjects.AddToInventory(evidenceName);
            }

                action.color = new Color(255, 255, 255);
        }
    }

    
}
