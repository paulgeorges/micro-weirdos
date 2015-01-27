using UnityEngine;
using System.Collections;

public class CommonStartupNotifier : MonoBehaviour {
	private bool _notified = false;

	private void Start () {
		if(CommonStartup.CommonStartupComplete){
			NotifyCommonStartup();
		}
	}

	private void OnEnable(){
		CommonStartup.CommonStartupCompleted += OnCommonStartupCompleted;
	}

	private void OnDisable(){
		CommonStartup.CommonStartupCompleted -= OnCommonStartupCompleted;
	}

	private void OnCommonStartupCompleted(){
		NotifyCommonStartup();
	}

	private void NotifyCommonStartup(){
		if(!_notified){
			_notified = true;
			SendMessage(MessageNames.COMMON_STARTUP_COMPLETE, SendMessageOptions.DontRequireReceiver);
		}
	}
}
