using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check3f : MonoBehaviour
{

    public GameObject Panel;
    public void hidePanel()
    {
        Panel.gameObject.SetActive(true);
    }

    void OnMouseDown()
    {
        DialogDataAlert alert = new DialogDataAlert("컴퓨터 실습실 - 322", "여긴 실습수업때 프로그래밍을 하거나 코딩시험을 치는 곳이야", delegate () {
            Debug.Log("OK Pressed!");


            DialogDataConfirm confirm = new DialogDataConfirm("컴퓨터 실습실 - 322", "그럼 여긴 총 몇대의 컴퓨터가 있을까?",
                delegate (bool yn) {
                    if (yn)
                    {
                        DialogDataAlert cor = new DialogDataAlert("컴퓨터 실습실 - 322", "정답이야! 다음 층으로 갈 수 있게 해줄게", delegate ()
                        {
                            Debug.Log("OK Pressed!");
                        });
                        DialogManager.Instance.Push(cor);
                        Debug.Log("Confirm OK");

                    }
                    else
                    {
                        DialogDataAlert wrong = new DialogDataAlert("컴퓨터 실습실 - 322", "틀렸어! 다시 시작하자", delegate ()
                        {
                            Debug.Log("OK Pressed!");
                        });
                        DialogManager.Instance.Push(wrong);
                        Debug.Log("Confirm Cancel");

                    }

                });

            DialogManager.Instance.Push(confirm);

        });
        DialogManager.Instance.Push(alert);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
