/*
 * ������ : �輱ȣ
 * �������� : 2022/07/07
 * Ŭ���� ���� : �÷��̾��� Ű ���� ������ ���� Ŭ����
 * ���� ���
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
