using UnityEngine;
using System.Collections;

public class PlayerFox : MonoBehaviour
{
    #region ���
    [Header("���ʳt��") , Range(0,50)]
    public float speed = 10.5f;
    /// <summary>
    /// �ϥ� Input.GetAxisRaw API �������a���k����
    /// </summary>
    public float Horizontal;

    /// <summary>
    /// �ϥ� SpriteRenderer.flipX API �����W�i�H½��
    /// </summary>
    public bool flipX;

    private Rigibody2D Rig;
    private SpriteRender Sr;




    #endregion

    #region �ƥ�

    public void Start()
    {
        //  Rig = GetComponent<Rigidbody2D>();
        //  Sr = GetComponent<SpriteRender>();
    }

    public void Update()
    {
        /** �Ĥ@������
        //float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        //transform.Rotate(0, speed, 0);
        */


        /** �ĤG������
        //float h = horizontalSpeed * Input.GetAxis("Mouse X");
        //float v = verticalSpeed * Input.GetAxis("Mouse Y");
        //transform.Rotate(v, h, 0);
        */


    }

    public void FixedUpdate()
{

}


#endregion

#region ��k



#endregion
}
