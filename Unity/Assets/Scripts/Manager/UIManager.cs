using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIManager : MonoBehaviour {
	public static UIManager Instance { get; set; }

	private Queue<UIContainer> _uiContainerQueue = new Queue<UIContainer>();

	private void Awake(){
		Instance = this;
	}

	public void QueueUIContainer(UIContainer uiContainer){
		_uiContainerQueue.Enqueue(uiContainer);
	}

	public UIContainer DequeueUIContainer(){
		return _uiContainerQueue.Dequeue();
	}
}
