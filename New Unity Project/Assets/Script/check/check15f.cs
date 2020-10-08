using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check15f : MonoBehaviour
{

    public GameObject player;
    public Text t;
    public Text cor;
    public Text wrong;
    

    void OnMouseDown()
    {
        Debug.Log("clicked");
        player.GetComponent<playerctr>().enabled = false;
        t.GetComponent<Text>().text = "우왕!";
        DialogDataAlert alert = new DialogDataAlert("15층", "여기가 하이테크 마지막 층이야!", delegate () {
            Debug.Log("OK Pressed!");

            cor.GetComponent<Text>().text = "다시 내려가야지";
            wrong.GetComponent<Text>().text = "지도교수님과 즐거운 상담?";
            DialogDataConfirm confirm = new DialogDataConfirm("15층", "여기서 이제 뭘 해야할까?",
                delegate (bool yn) {
                    if (yn)
                    {
                        Debug.Log("Confirm OK");

                        t.GetComponent<Text>().text = "그런거야?";
                        DialogDataAlert yes = new DialogDataAlert("15층", "안돼! 상담하고 내려가야지ㅎㅎ", delegate () {

                            Debug.Log("OK Pressed!");

                            t.GetComponent<Text>().text = "그래!";
                            DialogDataAlert go = new DialogDataAlert("15층", "응! 그럼 교수님께 가볼까?", delegate () {
                                player.GetComponent<playerctr>().enabled = true;
                                Debug.Log("OK Pressed!");
                            });
                            DialogManager.Instance.Push(go);
                        });
                        DialogManager.Instance.Push(yes);

                    }
                    else
                    {
                        Debug.Log("Confirm Cancel");

                        t.GetComponent<Text>().text = "당연하지!";
                        DialogDataAlert yes = new DialogDataAlert("15층", "잘 알고있구나?ㅎㅎ", delegate () {

                            Debug.Log("OK Pressed!");

                            t.GetComponent<Text>().text = "그래!";
                            DialogDataAlert go = new DialogDataAlert("15층", "그럼 이제 교수님께 가볼까?", delegate () {
                                player.GetComponent<playerctr>().enabled = true;
                                Debug.Log("OK Pressed!");
                            });
                            DialogManager.Instance.Push(go);
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
