// ChangeSceneOnCollision.cs
// 
// Last modified by Eric Zhang on 11/4/19
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


using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    public string DestScene;
	
	void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))	// compares if the collider is the player via tag
		{
			// it seems that specifying a string from within Unity
			// adds an extra character (Unicode 19) to the front
			// of the string. This is problematic, so we remove it.

			if ( DestScene[DestScene.Length-1] < 32)
			{
				DestScene = DestScene.Substring(0,DestScene.Length-1);
			}
			else if ( DestScene[0] < 32)
			{
				DestScene = DestScene.Substring(1);
			}
			
			SceneManager.LoadSceneAsync(DestScene);
		}

    }
}
