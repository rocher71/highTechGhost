using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class jump : MonoBehaviour
{
    float MovePower = 100f;
    float JumpPower = 10f;

    bool isJumping;

    Rigidbody Rigid;

    void Start()
    {
        Rigid = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Character_Move();
        Character_Jump();
    }

    void Character_Move()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirX;
        Vector3 _moveVertical = transform.forward * _moveDirZ;

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * MovePower;

        Rigid.MovePosition(transform.position + _velocity * Time.deltaTime);
    }

    void Character_Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            if(isJumping == true)
            {
                Rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
                isJumping = false;
            }
        }
    }
}
