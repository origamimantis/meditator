
public class PseudoFallOnCollision : UnityEngine.MonoBehaviour
{
	public UnityEngine.Animator Animator;

	void OnTriggerEnter(UnityEngine.Collider other)
    {	
        if (other.CompareTag("Player"))
		{
			PlayerFall.falling = false;
			fadeout();
			Invoke("respawn", 1.1f);
		}
	}
	void fadeout()
	{
		Animator.SetTrigger("start-fade-out");
	}
	void respawn()
	{
		Animator.SetTrigger("start-fade-in");
		Globals.Player.transform.position = PlayerFall.playerStartLocation;
	}
}
