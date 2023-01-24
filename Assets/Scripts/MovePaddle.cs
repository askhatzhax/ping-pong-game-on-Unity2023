using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour
{

    public float speed = 30;

    void FixedUpdate()
    {

        float vertPress = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
	Vector2 direction = Vector2.zero;
	if(Input.GetKey(KeyCode.W))
	{
	    direction = Vector2.up * speed;
	}
	if(Input.GetKey(KeyCode.S))
	{
	    direction = Vector2.down * speed;
	}
	
	rigidbody.velocity = direction * speed;

	        
    }
}
*/