using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLegColliderScript : MonoBehaviour
{
    PlayerMoveScript playerMoveScript;  //�����̃X�N���v�g

    // Start is called before the first frame update
    void Start()
    {
        playerMoveScript = this.transform.parent.GetComponent<PlayerMoveScript>();   //����X�N���v�g�̎擾
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //�n�ʂ��痣�ꂽ��
        if (collision.transform.tag == "Ground") { playerMoveScript.setIsGround(false); }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        //�n�ʂɂ��Ă���Ȃ�
        if (collision.transform.tag == "Ground") { playerMoveScript.setIsGround(true); }
    }
}
