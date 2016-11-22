using UnityEngine;
using System.Collections;

public class FindPlayer1 : MonoBehaviour {
    GameObject player;

    void OnAwake()
    {
        
    }
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            player = GameObject.Find("Capsule");
            print(player);
            if (player != null)
            {
                GetComponent<HingeJoint>().connectedBody = player.GetComponent<Rigidbody>();
                //gameObject.transform.SetParent(player.transform);
            }
        }
	}
}
