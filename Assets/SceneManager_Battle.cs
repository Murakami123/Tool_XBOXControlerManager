using UnityEngine;
using UnityEngine.UI;
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
	private int SceneMode;
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