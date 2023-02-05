using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;

    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (target == null) return;
        Vector3 moveposition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, moveposition, ref velocity, damping);
    }

}
