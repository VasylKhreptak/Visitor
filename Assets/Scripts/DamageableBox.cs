using UnityEngine;

public class DamageableBox : MonoBehaviour, IBulletVisitable
{
    public void Accept(Bullet visitor)
    {
        Debug.Log($"DamageableBox take damage: {visitor.Damage}");
    }
}
