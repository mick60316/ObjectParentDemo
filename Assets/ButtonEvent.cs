using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonEvent : MonoBehaviour
{
    public GameObject earth;
    public GameObject sun;
    public GameObject canvas;
    public Image isParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sun.transform.childCount == 0)
        {
            isParent.color = Color.red;
        }
        else {
            isParent.color = Color.green;
        }
    }
    public void setParent(bool isSet)
    {
        if (isSet)
        {
            earth.transform.parent = sun.transform;
        }
        else {
            earth.transform.parent = canvas.transform;
        }
    }

}
