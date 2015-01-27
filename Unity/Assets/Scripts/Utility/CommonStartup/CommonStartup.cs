using UnityEngine;
using System.Collections;

public class CommonStartup {
	public delegate void CommonStartupCompletedDelegate();
	public static event CommonStartupCompletedDelegate CommonStartupCompleted;

	private static bool _commonStartupComplete;
	public static bool CommonStartupComplete {
		get{
			return _commonStartupComplete;
		}

		set{
			if(_commonStartupComplete != value){
				_commonStartupComplete = value;

				if(CommonStartupCompleted != null){
					CommonStartupCompleted();
				}
			}
		}
	}
}
