using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check15f2 : MonoBehaviour
{

    public GameObject Panel;
    public Text t;
    public void hidePanel()
    {
        Panel.gameObject.SetActive(true);
    }

    void OnMouseDown()
    {
        Debug.Log("clicked");
        hidePanel();
        t.GetComponent<Text>().text = "뭘 하면 돼?";
        DialogDataAlert alert = new DialogDataAlert("15층 - 교수실", "교수님이 널 기다리고 계셔!", delegate () {
            Debug.Log("OK Pressed!");


            t.GetComponent<Text>().text = "아하!";
            DialogDataAlert one = new DialogDataAlert("15층 - 교수실", "교수님과 진로, 학업 등\n얘기하면 돼!", delegate ()
            {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "알겠어!";
                DialogDataAlert two = new DialogDataAlert("15층 - 교수실", "그리고 상담을 해야 나중에 성적을\n빨리 확인할 수 있어!", delegate ()
                {
                    Debug.Log("OK Pressed!");


                    t.GetComponent<Text>().text = "고마워~ 안뇽!";
                    DialogDataAlert three = new DialogDataAlert("15층 - 교수실", "그래 그럼 잘 하고 와!", delegate ()
                    {
                        Debug.Log("OK Pressed!");

                    });
                    DialogManager.Instance.Push(three);

                });
                DialogManager.Instance.Push(two);

            });
            DialogManager.Instance.Push(one);

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
