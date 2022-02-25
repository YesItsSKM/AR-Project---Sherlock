using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            selection.localScale = new Vector3(3, 3, 3);
        }
    }
}
