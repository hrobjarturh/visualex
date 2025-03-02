using UnityEngine;

public class HorseController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetEatGrass()
    {
        if (animator != null)
        {
            animator.SetBool("eatgrass", true);
        }
    }
}