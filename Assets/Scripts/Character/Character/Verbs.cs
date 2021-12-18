﻿using UnityEngine;

public class Verbs : Character
{
	const int MAX_ATTACK_RANGE = 5;
	private void Awake( ) {
		setCamp( CAMPS.PLAYER );
	}
	private void OnTriggerEnter( Collider other ) {
		if ( other.GetComponent<Character>( ).getCamp( ) == this.getCamp( ) ||
			_enemy_in_scope.Count == MAX_ATTACK_RANGE ) {
			return;
		}
		_enemy_in_scope.Add( other.GetComponent<Character>( ) );
		//Debug.Log( "敵を発見！！！" );
	}
}
