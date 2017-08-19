using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, MissVrGeneralScript {
	public GameObject enemyMissile;
	public GameObject pointDefenceMissile;
	public GameObject enemyExplosion;
	public GameObject pdExplosion;
	public GameObject player;

	public StatsBoard statsBoard;
	public int maxMissile = 5;
	public int currentFreeMissile = maxMissile;
	public int currentCities = 8;

	public MissileSpawner missileSpawner;
	public float missileMaxSpeed;
	public float missileMinSpeed;
	public float missileSpawnDelayInSeconds;

	public int level = 1;

	private float currentTime;

	// Use this for initialization
	void Start () {
	}

	void FixedUpdate() {
		if (started) {
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartNewGame() {
		statsBoard.score = 0;
		statsBoard.freeMissile = currentFreeMissile;
		statsBoard.numberOfCities = currentCities;

		missileSpawner.missileMaxSpeed = missileMaxSpeed;
		missileSpawner.missileMinSpeed = missileMinSpeed;
		missileSpawner.missileSpawnDelayInSeconds = missileSpawnDelayInSeconds;
		missileSpawner.enemyMissile = enemyMissile;
		missileSpawner.enemyExplosion = enemyExplosion;
	}
}
