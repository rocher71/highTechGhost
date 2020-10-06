using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{

    //public GameObject Panel;
    /*
    public void hidePanel()
    {
        Panel.gameObject.SetActive(true);
    }*/

    void OnMouseDown()
    {
        Debug.Log("clicked");
       // hidePanel();
        DialogDataAlert alert = new DialogDataAlert("대학원생 김논문(26)", "대학원...오지마........\n살려줘.....", delegate () {
            Debug.Log("OK Pressed!");

            /*
			DialogDataConfirm confirm = new DialogDataConfirm("대학원생 김논문(26)", "내가 지금 막학기여서 캡스톤을 하는데.. 파일을 merge하다 충돌이 일어났어.. 오류메세지를 검색하고 싶은데 와이파이 비밀번호를 몰라 구글링하지 못하고있어..", 
				delegate(bool yn) {
					if(yn){
						Debug.Log("Confirm OK");
					}else{
						Debug.Log("Confirm Cancel");
						
					}
				
			});
			
			DialogManager.Instance.Push(confirm);
            */

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
