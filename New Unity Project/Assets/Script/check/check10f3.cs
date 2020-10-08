using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check10f3 : MonoBehaviour
{

    public GameObject player;
    public Text t;
  

    void OnMouseDown()
    {
        Debug.Log("clicked");
        player.GetComponent<playerctr>().enabled = false;

        t.GetComponent<Text>().text = "오홍";
        DialogDataAlert lap1 = new DialogDataAlert("10층 - 랩실", "이곳은 연구실이야", delegate ()
        {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "짱이다..";
            DialogDataAlert lap2 = new DialogDataAlert("10층 - 랩실", "대학원생들과 교수님이 연구를 하시는 곳이지", delegate ()
            {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "좋네요!";
                DialogDataAlert lap3 = new DialogDataAlert("10층 - 랩실", "우리 학교 컴퓨터공학과에는 다양한 랩실이 있어서\n자신의 연구분야에 맞게 컨택할 수 있어!", delegate ()
                {
                    Debug.Log("OK Pressed!");
                    player.GetComponent<playerctr>().enabled = true;

                });
                DialogManager.Instance.Push(lap3);

            });
            DialogManager.Instance.Push(lap2);

        });
        DialogManager.Instance.Push(lap1);


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
