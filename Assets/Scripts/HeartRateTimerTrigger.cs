// HeartRateTimerTrigger.cs
//
// Implements the "progress bar" of each level.
// ie. It waits until the player has maintained heartrate
// in a range before progressing to the next level.
//
// This is yet another "singleton" behavior. It makes the
// most sense to attach this to the "Player" gameObject
// or the HUD.
//
// Details - If the player's heartrate  enters the target
// interval, then the script begins updating the progress
// timer. If the player exits before the time is completed,
// then the timer resets and awaits the next moment that
// the player's heartrate enters the interval again. 
// Upon completion, this script will either spawn or
// activate a portal to the next level.

public class HeartRateTimerTrigger : UnityEngine.MonoBehaviour
{
	// customize globals at scene start
    public int TargetDifferencePercent = 10;
    public int TargetDuration = 10;
    public UnityEngine.Animator Animator;

	void Start()
	{
		Globals.HR_isGetMid = false;

		Globals.HR_TargetLower = (int)System.Math.Round(Globals.HR_TargetMiddle*(100f - TargetDifferencePercent)/100);
		Globals.HR_TargetUpper = (int)System.Math.Round(Globals.HR_TargetMiddle*(100f + TargetDifferencePercent)/100);

		Globals.HR_TargetDuration = TargetDuration;
		Globals.HR_Completed = false;
		Globals.HR_isTiming = false;
		Globals.HR_Timer = 0;
		Animator.SetTrigger("start-fade-in");
		Invoke("EnableTiming", 1f);
	}

	void EnableTiming()
	{
		Globals.HR_TimingEnabled = true;
	}

	bool HeartRateInRange()
	{
		int hr = Globals.HeartRate;
		// accounts for rounding
		return (hr >= Globals.HR_TargetLower && hr < Globals.HR_TargetUpper);
	}
	
	void CallOnComplete()
	{
		Globals.PortalObj.transform.position =  new UnityEngine.Vector3(Globals.PortalSpawnX, Globals.PortalSpawnY, Globals.PortalSpawnZ);
	}


	void TimerBegin()
	{
		Globals.HR_Timer = 0;
		InvokeRepeating("TimerCheck", (float)Globals.HR_TIMER_UPDATE, (float)Globals.HR_TIMER_UPDATE);

	}

	void TimerCheck()
	{
		if (HeartRateInRange())
		{
			Globals.HR_Timer += Globals.HR_TIMER_UPDATE;
			if (Globals.HR_Timer >= Globals.HR_TargetDuration)
			{
				Globals.HR_Completed = true;
				CancelInvoke();
				CallOnComplete();
				Destroy(this);
			}
		}
		else
		{
			CancelInvoke();
			Globals.HR_isTiming = false;
			Globals.HR_Timer = 0;
		}
	}
    
    void Update()
    {
        if (Globals.HR_Completed == false && Globals.HR_TimingEnabled && Globals.HR_isTiming == false && HeartRateInRange())
		{
			Globals.HR_isTiming = true;
			TimerBegin();
		}
    }
}
