using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public Canvas canvas;

    public GameObject PanelPrefab;
    private GameObject Panel;
    
    public void InstantiatePanel()
    {
        if(Panel == null)
        {
            Panel = Instantiate(PanelPrefab, new Vector3(0, 0, 0), Quaternion.identity, canvas.transform) as GameObject;
        }

    }

    public void RemovePanel()
    {
        Destroy(Panel);
    }

}
