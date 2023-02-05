using UnityEngine;

public class PinkFungusScript : MonoBehaviour
{

    [SerializeField] private GameObject PowerUp;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        MandyBehaviorScript mandy = collider.GetComponent<MandyBehaviorScript>();

        if (mandy != null) mandy.EnableDoubleJump();
        Destroy(gameObject);
    }
}
