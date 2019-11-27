using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRateTargetInitializer : MonoBehaviour
{
    public int Duration = 45;
    public UnityEngine.Animator Animator;

	private ulong counter = 0;
	private double hrAve = 0;


    void Start()
    {
		Globals.HR_isGetMid = true;
		Globals.HR_TargetDuration = Duration;

		Globals.HR_isTiming = true;
        Animator.SetTrigger("start-fade-in");
        InvokeRepeating("TimerCheck", 1.1f, 0.1f);
    }

    void CallOnComplete()
    {
		Globals.HR_Completed = true;
		Globals.HR_TargetDuration = 0;
		Globals.HR_TargetMiddle = (int)hrAve;

		Globals.PortalObj.transform.position =  new UnityEngine.Vector3(Globals.PortalSpawnX, Globals.PortalSpawnY, Globals.PortalSpawnZ);
    }


    void TimerCheck()
    {
		if (counter % 10 == 0)
		{
			hrAve = (hrAve * counter/10 + Globals.HeartRate) / (counter/10 + 1);
		}
		++ counter;
		Globals.HR_Timer = (System.Decimal)counter / 10;
		if (Globals.HR_Timer >= Duration)
		{
			hrAve = (hrAve * counter/10 + Globals.HeartRate) / (counter/10 + 1);

			CancelInvoke();
			CallOnComplete();
		}
    }

}
