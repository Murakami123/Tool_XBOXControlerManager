﻿using UnityEngine;
using UnityEngine.Events;


//------------------------------------------------------------------
// 入力
//------------------------------------------------------------------
[System.Serializable]
public class XboxControllerManager : MonoBehaviour {
	public void InputController( XBoxInputType inputType ){
		if( Input.GetKey( KeyCode.Joystick1Button0) ) inputType.ButtonA.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button1) ) inputType.ButtonB.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button2) ) inputType.ButtonX.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button3) ) inputType.ButtonY.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button4) ) inputType.ButtonLT.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button5) ) inputType.ButtonLB.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button6) ) inputType.ButtonRT.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button7) ) inputType.ButtonRB.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button8) ) inputType.StickLeftPush.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button9) ) inputType.StickRightPush.Invoke();

		// ここ要調整
		var TrigerInput = Input.GetAxis("Triger");
		if( TrigerInput != 0.0f ) inputType.StickLeft.Invoke( TrigerInput, 2f );

		var HoricontalKeyInput = Input.GetAxis("HorizontalKey");
		if( HoricontalKeyInput != 0.0f ) inputType.StickRight.Invoke( HoricontalKeyInput, 2f );

		var VerticalKeyInput = Input.GetAxis("VerticalKey");
		if( VerticalKeyInput != 0.0f ) inputType.DirectionPad.Invoke( VerticalKeyInput, 2f );
	}
}

//------------------------------------------------------------------
// コントローラからのあらゆる入力を受け付けるコレクションクラス
//------------------------------------------------------------------
[System.Serializable]
public class XBoxInputType {
	public UnityEvent ButtonA, ButtonB,  ButtonX,  ButtonY,
	ButtonLT, ButtonLB, ButtonRT, ButtonRB, ButtonSTART, ButtonBACK,
	StickLeftPush, StickRightPush; 

	[System.Serializable]
	public class UnityEvent_float_float : UnityEvent<float, float>  {
		// 引数を持つUnityEventは継承したものでないと使えないらしい。
		// なので継承したクラス。
	}
	public UnityEvent_float_float StickLeft, StickRight, DirectionPad; 
}

