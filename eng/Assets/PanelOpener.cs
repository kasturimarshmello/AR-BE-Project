using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
     public GameObject LocationPanel;
    public void OpenPanel()
{
     if (LocationPanel!= null)
{
     LocationPanel.SetActive(true);
}
}
}