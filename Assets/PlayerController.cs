using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveSpeed = 4.0f; // f at the end of the number says it is a floating point number
    float rotateSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player started");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Input.GetAxis("Vertical");

        //Set animations
        Animator anim = gameObject.GetComponent<Animator>();

        if (Input.GetAxis("Vertical") > 0) // forwards
        {
            anim.SetBool("forward", true);
        }
        else // idle
        {
            anim.SetBool("forward", false);
        }

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        
        // forward is the forward direction for this character
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        // We need the CharacterController so we can use SimpleMove
        CharacterController controller = GetComponent<CharacterController>();
        controller.SimpleMove(forward * speed * moveSpeed);
    }
}
