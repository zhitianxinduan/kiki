using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindsHelper : MonoBehaviour {

	public Transform  FindChilds(Transform goParent,string goName)
    {
       
        for(int i=0;i<goParent.childCount;i++)
        {
            if(goParent.GetChild(i).name==goName)
            {
                return goParent.GetChild(i).transform;
            }
            else
            {
                FindChilds(goParent.GetChild(i), goName);
            }
        }
        return null;
    }
    public T Find<T>(Transform goParent,string goName)where T:Component

    {
        for(int i=0;i<goParent.childCount;i++)
        {
            if(goParent.GetChild(i).name==goName)
            {
                if (goParent.GetChild(i).GetComponent<T>() == null)
                    goParent.GetChild(i).gameObject.AddComponent<T>();
                return goParent.GetChild(i).GetComponent<T>();
            }
            else
            {
                Find<T>(goParent.GetChild(i), goName);
            }
        }
        return default(T);
    }
}
