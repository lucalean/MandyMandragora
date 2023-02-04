using UnityEngine;

public class FungusScript : MonoBehaviour
{
    private int Health = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
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
}
