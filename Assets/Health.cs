using UnityEngine; 
using System;
using System.Collections; 
using UnityEngine.UI; 

public class Health : MonoBehaviour {
	public float CurrentHealth { get; set; }
	public float MaxHealth { get; set; }
	public float damageValue = 1.0f; 
	public Slider healthbar; 
	public float canHealth = 3.0f; 

	void Start() {
		//resets when game starts 
		MaxHealth = 20f; 
		CurrentHealth = MaxHealth; 
		healthbar.value = CalculateHealth (); 
	}

	void dropHealth() {
		//TODO: in flash, should call this in the update function 

		// the health drop should be constant 
		CurrentHealth -= damageValue; 
		healthbar.value = CalculateHealth (); 
		if (CurrentHealth <= 0) {
			CurrentHealth = 0; 
			Die(); 
		}
	}

	void gainHeath() {
		//TODO: in the disappear function in the spawn, call this function 
		CurrentHealth += canHealth; 
		healthbar.value = CalculateHealth (); 
	}

	void Die() {
		//TODO:char may have to look different, maybe a different animation or something 
	}

	float CalculateHealth(){
		return CurrentHealth / MaxHealth; 
	}
}

