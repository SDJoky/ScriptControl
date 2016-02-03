using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ScriptControl : MonoBehaviour {
	//动态的需要变更绑定的事件。
	// Use this for initialization
	void Start () {

		var trigger = transform.gameObject.GetComponent<EventTrigger>();

		if(trigger == null)
			trigger = transform.gameObject.AddComponent<EventTrigger>();

		// 实例化triggers

		trigger.triggers = new List<EventTrigger.Entry>();
		// 定义需要绑定的事件类型。并设置回调函数
		EventTrigger.Entry entry = new EventTrigger.Entry ();
		// 设置 事件类型
		entry.eventID = EventTriggerType.PointerClick;
		// 设置回调函数
		entry.callback = new EventTrigger.TriggerEvent ();
		UnityAction<BaseEventData> callback = new UnityAction<BaseEventData> (OnScriptControll);
		entry.callback.AddListener (callback);

		// 添加事件触发记录到GameObject的事件触发组件
		trigger.triggers.Add (entry);
	}
	public void OnScriptControll(BaseEventData arg0)
	{
		Debug.Log("ScriptControl Click");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
