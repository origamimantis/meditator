// FacePlayer.cs
//
// Used to keep portal facing the player.


public class FacePlayer : UnityEngine.MonoBehaviour
{
    void Update()
    {
		UnityEngine.Vector3 playerMinusY = Globals.Player.transform.position;
		playerMinusY.y = transform.position.y;
		transform.LookAt(playerMinusY);
    }
}
