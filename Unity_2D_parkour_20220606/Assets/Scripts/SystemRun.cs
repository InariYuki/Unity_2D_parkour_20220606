using UnityEngine;

namespace KitsuneYuki
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料
        [SerializeField , Tooltip("跑步速度") , Range(0 , 5f)] 
        private float run_speed = 3.5f;
        private Animator anim_ctl;
        private Rigidbody2D body_ctl;
        #endregion

        #region 複雜功能
        void run()
        {
            body_ctl.velocity = new Vector2(run_speed , body_ctl.velocity.y);
        }
        #endregion

        #region 方法
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
