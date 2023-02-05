using UnityEngine;

public class FungusScript : MonoBehaviour
{
    private int Health = 1;

    [SerializeField] private GameObject Heart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
        Hit();
    }

    public void Hit()
    {
        Health -= 1;
        if (Health < 0)
        {
            Destroy(gameObject);
            //TODO: Dropear algo
        }
    }
    private void OnDestroy()
    {
        Instantiate(Heart, transform.position, Quaternion.identity);
    }
}
