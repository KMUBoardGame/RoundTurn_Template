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
		 * MixCards(); // 카드 섞기
		 * SetPlayer(); // 인원수 확인 및 인원수대로 카드 배분
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

		void SetPlayer()
    {
		// 인원수 확인 및 인원수대로 list 만들어서 카드 배분
		// if 딱 안 떨어질 경우 남는 카드 빼기
    }

	#endregion
}
