using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSetter : MonoBehaviour
{
	int playerNum;
	[SerializeField]
	StageDataManager StageData;

	void Start()
    {
		playerNum = StageData.PlayerNum;
		/*
		 *	Set 함수들 (ex_ 카드 나눠주기)
		 * MixCards(); // 카드 섞기
		 * SetPlayer(); // 인원수 확인 및 인원수대로 카드 배분
		 * 
		 * */
		SetPlayer();
		MixCard();


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

	void SetPlayer()
	{

		//플레이어 수만큼 게임판을 나눠줌
		for (int i = 0; i < playerNum; i++)
		{
			StageData.UserCards.Add(new List<string>());
		}
	}

	void MixCard()
	{

		List<string> HandoutCards = StageData.cards;

		//나눠준 게임판에 카드를 랜덤으로 같은 수량 분배
		int leftOverCard = StageData.cards.Count % playerNum; // 남는 카드

		// 인원수만큼 랜덤 분배
		while(HandoutCards.Count>leftOverCard)
        {
			for(int i = 0; i<playerNum; i++)
            {
				int randomIndex = Random.Range(0, HandoutCards.Count);

				StageData.UserCards[i].Add(HandoutCards[randomIndex]);
				HandoutCards.RemoveAt(randomIndex);

            }
        }

		// 남는 카드 저장 
		foreach(var LeftCard in HandoutCards)
        {
			StageData.LeftOverCards.Add(LeftCard);
			//Debug.Log(LeftCard);
		}
	}




	#endregion
}
