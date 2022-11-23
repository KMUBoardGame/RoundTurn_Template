using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDataManager : MonoBehaviour
{
	// ������, �ٳ���, �ڵ�, ���� �� ī�� ���� �̸�
	List<string> cardName = new List<string>() { "Peach", "Banana" , "Plum", "Lime" };

	// ������ 0, �ٳ��� 5... �� ī�� ��ü
	public List<string> cards = new List<string>();


	// �÷��̾� ����Ʈ
	public List<List<string>> UserCards = new List<List<string>>();


	public int PlayerNum;

	public List<string> LeftOverCards = new List<string>();

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

		for(int i = 0; i<4; i++)
        {
			string cardType = cardName[i];
			for(int a = 0; a<5; a++)
            {
				cards.Add(cardType + '1');
            }
			for (int b = 0; b<3; b++)
            {
				cards.Add(cardType + '2');
				cards.Add(cardType + '3');
            }
			for(int c = 0; c<2; c++)
            {
				cards.Add(cardType + '4');
            }
			cards.Add(cardType + '5');
        }

		/*for(int i = 0; i<cards.Count; i++)
        {
			Debug.Log(cards[i]);
        }*/


		//���� ���� �ʱ�ȭ

		// ��ü ī��




	}
}
