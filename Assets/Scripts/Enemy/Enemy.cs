using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private int m_Damage      = 3;
    [SerializeField]
    private float m_Speed     = 2.5f;
    [SerializeField]
    private EnemyData data;

    private void Start()
    {
        InitEnemyInfo();
    }

    private void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        this.transform.LookAt(player.transform.position);
        this.transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, m_Speed * Time.deltaTime);
    }

    private void InitEnemyInfo()
    {
        //use EnemyData
        //set -> data.hp
        m_Damage = data.damage;
        m_Speed = data.speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //attack player
        }
    }
}
