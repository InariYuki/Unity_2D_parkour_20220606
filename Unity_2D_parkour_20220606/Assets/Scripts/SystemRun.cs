using UnityEngine;

namespace KitsuneYuki
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���
        [SerializeField , Tooltip("�]�B�t��") , Range(0 , 5f)] 
        private float run_speed = 3.5f;
        private Animator anim_ctl;
        private Rigidbody2D body_ctl;
        #endregion

        #region �����\��
        void run()
        {
            body_ctl.velocity = new Vector2(run_speed , body_ctl.velocity.y);
        }
        #endregion

        #region ��k
        private void Awake()
        {
            anim_ctl = GetComponent<Animator>();
            body_ctl = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            run();
        }
        #endregion
    }
}
