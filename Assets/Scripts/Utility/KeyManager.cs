/*
 * 개발자 : 김선호
 * 생성일자 : 2022/07/07
 * 클래스 설명 : 플레이어의 키 설정 관리를 위한 클래스
 * 포함 기능
 *  - 
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyAction { UP,DOWN,LEFT,RIGHT,KEYCOUNT }
public static class KeySetting { public static Dictionary<KeyAction, KeyCode> keys = new Dictionary<KeyAction, KeyCode> { }; }
public class KeyManager : MonoBehaviour
{

}
