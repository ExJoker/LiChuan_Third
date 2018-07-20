using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoMoveScript02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.name == "2ed")
        {
            if (collision.tag == "Line")
            {
                Tween tweener =  transform.DOLocalMoveX(130, 0.5f);
                tweener.SetEase(Ease.Linear);
            }
        }

    }

  
}
