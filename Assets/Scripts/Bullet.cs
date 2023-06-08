using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _damage;

    public float Damage => _damage;

    public void SetDamage(float damage)
    {
        _damage = damage;
    }

    #region MonoBehaviour

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out IBulletVisitable visitable))
        {
            visitable.Accept(this);
            Destroy(gameObject);
        }
    }

    #endregion
}
