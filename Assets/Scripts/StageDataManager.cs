using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDataManager : MonoBehaviour
{
	List<int> peaches = new List<int>();
	List<int> bananas = new List<int>();
	List<int> plums = new List<int>();
	List<int> limes = new List<int>();
	List<List<int>> cards = new List<List<int>>();

	[SerializeField]
	int PlayerNum;


	#region Round Data





	int currentRound;
		public int CurrentRound
		{
			get { return currentRound; }
			set { currentRound = value; }
		}

		/*	�ִ� ���� �� �����ϱ�	*/
		int maxRound = 6;

		public int MaxRound
		{
			get { return maxRound; }
		}

	#endregion


	#region Step Data

	int currentStep;
		public int CurrentStep
		{
			get { return currentStep; }
			set { currentStep = value; }
		}

		/*	�ִ� ���� �� �����ϱ�	*/
		int maxStep = 4;
		public int MaxStep
		{
			get { return maxStep; }
		}

	#endregion


	private void Awake()
	{
		currentRound = 1;
		currentStep = 1;



		//���� ���� �ʱ�ȭ
		cards.Add(peaches);
		cards.Add(bananas);
		cards.Add(plums);
		cards.Add(limes);

		for (int index = 0; index < 4; index++)
		{
			// 1: 5�� ����
			for (int cardNum1 = 0; cardNum1 < 5; cardNum1++)
			{
				cards[index].Add(1);
			}

			// 2, 3, 4: 3�� ����
			for (int cardNum234 = 0; cardNum234 < 3; cardNum234++)
			{
				cards[index].Add(2);
				cards[index].Add(3);
				cards[index].Add(4);
			}

			// 5: 1�� ����
			cards[index].Add(5);
		}


		for (int index = 0; index < 4; index++)
		{
			// 1: 5�� ����
			Debug.Log(cards[index]);
			foreach(var num in cards[index])
            {
				Debug.Log(num);
            }

		}

	}
}
