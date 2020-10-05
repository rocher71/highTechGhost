using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController1f : MonoBehaviour {

    public Text t;

    void talk()
    {
        DialogDataAlert alert = new DialogDataAlert("안뇽, 인덕", "신입생 안녕!! 어서와~", delegate () {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "우와";
            DialogDataAlert alert2 = new DialogDataAlert("안뇽, 인덕", "여긴 하이테크 1층이야!\n많은 공간이 있는 층이지", delegate () {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "응!";
                DialogDataAlert alert3 = new DialogDataAlert("안뇽, 인덕", "지금부터 4곳을 소개해줄게\n잘 구경해봐!", delegate () {
                    Debug.Log("OK Pressed!");

                    t.GetComponent<Text>().text = "알겠어!";
                    DialogDataAlert alert4 = new DialogDataAlert("안뇽, 인덕", "앗 그리고 허공에 떠있는\n회전큐브를 클릭해봐!", delegate () {
                        Debug.Log("OK Pressed!");

                    });
                    DialogManager.Instance.Push(alert4);
                });
                DialogManager.Instance.Push(alert3);

            });
            DialogManager.Instance.Push(alert2);

        });
        DialogManager.Instance.Push(alert);
    }
	// Use this for initialization
	IEnumerator Start () {

        yield return new WaitForSeconds(0.05f);
        talk();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
