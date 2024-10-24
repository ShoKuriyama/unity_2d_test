using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float speedX = 10;
    public float speedY = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>(); 

        Vector2 force = new Vector2(speedX, speedY);

        myRigidBody.AddForce(force);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}