using UnityEngine;

public class AndroidScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    private Vector2 moveInput;
    private float moveSpeed = 8f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        myRigidBody.MovePosition(myRigidBody.position + moveSpeed * Time.fixedDeltaTime * moveInput);
    }
}
