using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator thisAnim;
    // Start is called before the first frame update
    void Start()
    {
        thisAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            thisAnim.SetTrigger("Up");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            thisAnim.SetTrigger("Down");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            thisAnim.SetTrigger("Right");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            thisAnim.SetTrigger("Left");
        }
    }
}
