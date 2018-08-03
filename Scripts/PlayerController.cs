using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float speed;
  private Rigidbody rb;
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }
  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("PickUp"))
    {
      other.gameObject.SetActive(false);
    }
  }
  void FixedUpdate()
  {
    // Get the input values for the keys.
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
    rb.AddForce (movement * speed);
  }
}
