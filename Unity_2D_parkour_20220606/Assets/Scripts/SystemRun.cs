using UnityEngine;

namespace KitsuneYuki
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���
        [SerializeField , Tooltip("�]�B�t��") , Range(0 , 5f)] private float run_speed = 3.5f;
        [SerializeField , Tooltip("���D����") , Range(0 , 1000)] private float jump_height = 350;
        private Animator anim_ctl;
        private Rigidbody2D body_ctl;
        #endregion

        #region �����\��
        #endregion

        #region ��k
        private void Awake()
        {
            anim_ctl = GetComponent<Animator>();
            body_ctl = GetComponent<Rigidbody2D>();
        }
        #endregion
    }
}
