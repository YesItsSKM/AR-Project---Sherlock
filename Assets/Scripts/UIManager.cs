using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public GameObject intropanel;
    public GameObject menuPanel;

    // Start is called before the first frame update
    void Start()
    {
        intropanel.gameObject.SetActive(true);
        menuPanel.gameObject.SetActive(false);
        StartCoroutine("LoadMenuPanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMenuPanel()
    {
        intropanel.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        intropanel.gameObject.SetActive(false);
        menuPanel.gameObject.SetActive(true);
    }

    public void LoadSherockCamera()
    {
        SceneManager.LoadScene("AnimationScene");
    }

    public void LoadAnimationScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
