using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// Контроллер и поведение игрока
/// 
public class PlayerScript : MonoBehaviour
{
	/// 
	/// 1 - скорость движения
	/// 
	public Vector2 speed = new Vector2(50, 50);

	// 2 - направление движения
	private Vector2 movement;

	void Update()
	{
		// 3 -  извлечь информацию оси
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// 4 - движение в каждом направлении
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);

	}

	void FixedUpdate()
	{
        // 5 - перемещение игрового объекта
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}