using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField]
    protected int attackStat = 1;

    int m_currentHealth;
    bool m_isDead;

    [SerializeField]
    protected float moveSpeed = 1.0f;
    [SerializeField]
    protected float baseHealth = 10.0f;

    [SerializeField]
    protected Vector3 colour = new Vector3(1.0f, 1.0f, 1.0f);

    Collider enemyCollider = null;

    EnemyState enemyState = EnemyState.idle;

    public enum EnemyState
    {
        idle,
        wander,
        attack,
    }

    // Start is called before the first frame update
    public virtual void Start()
    {
        enemyCollider = this.transform.GetComponent<Collider>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        Move();
    }

    public virtual void Attacking()
    {
        enemyCollider.enabled = true;
        enemyState = EnemyState.attack;
    }

    public virtual void Move()
    {
        this.transform.position = this.transform.position + new Vector3(0.0f, 0.0f, 1.0f) * moveSpeed * Time.deltaTime;
    }
}
