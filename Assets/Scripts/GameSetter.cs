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


	#endregion
}
