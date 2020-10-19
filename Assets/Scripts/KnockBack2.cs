﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack2 : MonoBehaviour
{
    public float thrust;
    public float knockTime;
    public float damage;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("breakable") && this.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Pot>().Smash();
        }
        if (other.gameObject.CompareTag("enemy") || other.gameObject.CompareTag("Player"))
        {
            Rigidbody2D hit = other.GetComponent<Rigidbody2D>();
            if (hit != null)
            {
                Vector2 differece = hit.transform.position - transform.position;
                differece = differece.normalized * thrust;
                hit.AddForce(differece, ForceMode2D.Impulse);
                if (other.gameObject.CompareTag("enemy") && other.isTrigger)
                {
                    hit.GetComponent<Enemy>().currentState = EnemyState.stagger;
                    other.GetComponent<Enemy>().Knock(hit, knockTime, damage);
                }

                if (other.gameObject.CompareTag("Player2"))
                {
                    if (other.GetComponent<Player2Movement>().currentState != PlayerState2.stagger)
                    {
                        hit.GetComponent<Player2Movement>().currentState = PlayerState2.stagger;
                        other.GetComponent<Player2Movement>().Knock(knockTime, damage);
                    }
                }
            }
        }
    }


    private IEnumerator KnockCo(Rigidbody2D enemy)
    {
        if (enemy != null)
        {
            yield return new WaitForSeconds(knockTime);
            enemy.velocity = Vector2.zero;
            enemy.GetComponent<Enemy>().currentState = EnemyState.idle;
        }
    }
}
