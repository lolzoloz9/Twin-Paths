﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Attack : MonoBehaviour {
	private BoxCollider2D sword;
	private KnightController knight;
	private Animator anim;

	public float attackTime;
	public GameObject rogue;

	void Awake() {
		sword = GetComponent<BoxCollider2D> ();
		anim = GetComponentInParent<Animator> ();
		knight = GetComponentInParent<KnightController> ();
	}

	public void KnightAttack() {
		sword.enabled = true;
		StartCoroutine (AttackLength (attackTime));
	}

	private IEnumerator AttackLength (float attackTime) {
		yield return new WaitForSeconds (attackTime);
		sword.enabled = false;
		anim.SetBool ("Attack", false);
		knight.allowedMovement = true;
	}

	void OnTriggerEnter2D(Collider2D coll) {
		RogueController damage = rogue.GetComponent<RogueController> ();
		if (coll.gameObject.tag == "Rogue") {
			damage.TakeDamage ();
		}
	}
}
