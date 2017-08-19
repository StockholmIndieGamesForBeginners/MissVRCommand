using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour , MissVrGeneralScript {

	public float missileMaxSpeed;
	public float missileMinSpeed;
	public float missileSpawnDelayInSeconds;
	public float spawnHeight = 10f;
	public float spawnMinX = 0f;
	public float spawnMaxX = 10f;
	public float spawnMinZ = 0f;
	public float spawnMaxZ = 10f;

	public GameObject enemyMissile;
	public GameObject enemyExplosion;
	public List<Transform> targets;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (started) {
			time += Time.fixedDeltaTime;
			if (time > missileSpawnDelayInSeconds) {
				time = 0;
				SpawnMissile ();
			}
		}
	}

	public void SpawnMissile() {
		Transform spawnPosition = this.transform;
		//randomize position
		float x = Random.Range (spawnMinX, spawnMaxX);
		float z = Random.Range (spawnMinZ, spawnMaxX);
		spawnPosition.position = new Vector3 (x, spawnHeight, z);
		//randomize target
		int targetIndex = -1;
		if (targets.Count > 0) {
			targetIndex = Random.Range(0, targets.Count);
		}
		if (targetIndex >= 0) {
			spawnPosition.LookAt (targets[targetIndex]);
			spawnPosition.Rotate (new Vector3 (1.0f, 0, 0), 90);
			GameObject enemyMissile = Instantiate (enemyMissile, spawnPosition);
			MissileInterface missileScript = enemyMissile.GetComponent<MissileInterface> ();
			if (missileScript != null) {
				missileScript.enemyExplosion = enemyExplosion;
				//TODO do missile initialization
			}
		}
	}
}
