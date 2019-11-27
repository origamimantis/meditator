
public class FallOnCollision : UnityEngine.MonoBehaviour
{
	void OnTriggerEnter(UnityEngine.Collider other)
    {
        // compare if the collider is the player via tag
        if (other.CompareTag("Player"))
        {
			PlayerFall.falling = true;
		}
    }
}
