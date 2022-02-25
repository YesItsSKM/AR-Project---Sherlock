using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DisableThePanel");
    }

    IEnumerator DisableThePanel()
    {
        yield return new WaitForSeconds(2.2f);
        this.transform.gameObject.SetActive(false);
    }
}
