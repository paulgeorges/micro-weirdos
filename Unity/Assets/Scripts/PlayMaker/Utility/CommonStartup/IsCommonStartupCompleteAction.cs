using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;

public class IsCommonStartupCompleteAction : FsmStateAction {
	public FsmEvent trueEvent;
	public FsmEvent falseEvent;

	public override void OnEnter()
	{
		if(CommonStartup.CommonStartupComplete){
			Fsm.Event(trueEvent);
		}else{
			Fsm.Event(falseEvent);
		}
	}
}
