using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigidBody;

    public float playerSpeed = 10;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>(); 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = Vector2.zero;

        if(Input.GetKey(KeyCode.LeftArrow)){
            force = new Vector2(playerSpeed * -1, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            force = new Vector2(playerSpeed * 1, 0);
        }

        myRigidBody.MovePosition(myRigidBody.position + force * Time.fixedDeltaTime);
    }
}
