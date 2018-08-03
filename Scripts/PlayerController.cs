using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
  public float speed;
  public Text countText;
  public Text winText;
  private Rigidbody rb;
  private int count;
  void SetCountText()
  {
    countText.text = "Count: " + count.ToString();
    if (count >= 12)
    {
      winText.text = "You win!";
    }
  }
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    count = 0;
    SetCountText();
    winText.text = "";
  }
  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("PickUp"))
    {
      other.gameObject.SetActive(false);
      count++;
      SetCountText();
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
