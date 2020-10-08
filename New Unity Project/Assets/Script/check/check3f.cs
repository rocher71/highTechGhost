using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check3f : MonoBehaviour
{

    public GameObject player;
    public Text t;

    

    void OnMouseDown()
    {
        player.GetComponent<playerctr>().enabled = false;
        t.GetComponent<Text>().text = "아하!";
        DialogDataAlert alert = new DialogDataAlert("컴퓨터 실습실 - 322", "여긴 실습수업때 프로그래밍을 하거나 코딩시험을 치는 곳이야", delegate () {
            Debug.Log("OK Pressed!");


            DialogDataConfirm confirm = new DialogDataConfirm("컴퓨터 실습실 - 322", "그럼 여긴 총 몇대의 컴퓨터가 있을까?",
                delegate (bool yn) {
                    if (yn)
                    {
                        t.GetComponent<Text>().text = "제가 좀..ㅎ";
                        DialogDataAlert cor = new DialogDataAlert("컴퓨터 실습실 - 322", "정답이야! 똑똑하구나?", delegate ()
                        {
                            Debug.Log("OK Pressed!");
                            player.GetComponent<playerctr>().enabled = true;
                        });
                        DialogManager.Instance.Push(cor);
                        Debug.Log("Confirm OK");

                    }
                    else
                    {
                        t.GetComponent<Text>().text = "(왜저래..)";
                        DialogDataAlert wrong = new DialogDataAlert("컴퓨터 실습실 - 322", "틀렸어! 흥칫뿡!", delegate ()
                        {
                            Debug.Log("OK Pressed!");
                            player.GetComponent<playerctr>().enabled = true;
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
