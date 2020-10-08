using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check10f : MonoBehaviour
{

    public GameObject player;
    public Text t;
   

    void OnMouseDown()
    {
        Debug.Log("clicked");
        player.GetComponent<playerctr>().enabled = false;
        t.GetComponent<Text>().text = "우왕";
        DialogDataAlert window1 = new DialogDataAlert("10층 - 엘베", "와! 여긴 10층이야.", delegate () {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "예쁘다!";
            DialogDataAlert window2 = new DialogDataAlert("10층 - 엘베", "이 창문을 통해 학교 건물을 볼 수 있어!", delegate () {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "그렇군요!";
                DialogDataAlert window3 = new DialogDataAlert("10층 - 엘베", "왼쪽에 보이는 높은 건물이\n60주년 기념관이야!", delegate ()
                {
                    Debug.Log("OK Pressed!");
                    player.GetComponent<playerctr>().enabled = true;

                });
                DialogManager.Instance.Push(window3);

            });
            DialogManager.Instance.Push(window2);

        });
        DialogManager.Instance.Push(window1);
        
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
