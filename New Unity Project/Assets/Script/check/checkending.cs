using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkending : MonoBehaviour
{


    public Text t;

    void OnMouseDown()
    {
        Debug.Log("clicked");

        t.GetComponent<Text>().text = "우왕!!드디어 하이테크에서 나왔어!";
        DialogDataAlert alert = new DialogDataAlert("인후", "여긴 인하대 후문이야!!/n보통 줄여서 인후라고 부르지", delegate () {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "그렇구나";
            DialogDataAlert alert2 = new DialogDataAlert("인후", "수업 다 듣고 후문에서 밥도 먹고 술도 마실 수 있어!!/n즐길거리가 아주 많아!", delegate () {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "그래!";
                DialogDataAlert alert3 = new DialogDataAlert("인후", "꼭 한번 즐겨봤으면 좋겠어!!/n그럼 안녕!!!", delegate () {
                    Debug.Log("OK Pressed!");


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
