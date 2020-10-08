using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check1f3 : MonoBehaviour
{


    public Text t;
    public GameObject player;
    void OnMouseDown()
    {
        Debug.Log("clicked");
        player.GetComponent<FirstPlayerController>().enabled = false;
        t.GetComponent<Text>().text = "아카?";
        DialogDataAlert alert = new DialogDataAlert("1층 - 아카", "이 안은 아카, 그리고\n바로 문밖은 아카앞이라고 해", delegate () {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "아하";
            DialogDataAlert alert2 = new DialogDataAlert("1층 - 아카", "IT카페를 줄여서 아카라고해", delegate () {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "오호..!";
                DialogDataAlert alert3 = new DialogDataAlert("1층 - 아카", "이곳은 학생증이 있어야\n들어갈 수 있어!", delegate () {
                    Debug.Log("OK Pressed!");

                    t.GetComponent<Text>().text = "좋네!";
                    DialogDataAlert alert4 = new DialogDataAlert("1층 - 아카", "그리고 아카에선 커피를 마시고\n공부하고 프린트하는게 가능해!", delegate () {
                        Debug.Log("OK Pressed!");

                        t.GetComponent<Text>().text = "헉 여기서?";
                        DialogDataAlert alert5 = new DialogDataAlert("1층 - 아카", "응 그리고 여기 아카앞에선\n책상이 있어서 공부도 가능해!", delegate () {
                            Debug.Log("OK Pressed!");

                            t.GetComponent<Text>().text = "오오오!";
                            DialogDataAlert alert6 = new DialogDataAlert("1층 - 아카", "밤늦게 공부할 수도 있고\n콘센트도 있어서 좋아!", delegate () {
                                Debug.Log("OK Pressed!");

                                t.GetComponent<Text>().text = "알겠어";
                                DialogDataAlert alert7 = new DialogDataAlert("1층 - 아카", "자 이제 다음 장소로 가보자!", delegate () {
                                    Debug.Log("OK Pressed!");
                                    player.GetComponent<FirstPlayerController>().enabled = true;
                                });
                                DialogManager.Instance.Push(alert7);

                            });
                            DialogManager.Instance.Push(alert6);

                        });
                        DialogManager.Instance.Push(alert5);

                    });
                    DialogManager.Instance.Push(alert4);

                });
                DialogManager.Instance.Push(alert3);

            });
            DialogManager.Instance.Push(alert2);

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
