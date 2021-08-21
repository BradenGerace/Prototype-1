using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    public GameObject player;

    private Vector3 offset = new Vector3(0, 8, -10);
    private Vector3 offset2 = new Vector3(0, 3, 3);

    void LateUpdate()
    {
        if (Input.GetButtonDown("1Key"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);

            transform.position = player.transform.position + offset;
        }

        if (Input.GetButtonDown("2Key"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);

            transform.position = player.transform.position + offset2;
        }
    }
}
