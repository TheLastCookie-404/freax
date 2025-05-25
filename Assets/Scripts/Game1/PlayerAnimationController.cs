using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
  Animator animator;

  void Start()
  {
    animator = GetComponent<Animator>();
  }

  void Update()
  {
    if (Input.GetKey(KeyCode.W))
    {
      animator.Play("Walk");
    }
    else
    {
      animator.Play("Stand");
    }

    Debug.Log(Input.GetKeyDown(KeyCode.W));
  }
}
