using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public Transform parent;
    public Transform left;
    public Transform down;
    public Transform up;
    public Transform right;

    public GameObject leftArrowPrefab;
    public GameObject downArrowPrefab;
    public GameObject upArrowPrefab;
    public GameObject rightArrowPrefab;

    public AudioSource audio;
    [Range(0f, 1f)]
    public float speed = 1f;

    //void SetGameSpeed()
   // {
     //   Time.timeScale = speed;
      //  audio.pitch = speed;
    //}

    //void Start()
   // {
    //    SetGameSpeed();
   // }
    //

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(leftArrowPrefab, left.position, leftArrowPrefab.transform.rotation, parent);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(downArrowPrefab, down.position, downArrowPrefab.transform.rotation, parent);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(upArrowPrefab, up.position, upArrowPrefab.transform.rotation, parent);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(rightArrowPrefab, right.position, rightArrowPrefab.transform.rotation, parent);
        }
    }
}
