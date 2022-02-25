using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserUi : MonoBehaviour
{
    public GameObject UiInstructions;
    public GameObject UiStart;
    void Start()
    {
        UiStart.gameObject.SetActive(true);
        UiInstructions.gameObject.SetActive(false);
        StartCoroutine("LoadUiInstructionsPanel");
    }

    IEnumerator LoadUiInstructionsPanel()
    {
        UiStart.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        UiStart.gameObject.SetActive(false);
        UiInstructions.gameObject.SetActive(true);
    }

    public void LoadSherockCamera()
    {
        SceneManager.LoadScene("MainScene");
    }
}
