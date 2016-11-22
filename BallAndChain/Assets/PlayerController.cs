﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    Camera camera;
    // Use this for initialization
    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        camera = FindObjectOfType<Camera>();
        camera.transform.position = gameObject.transform.position + new Vector3(.5f, 1, -2);
        camera.transform.SetParent(gameObject.transform);

        GetComponent<HingeJoint>().connectedBody = GameObject.Find("Capsule").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        if (!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetMouseButtonDown(0))
        {
            CmdFire();
        }
    }
    //This [Command] code is called on the Client but it is run on the server.
    [Command]
    void CmdFire()
    {
        //Create bullet from bullte prefab
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        //Add velocity to bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
        //Spawn the bullet on the Clients
        NetworkServer.Spawn(bullet);
        //Destroy bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
}
