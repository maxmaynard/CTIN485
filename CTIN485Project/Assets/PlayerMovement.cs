using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    Animator anim;
    bool IsWalking;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) && !Input.GetKeyDown(KeyCode.LeftShift))
        {
            IsWalking = true;
        }
        else
        {
            IsWalking = false;
        }

        if (IsWalking)
        {
            anim.SetBool("Walk", true);
        }
        if (!IsWalking)
        {
            anim.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("Run", true);
        }
        if (!Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("Run", false);
            anim.SetBool("Tired", true);
        }
    }
    IEnumerator recovering()
    {
        yield return new WaitForSeconds(1.5f);
        anim.SetBool("Tired", false);
    }
}
