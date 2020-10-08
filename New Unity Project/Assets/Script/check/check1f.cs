using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check1f : MonoBehaviour
{

  
    public Text t;
    public Text cor;
    public Text wrong;
    public GameObject player;

    void OnMouseDown()
    {
        Debug.Log("clicked");
        player.GetComponent<FirstPlayerController>().enabled = false;
        t.GetComponent<Text>().text = "그게뭐야?";
        DialogDataAlert alert = new DialogDataAlert("1층 - 공도&스룸", "여기엔 공도과 스룸이 있어", delegate () {
            Debug.Log("OK Pressed!");
            
            t.GetComponent<Text>().text = "아하";
            DialogDataAlert alert2 = new DialogDataAlert("1층 - 공도&스룸", "공도는 공대도서관,\n스룸은 스터디룸이야!", delegate () {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "헉 ㄷㄷ";
                DialogDataAlert alert3 = new DialogDataAlert("1층 - 공도&스룸", "스룸에선 다같이 공부를\n공도에선 개인공부를 하지!", delegate () {
                    Debug.Log("OK Pressed!");

                    cor.GetComponent<Text>().text = "그건 좀..";
                    wrong.GetComponent<Text>().text = "응! 나 공부좋아해!";
                    DialogDataConfirm confirm = new DialogDataConfirm("1층 - 공도&스룸", "앞으로 여기서 열심히 공부해보자!",
                     delegate (bool yn) {
                        if (yn)
                        {
                            Debug.Log("Confirm OK");

                            t.GetComponent<Text>().text = "뭐야 너";
                            DialogDataAlert yes = new DialogDataAlert("1층 - 공도&스룸", "사실 나도 그렇게 생각해", delegate () {
                                Debug.Log("OK Pressed!");

                                t.GetComponent<Text>().text = "알겠어";
                                DialogDataAlert yes2 = new DialogDataAlert("1층 - 공도&스룸", "하지만 나도 공부는 싫어..\n자 다음 장소로 가보자!", delegate () {
                                    Debug.Log("OK Pressed!");
                                    player.GetComponent<FirstPlayerController>().enabled = true;
                                });
                                DialogManager.Instance.Push(yes2);
                            });
                            DialogManager.Instance.Push(yes);

                        }
                        else
                        {
                             Debug.Log("Confirm OK");

                             t.GetComponent<Text>().text = "그런데..?";
                             DialogDataAlert yes = new DialogDataAlert("1층 - 공도&스룸", "응? 정말이야????", delegate () {
                                 Debug.Log("OK Pressed!");

                                 t.GetComponent<Text>().text = "(tmi..)";
                                 DialogDataAlert yes2 = new DialogDataAlert("1층 - 공도&스룸", "너 정말 대단한 아이구나?\n난 사실 공부가 싫은데..", delegate () {
                                     Debug.Log("OK Pressed!");

                                     t.GetComponent<Text>().text = "어 응..";
                                     DialogDataAlert yes3 = new DialogDataAlert("1층 - 공도&스룸", "큼.. 자 다른 장소로 가보자!", delegate () {
                                         Debug.Log("OK Pressed!");
                                         player.GetComponent<FirstPlayerController>().enabled = true;
                                     });
                                     DialogManager.Instance.Push(yes3);
                                 });
                                 DialogManager.Instance.Push(yes2);
                             });
                             DialogManager.Instance.Push(yes);

                         }

                });

                    DialogManager.Instance.Push(confirm);

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
