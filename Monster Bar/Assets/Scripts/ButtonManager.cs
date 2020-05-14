using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public Canvas canvas;
    
    public void InstantiatePanel(GameObject panel)
    {
        Instantiate(panel, new Vector3(0, 0, 0), Quaternion.identity, canvas.transform);
    }

    public void RemovePanel(GameObject panel)
    {
        Destroy(panel);
    }

}
