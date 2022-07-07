/*
 * ������ : �輱ȣ
 * �������� : 2022/07/07
 * Ŭ���� ���� : Playable Character �̵��� ���� Ŭ����, ObjectMovement ���
 * ���� ���
 *  - �����¿� �̵�
 *  - �뽬
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableCharacterMovement : ObjectMovement
{
    [SerializeField] private float defaultMoveSpeed;
    [SerializeField] private float defaultDashSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //test
        {
            objectMove(gameObject, defaultMoveSpeed, Vector3.up);
        }
        if (Input.GetKey(KeyCode.A)) //test
        {
            objectMove(gameObject, defaultMoveSpeed, Vector3.left);
        }
        if (Input.GetKey(KeyCode.S)) //test
        {
            objectMove(gameObject, defaultMoveSpeed, Vector3.down);
        }
        if (Input.GetKey(KeyCode.D)) //test
        {
            objectMove(gameObject, defaultMoveSpeed, Vector3.right);
        }
    }
}
