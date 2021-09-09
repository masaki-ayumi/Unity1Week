using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public Transform playerPosition;
    public Transform cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = player.GetComponent<Transform>();

        cameraPosition = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
