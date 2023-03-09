using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharactor : MonoBehaviour
{
    public Transform player;
    private float AttackRangeal1 = 1;
    public GameObject Monsteral1;
    private bool InRange;
    [SerializeField] private Alpha al1;

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > AttackRangeal1)
        {
            InRange = true;
        }
        else
        {
            InRange = false;
        }
    }

    void FixedUpdate()
    {
        if (InRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, al1.Speed1 * Time.deltaTime);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, AttackRangeal1);
        Gizmos.color = Color.red;

    }
}