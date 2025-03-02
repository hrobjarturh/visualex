using UnityEngine;

public class AnimatorBoolSetter : MonoBehaviour
{
    public Animator animator;

    public void SetEatGrassTrue()
    {
        animator.SetBool("EatGrass", true);
    }
}