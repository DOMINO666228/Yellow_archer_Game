using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaulImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;


    private void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaulImage;
        }
    }
}
