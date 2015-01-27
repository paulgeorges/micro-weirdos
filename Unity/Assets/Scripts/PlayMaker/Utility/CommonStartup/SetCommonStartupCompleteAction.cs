using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;

public class SetCommonStartupCompleteAction : FsmStateAction {

	public override void OnEnter()
	{
		CommonStartup.CommonStartupComplete = true;
		Fsm.BroadcastEvent(FSMEvents.COMMON_STARTUP_COMPLETE);
		Finish();
	}
}
