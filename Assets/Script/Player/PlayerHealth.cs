using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	private bool isEnemyNear = false;
	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
		enemyNear();
    }

	public void enemyNear()
	{
		if (isEnemyNear)
		{
			StartCoroutine(TakeDamage(5));
		}
		else
		{
			StopCoroutine(TakeDamage(5));
		}

	}



	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag=="Enemy")
		{
			this.isEnemyNear = true;
		}
	}


	private void OnTriggerExit2D(Collider2D collision)
	{
		this.isEnemyNear = false;
	}


	IEnumerator TakeDamage(int damage)
	{
		yield return new WaitForSeconds(0.50f);
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}
}
