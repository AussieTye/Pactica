using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Controller : MonoBehaviour
{
    public float speed;
    public Text countText;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private int count;
    public int maxHealth = 3;
    int currentHealth;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        currentHealth = maxHealth;
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("PickUp2"))
        {
            other.gameObject.SetActive(false);
            count = count + 100;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "High Score: " + count.ToString();
    }

}
