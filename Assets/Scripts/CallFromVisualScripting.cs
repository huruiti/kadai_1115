// Description: Visual Scripting で利用する関数を纏めたサンプルクラス
using UnityEngine;

/// <summary>
/// Visual Scripting で利用する関数を纏めたサンプルクラス
/// </summary>
public class CallFromVisualScripting : MonoBehaviour
{
	public float adjustJumpForce_ = 1.0f; // ジャンプ力の調整用

	/// <summary>
	/// デバッグ用の描画を行う
	/// </summary>
	public void DebugDraw()
	{
		Debug.Log("CallFromVisualScripting::DebugDraw");
	}

	/// <summary>
	/// ジャンプ
	/// </summary>
	/// <param name="force">ジャンプ力</param>
	public void Jump(float force)
	{
		var rg = GetComponent<Rigidbody>();
		rg?.AddForce(Vector3.up * force * adjustJumpForce_, ForceMode.Impulse);
	}

	/// <summary>
	/// ワープ
	/// </summary>
	/// <param name="targetPos">移動先</param>
	public void Warp(Vector3 targetPos)
	{
		transform.position = targetPos;
	}
}
