using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check7f : MonoBehaviour
{

    public GameObject Panel;
    public Text t;
    public Text cor;
    public Text wrong;
    public void hidePanel()
    {
        Panel.gameObject.SetActive(true);
    }

    void OnMouseDown()
    {
        Debug.Log("clicked");
        hidePanel();
        t.GetComponent<Text>().text = "ㅇ..알겠어요";
        DialogDataAlert alert = new DialogDataAlert("대학원생 김논문(26)", "대학원...오지마........\n살려줘.....", delegate () {
            Debug.Log("OK Pressed!");

            cor.GetComponent<Text>().text = "26";
            wrong.GetComponent<Text>().text = "27";
            DialogDataConfirm confirm = new DialogDataConfirm("대학원생 김논문(??)", "그런데 너 내 나이 기억해?", 
				delegate(bool yn) {
					if(yn){
						Debug.Log("Confirm OK");

                        t.GetComponent<Text>().text = "헷!";
                        DialogDataAlert yes = new DialogDataAlert("대학원생 김논문(!26!)", "정답이야!", delegate () {
                            
                            Debug.Log("OK Pressed!");
                        });
                        DialogManager.Instance.Push(yes);

                    }
                    else{
						Debug.Log("Confirm Cancel");

                        t.GetComponent<Text>().text = "(알게뭐야..)";
                        DialogDataAlert no = new DialogDataAlert("대학원생 김논문(!26!)", "틀렸어.. 후배님 실망이야", delegate () {

                            Debug.Log("OK Pressed!");
                        });
                        DialogManager.Instance.Push(no);

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
