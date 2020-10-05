using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check10f4 : MonoBehaviour
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


        t.GetComponent<Text>().text = "네!";
        DialogDataAlert chang1 = new DialogDataAlert("10층 - 창문", "풍경이 예쁘지?", delegate ()
        {
            Debug.Log("OK Pressed!");

            t.GetComponent<Text>().text = "next";
            DialogDataAlert chang2 = new DialogDataAlert("10층 - 창문", "이 창문을 통해 후문 전체거리를\n한 눈에 볼 수 있어", delegate ()
            {
                Debug.Log("OK Pressed!");

                t.GetComponent<Text>().text = "꼭 가볼게요";
                DialogDataAlert chang3 = new DialogDataAlert("10층 - 창문", "후문에 놀거리가 참 많아!\n나중에 꼭 가봐~", delegate ()
                {
                    Debug.Log("OK Pressed!");

                });
                DialogManager.Instance.Push(chang3);

            });
            DialogManager.Instance.Push(chang2);

        });
        DialogManager.Instance.Push(chang1);


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
