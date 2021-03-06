using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class EnemyHPHUD : MonoBehaviour
{
	public SpriteRenderer fill;
	public Vector2 size = Vector2.right * 2f + Vector2.up * 0.5f;
	public EnemyAI enemyRef;

	private void Start()
	{
		fill.size = size;
	}

    void Update()
    {
		Vector2 newVec = size;
		newVec.x = HPHUD.GetBarWidth(enemyRef.health, enemyRef.maxHealth, fill.size.x, size.x, Time.deltaTime * 3f);
		fill.size = newVec;
		fill.color = HPHUD.GetColour(fill.size.x / size.x);
    }
}
