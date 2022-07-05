using UnityEngine;

namespace KitsuneYuki
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料
        [SerializeField, Tooltip("跑步速度"), Range(0, 10f)]
        private float run_speed = 3.5f;
        private Animator anim_ctl;
        private Rigidbody2D body_ctl;
        SpriteRenderer sprite;
        Vector2 direction, velocity;
        #endregion

        #region 方法
        private void Awake()
        {
            anim_ctl = GetComponent<Animator>();
            body_ctl = GetComponent<Rigidbody2D>();
            sprite = GetComponent<SpriteRenderer>();
        }
        private void Update()
        {
            run();
        }
        private void FixedUpdate()
        {
            velocity = Vector2.Lerp(velocity, direction * run_speed, 0.2f);
            body_ctl.velocity = new Vector2(velocity.x, body_ctl.velocity.y);
            animation_ctrl();
        }
        private void OnDisable()
        {
            body_ctl.velocity = Vector2.zero;
        }
        #endregion

        #region 複雜功能
        void run()
        {
            direction = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        }
        void animation_ctrl()
        {
            anim_ctl.SetFloat("run_speed", direction.x * 1.5f);
            if (direction.x != 0)
            {
                if (direction.x > 0)
                {
                    sprite.flipX = false;
                }
                else
                {
                    sprite.flipX = true;
                }
            }
        }
        #endregion
    }
}
