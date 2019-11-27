// DisplayHeartRate.cs
//
// Script to populate and update the HUD
// with information concerning the player's
// progress in the game.


public class DisplayHeartRate : UnityEngine.MonoBehaviour
{
	private int HRMem = 0;
	private System.Decimal TimerMem = 0;

	private UnityEngine.UI.Text HRText;
	private UnityEngine.UI.Text TimerText;

	void Start()
	{
		HRText = transform.Find("HRText").GetComponent<UnityEngine.UI.Text>();
		TimerText = transform.Find("TimerText").GetComponent<UnityEngine.UI.Text>();
		//setHRText();
		//setTimerText();
		Invoke("setTimerText", 0f);
	}

    void Update()
    {
        if (HRMem != Globals.HeartRate)
		{
			setHRText();
		}
		if (Globals.HR_isTiming)
		{
			setTimerText();
		}
    }

	void setHRText()
	{
		HRMem = Globals.HeartRate;
		HRText.text = "Heart Rate: " + HRMem.ToString();
	}
	
	void setTimerText()
	{
		if (Globals.HR_Completed == false)
		{
			TimerText.text = "Time Remaining: " + (Globals.HR_TargetDuration - Globals.HR_Timer).ToString("0.0");
		}
		else
		{
			if (Globals.HR_isGetMid == false)
			{
				TimerText.text = "Success!";
			}
			else
			{
				TimerText.text = "Base Heartrate: " + Globals.HR_TargetMiddle;
			}
		}

	}
}
