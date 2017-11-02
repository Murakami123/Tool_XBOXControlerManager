using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;


//------------------------------------------------------------------
// 入力
//------------------------------------------------------------------
public class XboxControllerManager : MonoBehaviour {
	public void InputController( XBoxInputType inputType ){
		if( Input.GetMouseButtonDown(0) ) inputType.ButtonA.Invoke();
		if( Input.GetMouseButtonDown(1) ) inputType.ButtonB.Invoke();
		if( Input.GetMouseButtonDown(2) ) inputType.ButtonX.Invoke();
		if( Input.GetMouseButtonDown(3) ) inputType.ButtonY.Invoke();
		if( Input.GetMouseButtonDown(4) ) inputType.ButtonLT.Invoke();
		if( Input.GetMouseButtonDown(5) ) inputType.ButtonLB.Invoke();
		if( Input.GetMouseButtonDown(6) ) inputType.ButtonRT.Invoke();
		if( Input.GetMouseButtonDown(7) ) inputType.ButtonRB.Invoke();
	}
}


//------------------------------------------------------------------
// コントローラからのあらゆる入力を受け付けるコレクションクラス
//------------------------------------------------------------------
[System.Serializable]
public class XBoxInputType : MonoBehaviour {
	public UnityAction 
	ButtonA,  ButtonB,  ButtonX,  ButtonY,
	ButtonLT, ButtonLB, ButtonRT, ButtonRB,
	ButtonSTART, ButtonBACK,
	StickLeftPush, StickRightPush; 


	[System.Serializable]
	public class test : UnityEvent<float, float>  {
		public UnityAction
		StickLeft_UpDown, StickLeft_LeftRight,
		StickRight_UpDown, StickRight_LeftRight,
		DirectionPad_UpDown, DirectionPad_LeftRight; 
	}
}