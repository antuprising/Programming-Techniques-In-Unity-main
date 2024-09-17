using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    private Rigidbody rb;
    private Vector3 movement;
    public int hp = 100;
    private bool isAlive = true;

    public bool IsAlive
    {
        get { return isAlive; }
        set { isAlive = value; }
    }

    //Called when the script instance is being loaded
    void Awake()
    {
        Debug.Log("Awake called: Initializing PlayerCOntroller");
            rb = GetComponent<Rigidbody>(); //Ger reference to Rogidbody component
    }

// Called once before the first frame update
    void Start()
    {
        Debug.Log("Start called: PlayerCOntroller setup complete");
    }

    // Called ever frame
    void Update()
    {
        HandleMovement(); //Handles player movement based on input
        if (isAlive)
        { 
        gameObject.SetActive(true);
        }

        else 
        { 
        gameObject.SetActive(false);

        }

    }

    // Called every fixed time interval (used for physics)

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Handles movement input (runs in update)
    private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        movement = new Vector3(moveX, 0, moveZ);
    }

    public void IncreaseSpeed(float increaseSpeedBy)
    {
        speed += increaseSpeedBy;
    }

    private void MovePlayer()
    {
        rb.velocity = movement * speed;
    }

    public void takeDamage(int dmgAmount)
    {
        hp -= dmgAmount;
    }

}
