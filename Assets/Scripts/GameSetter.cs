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
		 *	Set �Լ��� (ex_ ī�� �����ֱ�)
		 * MixCards(); // ī�� ����
		 * SetPlayer(); // �ο��� Ȯ�� �� �ο������ ī�� ���
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

		//[Header("���� ����")]
		void MixCard()
		{
			//ī�� �ͽ��ϴ� ����
		}

		void SetPlayer()
    {
		// �ο��� Ȯ�� �� �ο������ list ���� ī�� ���
		// if �� �� ������ ��� ���� ī�� ����
    }

	#endregion
}
