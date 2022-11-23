using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDataManager : MonoBehaviour
{
	// 복숭아, 바나나, 자두, 라임 등 카드 종류 이름
	List<string> cardName = new List<string>() { "Peach", "Banana" , "Plum", "Lime" };

	// 복숭아 0, 바나나 5... 등 카드 전체
	public List<string> cards = new List<string>();


	// 플레이어 리스트
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

		/*	최대 라운드 수 지정하기	*/
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

		/*	최대 스텝 수 지정하기	*/
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


		//라운드 변수 초기화

		// 전체 카드




	}
}
