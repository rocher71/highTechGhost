using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check10f2 : MonoBehaviour
{

    public GameObject player;
    public Text t;
    

    void OnMouseDown()
    {
        Debug.Log("clicked");
       
        player.GetComponent<playerctr>().enabled = false;
        t.GetComponent<Text>().text = "그러네요!";
        DialogDataAlert gwasa1 = new DialogDataAlert("10층 - 과사", "이곳은 과사무실이야! 직원분들이 계시네", delegate ()
        {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "아하";
            DialogDataAlert gwasa2 = new DialogDataAlert("10층 - 과사", "과사무실에서는 수강지도, 공문, 졸업요건 등\n 여러 행정사항이나 질문을 문의할 수 있어!", delegate ()
            {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "알겠어요!";
                DialogDataAlert gwasa3 = new DialogDataAlert("10층 - 과사", "정확한 위치는 하이테크 1012호야!\n전화번호는 032-860-7440(학부)란다", delegate ()
                {
                    Debug.Log("OK Pressed!");
                    player.GetComponent<playerctr>().enabled = true;
                });
                DialogManager.Instance.Push(gwasa3);

            });
            DialogManager.Instance.Push(gwasa2);

        });
        DialogManager.Instance.Push(gwasa1);

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
