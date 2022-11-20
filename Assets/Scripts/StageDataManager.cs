using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDataManager : MonoBehaviour
{
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



		//라운드 변수 초기화
	}
}
