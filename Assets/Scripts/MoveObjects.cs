using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveObjects : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[4];

    public GameObject[] evidence= new GameObject[4];
    public Transform[] objects = new Transform[4];

    private string evidenceName;
    [SerializeField] private int collected = 0;

    [SerializeField] private Button button;

    [SerializeField] Text debugText;

    private void Start()
    {
        button.gameObject.SetActive(false);

        for(int i = 0; i < evidence.Length; i++)
        {
            evidence[i].gameObject.GetComponent<Image>().sprite = sprites[i];
            evidence[i].gameObject.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.2f);
        }
    }

    private void Update()
    {
        if (collected == 4)
        {
            button.gameObject.SetActive(true);
        }
    }


    public void ReloadScene()
    {
        debugText.text = "Reload";

        SceneManager.LoadScene("Instruction Page");
    }

    public void AddToInventory(string name)
    {
        switch (name)
        {
            case "Bat": 
                        evidence[0].gameObject.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        evidenceName = evidence[0].transform.name;
                        ++collected;
                        
                        break; 

            case "Necklace": 
                             evidence[1].gameObject.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                             evidenceName = evidence[1].transform.name;
                             ++collected;
                break;

            case "Gun": 
                            evidence[2].gameObject.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                            evidenceName = evidence[2].transform.name;
                            ++collected;
                break;

            case "Phone": 
                          evidence[3].gameObject.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                          evidenceName = evidence[3].transform.name;
                          ++collected;
                break;

            default:
                break;
        }

        print(collected);
    }
}
