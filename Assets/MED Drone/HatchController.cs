using UnityEngine;

public class HatchController : MonoBehaviour
{
    public Animator animator;

    private bool isOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleHatch();
        }
    }

    void ToggleHatch()
    {
        isOpen = !isOpen;

        Debug.Log("F pressed — toggling hatch. Now isOpen = " + isOpen);

        animator.SetBool("IsOpen", isOpen);
    }
}
