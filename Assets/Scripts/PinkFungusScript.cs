using UnityEngine;

public class PinkFungusScript : MonoBehaviour
{

    [SerializeField] private GameObject PowerUp;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        MandyBehaviorScript mandy = collider.GetComponent<MandyBehaviorScript>();

        //DESCOMENTAR ESTA LINEAA en el merge
        //if (mandy != null) mandy.EnableDoubleJump();

    }
}
