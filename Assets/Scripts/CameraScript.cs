using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    // Update is called once per frame
    void Update()
    {
        if (_player == null) return;

        Vector3 position = transform.position;
        position.x = _player.transform.position.x;
        position.y = _player.transform.position.y;
        transform.position = position;
    }
}
