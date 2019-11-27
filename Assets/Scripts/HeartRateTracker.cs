// HeartRateTracker.cs
// 
// Script to update global heartrate information
// from the keyboard (used as a placeholder
// until BlueTooth connection is working).
//
// This should be used as a "singleton," ie.
// only create one instance of this class and
// put it somewhere relatively universal.
//
// Makes sense to put this on the player object
// or the HUD.


public class HeartRateTracker : UnityEngine.MonoBehaviour
{
	public int BaseHeartRate = 60;

	void Start()
	{
		if (Globals.HeartRate <= 0)
		{
			Globals.HeartRate = BaseHeartRate;
		}
	}

    void Update()
    {
		if (UnityEngine.Input.GetKeyDown(Globals.HR_Inc))
		{
			++ Globals.HeartRate;
		}
		if (UnityEngine.Input.GetKeyDown(Globals.HR_Dec) && Globals.HeartRate > 0)
		{
			-- Globals.HeartRate;
		}
    }
}
