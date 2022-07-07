/*
 * 개발자 : 김선호
 * 생성일자 : 2022/07/07
 * 클래스 설명 : Playable Character 이동을 위한 클래스, ObjectMovement 상속
 * 포함 기능
 *  - 상하좌우 이동
 *  - 대쉬
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
