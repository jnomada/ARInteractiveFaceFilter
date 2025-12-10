using System;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public void ChangeAllMaterials(Material mat)
    {
        foreach (string tag in meshTags)
        {
            GameObject gameobject = GameObject.FindWithTag(tag);
            if (gameobject != null)
            {
                gameobject.GetComponent<Renderer>().material = mat;
            }
        }
    }
}