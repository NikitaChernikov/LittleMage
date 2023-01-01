using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public static PlayerAnimations animations;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        animations = this;
    }

    public void SetWalkingAnim(float dirX, float dirZ)
    {
        anim.SetFloat("Walk", Mathf.Max(Mathf.Abs(dirX), Mathf.Abs(dirZ)));
    }

    public void Attack(float value)
    {
        anim.SetFloat("Attack", value);
    }
}
