// ChangeSceneOnCollision.cs
// 
// Script to change scenes when two objects collide.
// Place on only one of the objects, although
// placing it on both won't change much.
// Ensure that both objects have some sort of
// 3D Collision behavior (eg. Box Collider).
// Usually, they have this behavior by default.
//
// For any objects that this is placed on,
// check the box "is trigger" under their Collider.
//
// Also, one object should have the RigidBody behavior
// (placing this on the player makes the most sense).

// Upon adding this behavior to an object, a
// small box labelled DestScene will appear.
// The name of the scene to switch to should be entered here.


public class ChangeSceneOnCollision : UnityEngine.MonoBehaviour
{
    public string DestScene;
    public UnityEngine.Animator Animator;
	private bool loaded = false;
	
	void OnTriggerEnter(UnityEngine.Collider other)
    {	
		// compare if the collider is the player via tag
        if (Globals.HR_Completed && other.CompareTag("Player") && loaded == false)
		{
			// it seems that specifying a string from within Unity
			// adds an extra character (Unicode 19) to one end of
			// the string. This is problematic, so we remove it.
			
			if ( DestScene[0] < 32)
			{
				DestScene = DestScene.Substring(1);
			}
			else if ( DestScene[DestScene.Length-1] < 32)
			{
				DestScene = DestScene.Substring(0,DestScene.Length-1);
			}
			
			loaded = true;

			// unfortunately, Unity does not raise an exception
			// if the scene can't be loaded; it just logs an error.
			// So, no error handling can be done (bleh).

			Globals.HR_TimingEnabled = false;			
			Invoke("LoadScene", 1f);
			Animator.SetTrigger("start-fade-out");
		}
    }
	void LoadScene()
	{
		UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(DestScene);
	}
}
