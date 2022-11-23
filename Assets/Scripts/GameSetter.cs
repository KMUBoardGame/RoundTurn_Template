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
		 *	Set �Լ��� (ex_ ī�� �����ֱ�)
		 * MixCards(); // ī�� ����
		 * SetPlayer(); // �ο��� Ȯ�� �� �ο������ ī�� ���
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

	//[Header("���� ����")]

	void SetPlayer()
	{

		//�÷��̾� ����ŭ �������� ������
		for (int i = 0; i < playerNum; i++)
		{
			StageData.UserCards.Add(new List<string>());
		}
	}

	void MixCard()
	{

		List<string> HandoutCards = StageData.cards;

		//������ �����ǿ� ī�带 �������� ���� ���� �й�
		int leftOverCard = StageData.cards.Count % playerNum; // ���� ī��

		// �ο�����ŭ ���� �й�
		while(HandoutCards.Count>leftOverCard)
        {
			for(int i = 0; i<playerNum; i++)
            {
				int randomIndex = Random.Range(0, HandoutCards.Count);

				StageData.UserCards[i].Add(HandoutCards[randomIndex]);
				HandoutCards.RemoveAt(randomIndex);

            }
        }

		// ���� ī�� ���� 
		foreach(var LeftCard in HandoutCards)
        {
			StageData.LeftOverCards.Add(LeftCard);
			//Debug.Log(LeftCard);
		}
	}




	#endregion
}
