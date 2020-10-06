using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class up_10f : MonoBehaviour
{


    public Text t;
    public Text cor;
    public Text wrong;


    void OnMouseDown()
    {
        Debug.Log("clicked");

        cor.GetComponent<Text>().text = "응!";
        wrong.GetComponent<Text>().text = "아니!";
        DialogDataConfirm confirm = new DialogDataConfirm("안뇽, 인덕", "윗 층으로 올라갈래?",
         delegate (bool yn) {
             if (yn)
             {
                 Debug.Log("Confirm OK");

                 t.GetComponent<Text>().text = "고마워";
                 DialogDataAlert yes = new DialogDataAlert("안뇽, 인덕", "그럼 보내줄게!", delegate () {
                     Debug.Log("OK Pressed!");
                     SceneManager.LoadScene("15f_dialog");
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
