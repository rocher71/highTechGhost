using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class quit_15f : MonoBehaviour
{


    public Text t;
    public Text cor;
    public Text wrong;


    void OnMouseDown()
    {
        Debug.Log("clicked");

        cor.GetComponent<Text>().text = "응!";
        wrong.GetComponent<Text>().text = "아니!";
        DialogDataConfirm confirm = new DialogDataConfirm("안뇽, 인덕", "상담 다 마쳤니?",
         delegate (bool yn) {
             if (yn)
             {
                 Debug.Log("Confirm OK");

                 t.GetComponent<Text>().text = "좋아!";
                 DialogDataAlert yes = new DialogDataAlert("안뇽, 인덕", "그럼 이제 인후가서\n놀자!!", delegate () {
                     Debug.Log("OK Pressed!");
                     Application.Quit();
                 });
                 DialogManager.Instance.Push(yes);

             }
             else
             {
                 Debug.Log("Confirm NO");

                 t.GetComponent<Text>().text = "알겠어";
                 DialogDataAlert no = new DialogDataAlert("안뇽, 인덕", "그럼 나중에 다시 와!", delegate () {
                     Debug.Log("OK Pressed!");

                 });
                 DialogManager.Instance.Push(no);

             }

         });

        DialogManager.Instance.Push(confirm);
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
