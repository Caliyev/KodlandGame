using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Snake_Controller : MonoBehaviour
{
    private Vector2 _direction;
    [SerializeField] float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        GetUserInput();
    }

    private void FixedUpdate()
    {
        SnakeMove();
    }

    private void Reset()
    {
        _direction = Vector2.right;
        
    }

    private void SnakeMove()
    {
        float x, y;
        x = transform.position.x + _direction.x * moveSpeed * Time.deltaTime;
        y = transform.position.y + _direction.y * moveSpeed * Time.deltaTime;
        transform.position = new Vector2(x, y);


    }
    
    private void GetUserInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }


    }


}
