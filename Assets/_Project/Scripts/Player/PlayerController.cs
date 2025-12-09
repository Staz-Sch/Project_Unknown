using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{



    [SerializeField] private float speed = 10f;

    private Rigidbody2D Rigidbody2D;


    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {

        Move();

    }



    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY)  * speed;
        Rigidbody2D.linearVelocity = movement.normalized;

    }






}


