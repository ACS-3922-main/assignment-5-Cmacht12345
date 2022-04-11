using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Animator _anim;
    private Vector3 _movement = new Vector3();

    void UpdateState()
    {
        if (Mathf.Approximately(_movement.x, 0) &&
        Mathf.Approximately(_movement.y, 0))
        {
            _anim.SetBool("isWalking", false);
        }
        else
        {
            _anim.SetBool("isWalking", true);
        }
        _anim.SetFloat("xDir", _movement.x);
        _anim.SetFloat("yDir", _movement.y);
    }
}
