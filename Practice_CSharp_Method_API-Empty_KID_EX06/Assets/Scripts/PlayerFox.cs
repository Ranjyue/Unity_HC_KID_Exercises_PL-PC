using UnityEngine;
using System.Collections;

public class PlayerFox : MonoBehaviour
{
    #region 欄位
    [Header("移動速度") , Range(0,50)]
    public float speed = 10.5f;
    /// <summary>
    /// 使用 Input.GetAxisRaw API 偵測玩家左右按鍵
    /// </summary>
    public float Horizontal;

    /// <summary>
    /// 使用 SpriteRenderer.flipX API 讓狐狸可以翻面
    /// </summary>
    public bool flipX;

    private Rigibody2D Rig;
    private SpriteRender Sr;




    #endregion

    #region 事件

    public void Start()
    {
        //  Rig = GetComponent<Rigidbody2D>();
        //  Sr = GetComponent<SpriteRender>();
    }

    public void Update()
    {
        /** 第一次嘗試
        //float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        //transform.Rotate(0, speed, 0);
        */


        /** 第二次嘗試
        //float h = horizontalSpeed * Input.GetAxis("Mouse X");
        //float v = verticalSpeed * Input.GetAxis("Mouse Y");
        //transform.Rotate(v, h, 0);
        */


    }

    public void FixedUpdate()
{

}


#endregion

#region 方法



#endregion
}
