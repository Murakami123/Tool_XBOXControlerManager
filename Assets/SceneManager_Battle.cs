using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class SceneManager_Battle : MonoBehaviour {

//------------------------------------------------------------------
// シングルトン
//------------------------------------------------------------------
	public static SceneManager_Battle Instance;
	private SceneManager_Battle(){
		if( Instance == null ) Instance = this;
	}

//------------------------------------------------------------------
// 初期化
//------------------------------------------------------------------
	public void Initialize(){
	}

	[SerializeField] XboxControllerManager xboxControlManager;
	[SerializeField] XBoxInputType InputMode_charaMove;
	[SerializeField] XBoxInputType InputMode_windowControl; 
	[SerializeField] XBoxInputType InputMode_pause; 	
	public int SceneMode;
	void Update(){
		switch( SceneMode ){
			case  1: 
				xboxControlManager.InputController( InputMode_charaMove ); 
			break;
			case  2:
				xboxControlManager.InputController( InputMode_windowControl ); 
			break;
			case  3:
				xboxControlManager.InputController( InputMode_pause ); 
			break;
			default: 
				xboxControlManager.InputController( InputMode_charaMove ); 
			break;
		}
		
	}

	public void OnInput(){
		Debug.Log("入力しました！");
	}

	public void OnInputStick( float x, float y ){
		Debug.Log("スティック入力！　x:" + x + ", y:" + y );
	}



//------------------------------------------------------------------
// 処理
//------------------------------------------------------------------
	public void Open(){

	}

	public void Close(){
		
	}

//------------------------------------------------------------------
// ボタン
//------------------------------------------------------------------
	public void OnOKTouch(){

	}

}