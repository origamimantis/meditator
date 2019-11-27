// SetPortalSpawn.cs
//
// Quickly set where the portal will spawn
// on level complete.


public class SetPortalSpawn : UnityEngine.MonoBehaviour
{
	public UnityEngine.GameObject Portal;

	public float PortalX;
	public float PortalY;
	public float PortalZ;
    void Start()
    {
		Globals.PortalObj = Portal;
		Globals.PortalSpawnX = PortalX;
		Globals.PortalSpawnY = PortalY;
		Globals.PortalSpawnZ = PortalZ;
    }
}
