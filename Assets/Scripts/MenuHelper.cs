using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHelper : MonoBehaviour
{
    public void OpenLink(string uri)
    {
        Application.OpenURL(uri);
    }
}
