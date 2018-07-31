using UnityEngine;
using System.Collections;

public class MapHyp : MonoBehaviour
{
    //摄像机
    public GameObject bigCamera;
    //小地图的摄像机
    public Camera smallCamera;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //滚轮控制  
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //控制的范围自行调整
            if (Camera.main.fieldOfView <= 80)
                Camera.main.fieldOfView += 2;
            if (Camera.main.orthographicSize <= 20)
                Camera.main.orthographicSize += 0.5F;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (Camera.main.fieldOfView > 2)
                Camera.main.fieldOfView -= 2;
            if (Camera.main.orthographicSize >= 1)
                Camera.main.orthographicSize -= 0.5F;
        }

        //点击小地图  主摄像会找到和小地图一致的位置
        //将小地图的屏幕坐标转为视口坐标：
        Vector3 v1 = smallCamera.ScreenToViewportPoint(Input.mousePosition);
        //主地图和 小地图重合的位置（根据情况自己设定范围）：
        if ((v1.x >= 0.1f && v1.x <= 0.95f) && (v1.y >= 0.1f && v1.y <= 0.9f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                //视口坐标转为世界坐标
                Vector3 v2 = smallCamera.ViewportToWorldPoint(v1);
                //增加一个 偏移量
                bigCamera.transform.position = new Vector3(v2.x + 13, bigCamera.transform.position.y, v2.z + 11);

            }
        }
        //按F1 键  回到某个物体的视角
        GameObject huan = GameObject.Find("HuanHuan");
        if (Input.GetKey(KeyCode.F1))
        {
            bigCamera.transform.position = new Vector3(huan.transform.position.x + 1, huan.transform.position.y + 1, huan.transform.position.z + 1);
        }
    }
}