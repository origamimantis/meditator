// Globals.cs
//
// A class containing variables to be treated
// as global (ie. one set per game).
//
// This is not intended to be attached to any
// gameObjects (although it probably wouldn't
// do anything severe).

public class Globals
{
	public static UnityEngine.GameObject Player;

	public static int HeartRate = -1;
	
	public static bool HR_isGetMid = false;

	public static int HR_TargetMiddle = 64;
	public static int HR_TargetLower;
    public static int HR_TargetUpper;
    public static bool HR_TargetBoundsInclusive;
    public static int HR_TargetDuration;

	public const System.Decimal HR_TIMER_UPDATE = 0.05m;   // for accuracy; 0.05 non-terminating in binary

    public static bool HR_Completed = false;
    public static bool HR_isTiming = false;
    public static bool HR_TimingEnabled = false;
    public static System.Decimal HR_Timer = 0;

	public const UnityEngine.KeyCode HR_Inc = UnityEngine.KeyCode.M;
	public const UnityEngine.KeyCode HR_Dec = UnityEngine.KeyCode.N;

	public static UnityEngine.GameObject PortalObj;

	public static float PortalSpawnX;
	public static float PortalSpawnY;
	public static float PortalSpawnZ;

}
