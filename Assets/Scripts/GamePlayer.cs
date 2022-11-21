using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
	#region Initialization

	[SerializeField]
	StageDataManager StageData;

	bool[] IsStepFinished;

	[Tooltip("Steps that are using in your game. After finishing current step, the next step will be appeared in the screen.")]
	[SerializeField]
	List<GameObject> StepMaterials;

	[SerializeField]
	GameObject GameFinisher;


	private void Awake()
	{
		IsStepFinished = new bool[StageData.MaxStep];
	}
	private void Start()
	{
		for (int i = 0; i < StageData.MaxStep; i++)
		{
			IsStepFinished[i] = false;
			StepMaterials[i].SetActive(false);
		}

		StepMaterials[0].SetActive(true);
		GameFinisher.SetActive(false);
	}

	#endregion


	private void Update()
	{
		if(StageData.CurrentRound <= StageData.MaxRound)
		{
			switch (StageData.CurrentStep)
			{
				case 1:

					break;

				//~ case MaxStep:	break;
			}
		}
		else
		{
			gameObject.SetActive(false);
			GameFinisher.SetActive(true);
		}
	}



	Vector2 origin, dir;

	#region Step 1

	[Header("Step1 Materials")]
	[SerializeField]
	GameObject Dice;

	void Click(string tagName)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		origin = ray.origin;
		dir = ray.direction;

		RaycastHit2D hit = Physics2D.Raycast(origin, dir);

		if (Input.GetMouseButtonDown(0))
		{
			if (hit.collider != null && hit.transform.tag == tagName)
			{
				//태그 이름을 가진 오브젝트가 클릭됐을 때 실행할 내용
				// 카드 뒤집기(HandCards --> UpperCards, HandCards에서 낸 카드는 삭제)

				// if) HandsCards 리스트에 더이상 카드 없으면 대기(카드 낼 수 없음)
			}
		}
	}

	

	#endregion

	#region Step 2

	[Header("Step2 Materials")]
	[SerializeField]
	GameObject Dice_;

	void ClickRing(string tagName) // 종 치면
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		origin = ray.origin;
		dir = ray.direction;

		RaycastHit2D hit = Physics2D.Raycast(origin, dir);

		if (Input.GetMouseButtonDown(0))
		{
			if (hit.collider != null && hit.transform.tag == tagName)
			{
				//태그 이름을 가진 오브젝트가 클릭됐을 때 실행할 내용
				// 같은 종류 카드 확인 --> 합이 5인지 확인
				// 확인 후 승패 판정
			}
		}
	}

	#endregion

	#region Step 3

	[Header("Step2 Materials")]
	[SerializeField]
	GameObject Dice1_;

	void Click_(string tagName)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		origin = ray.origin;
		dir = ray.direction;

		RaycastHit2D hit = Physics2D.Raycast(origin, dir);

		if (Input.GetMouseButtonDown(0))
		{
			if (hit.collider != null && hit.transform.tag == tagName)
			{
				//태그 이름을 가진 오브젝트가 클릭됐을 때 실행할 내용
			}
		}
	}

	void PlayerCheck() // 추가 함수
    {
		// 카드 개수 0인 사람 탈락 --> 생존자 1명이면 finisher로
		// 아니면 다시 step1로 
    }

	#endregion


	/// <summary>
	/// 한 스텝이 끝날 때마다 호출하는 함수. 해당 스텝이 끝난지 체크하는 bool을 true로 변경, 다음 스텝으로 창을 변경
	/// </summary>
	/// <param name="FinishStep"></param>
	void ProcessFinishStep(int FinishStep)
	{
		IsStepFinished[FinishStep] = true;
		StepMaterials[FinishStep].SetActive(false);

		if (FinishStep < StageData.MaxStep - 1)
		{
			StepMaterials[FinishStep + 1].SetActive(true);
			StageData.CurrentStep++;
		}
		else
		{
			//마지막 스텝일 경우 스텝 1의 창을 켜고 스텝 데이터를 1로 변경
			StepMaterials[0].SetActive(true);
			StageData.CurrentStep = 1;
		}
	}

	/// <summary>
	/// 한 라운드가 끝날 때마다 호출하는 함수. 현재 라운드의 어떤 스텝이 끝났는지 체크하는 리스트 초기화, 현재 라운드+=1
	/// </summary>
	void ProcessFinishRound()
	{
		for (int i = 0; i < StageData.MaxStep; i++)
		{
			IsStepFinished[i] = false;
		}


		//라운드에서 쓰였던 요소들 초기화

		StageData.CurrentRound++;
	}




	/// <summary>
	/// Attach StepPass Prefab in the step you want to pass by click
	/// </summary>
	void PassStepForTest(int i)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		origin = ray.origin;
		dir = ray.direction;

		RaycastHit2D hit = Physics2D.Raycast(origin, dir);

		if (Input.GetMouseButtonDown(0))
		{
			if (hit.collider != null && hit.collider.name == "StepPass")
			{
				if(i != StageData.MaxStep-1)
					ProcessFinishStep(i);
				else
				{
					ProcessFinishStep(i);
					ProcessFinishRound();
				}
			}
		}
	}
}
