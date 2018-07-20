using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    public RectTransform[] parentMax;

    public Transform panel;

    Vector3[] initParentMaxPos;
    Vector3 parentOffset;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        initParentMaxPos = new Vector3[parentMax.Length];
     
        parentOffset = new Vector3(parentMax[0].rect.width,0);
        Init();

	}


    private void Init()
    {
        for (int i = 0; i < parentMax.Length; i++)
        {
            initParentMaxPos[i] = parentMax[i].localPosition;
            parentMax[i].GetComponent<ParentFolderScript03>().Init();
            int j = i;
            parentMax[i].GetComponent<Button>().onClick.AddListener(() => { OnClickButton(j); });
        }
    }

    // Update is called once per frame
    void Update ()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
          
        }
		
	}
    void OnClickButton(int index)
    {
        Debug.Log("====================="+index);
    }


    IEnumerator MenuClose()
    {
        yield return new WaitForSeconds(2f);
    }

    public void Recovery()
    {
        for (int i = 0; i < parentMax.Length; i++)
        {
            Debug.Log("===============" + parentMax.Length);
            parentMax[i].DOLocalMoveX(initParentMaxPos[i].x, 0.5f);
        }
    }

}
