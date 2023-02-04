using UnityEngine;

public class RootScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        MandyBehaviorScript mandy = collider.GetComponent<MandyBehaviorScript>();

        if (mandy != null) mandy.Hit(1);

        //DestroyBullet();
    }
}
