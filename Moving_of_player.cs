using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_of_player : MonoBehaviour
{
    float _speed = 100;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        //transform.position = transform.position + new Vector3(_horizontal * Time.deltaTime * _speed, 0, _vertical * Time.deltaTime * _speed);

        rb.AddForce((-1) * _vertical * Time.deltaTime * _speed, 0, _horizontal * Time.deltaTime * _speed);
    }
}
