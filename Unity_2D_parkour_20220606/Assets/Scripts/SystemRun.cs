using UnityEngine;

namespace KitsuneYuki
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料
        [SerializeField , Tooltip("跑步速度") , Range(0 , 5f)] private float run_speed = 3.5f;
        [SerializeField , Tooltip("跳躍高度") , Range(0 , 1000)] private float jump_height = 350;
        private Animator anim_ctl;
        private Rigidbody2D body_ctl;
        #endregion

        #region 複雜功能
        #endregion

        #region 方法
        private void Awake()
        {
            anim_ctl = GetComponent<Animator>();
            body_ctl = GetComponent<Rigidbody2D>();
        }
        #endregion
    }
}
