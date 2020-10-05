using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check1f2 : MonoBehaviour
{


    public Text t;

    void OnMouseDown()
    {
        Debug.Log("clicked");

        t.GetComponent<Text>().text = "우왕";
        DialogDataAlert alert = new DialogDataAlert("1층 - 120", "여긴 120실이야!\n수업을 듣는 강의실이지", delegate () {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "그렇구나";
            DialogDataAlert alert2 = new DialogDataAlert("1층 - 120", "꽤 많은 인원을 수용해!", delegate () {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "그래!";
                DialogDataAlert alert3 = new DialogDataAlert("1층 - 120", "한번 들어가서 구경해봐!", delegate () {
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
