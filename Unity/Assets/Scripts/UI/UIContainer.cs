using UnityEngine;
using System.Collections;

public class UIContainer : MonoBehaviour {
	private UIManager _uiManager;
	private RectTransform _rectTransform;

	private void Awake(){
		_rectTransform = GetComponent<RectTransform>();
	}

	private void CommonStartupComplete(){
		//_uiManager = UIManager.Instance;
		//_uiManager.QueueUIContainer(this);
		_rectTransform.anchoredPosition.Set(_rectTransform.anchoredPosition.x + Screen.width, _rectTransform.anchoredPosition.y);
	}
}
