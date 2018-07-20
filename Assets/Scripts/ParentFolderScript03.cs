using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class ParentFolderScript03 : MonoBehaviour {


    public bool isOpen;
    Vector3 parentOffset;

    RectTransform parentElemet;

    // Use this for initialization
    public void Init()
    {
        isOpen = false;
        parentOffset = new Vector3(transform.GetComponent<RectTransform>().rect.width/2,0,0);
        GetComponent<Button>().onClick.AddListener(OnClickButton);
    }

    // Update is called once per frame
    void Update() {

    }


    void OnClickButton(){

        if (!isOpen)
        {
            RectTransform obj = Instantiate(Resources.Load<RectTransform>("Scroll View")) ;
            obj.transform.SetParent(transform);
            obj.transform.localScale = new Vector3(0f, 1f, 0);
            obj.localPosition = Vector3.zero +parentOffset ;
            parentElemet = obj;
             parentElemet.DOScaleX(0.7f, 2f);
            isOpen = true;
        }
        else
        {
            Tween tweener =  parentElemet.DOScaleX(0f, 1f);
            tweener.OnComplete(() => { GameManager.Instance.Recovery(); });
            Destroy(parentElemet.gameObject,10f);
            isOpen = false;
        }
    }





}
