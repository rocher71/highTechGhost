using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check1f4 : MonoBehaviour
{


    public Text t;
    public Text cor;
    public Text wrong;


    void OnMouseDown()
    {
        Debug.Log("clicked");

        t.GetComponent<Text>().text = "엉?";
        DialogDataAlert alert = new DialogDataAlert("1층 - ???", "여긴 어디일 것 같아?", delegate () {
            Debug.Log("OK Pressed!");

            cor.GetComponent<Text>().text = "음..휴게실?";
            wrong.GetComponent<Text>().text = "음..훈련장?";
            DialogDataConfirm confirm = new DialogDataConfirm("1층 - ???", "한번 맞춰봐!",
             delegate (bool yn) {
                 if (yn)
                 {
                     Debug.Log("Confirm OK");

                     t.GetComponent<Text>().text = "뭐야 너";
                     DialogDataAlert yes = new DialogDataAlert("1층 - ???", "맞아! 그 중에서 여자휴게실이지", delegate () {
                         Debug.Log("OK Pressed!");

                         t.GetComponent<Text>().text = "ㅇㅎ";
                         DialogDataAlert yes2 = new DialogDataAlert("1층 - 여휴", "줄여서 여휴라고 불러", delegate () {
                             Debug.Log("OK Pressed!");

                             t.GetComponent<Text>().text = "응그래.";
                             DialogDataAlert yes3 = new DialogDataAlert("1층 - 여휴", "남휴는 윗층에 있는데..\n(제작자가)여자라 잘모르겠오!", delegate () {
                                 Debug.Log("OK Pressed!");

                                 t.GetComponent<Text>().text = "머락우??";
                                 DialogDataAlert yes4 = new DialogDataAlert("1층 - 여휴", "헷 어쨌든 여긴 잠자는 곳이야!", delegate () {
                                     Debug.Log("OK Pressed!");

                                     t.GetComponent<Text>().text = "와...";
                                     DialogDataAlert yes5 = new DialogDataAlert("1층 - 여휴", "밤샘공부하고 시험치기전에\n자면 딱 좋아!!", delegate () {
                                         Debug.Log("OK Pressed!");

                                         t.GetComponent<Text>().text = "알겠어!";
                                         DialogDataAlert yes6 = new DialogDataAlert("1층 - 여휴", "이불, 베게, 콘센트, 보일러\n다 있으니까 한번 써봐!", delegate () {
                                             Debug.Log("OK Pressed!");

                                             t.GetComponent<Text>().text = "가자!!";
                                             DialogDataAlert yes7 = new DialogDataAlert("1층 - 여휴", "자 이제 다음 곳으로 가자!", delegate () {
                                                 Debug.Log("OK Pressed!");
                                             });
                                             DialogManager.Instance.Push(yes7);
                                         });
                                         DialogManager.Instance.Push(yes6);
                                     });
                                     DialogManager.Instance.Push(yes5);
                                 });
                                 DialogManager.Instance.Push(yes4);
                             });
                             DialogManager.Instance.Push(yes3);
                         });
                         DialogManager.Instance.Push(yes2);
                     });
                     DialogManager.Instance.Push(yes);

                 }
                 else
                 {
                     Debug.Log("Confirm OK");

                     t.GetComponent<Text>().text = "???";
                     DialogDataAlert yes = new DialogDataAlert("1층 - ???", "뿌뿌! 다시 도전해봐!", delegate () {
                         Debug.Log("OK Pressed!");

                         t.GetComponent<Text>().text = "으..응";
                         DialogDataAlert yes2 = new DialogDataAlert("1층 - ???", "날 다시 클릭해보라구!", delegate () {
                             Debug.Log("OK Pressed!");
                         });
                         DialogManager.Instance.Push(yes2);
                     });
                     DialogManager.Instance.Push(yes);

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
