using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSetter : MonoBehaviour
{

	[SerializeField]
	StageDataManager StageData;

	void Start()
    {
		/*
		 *	Set 함수들 (ex_ 카드 나눠주기)
		 * 
		 * */


		MoveToGamePlay();
	}


	[Header("Game Player")]
	[SerializeField]
	GameObject GamePlayer;
	void MoveToGamePlay()
	{
		if (!GamePlayer.activeSelf)
			GamePlayer.SetActive(true);
	}


	#region Set Methods

		//[Header("변수 설명")]
		void MixCard()
		{
			//카드 믹스하는 내용
		}


	#endregion
}
