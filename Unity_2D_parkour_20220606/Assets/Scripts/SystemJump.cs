using UnityEngine;

namespace KitsuneYuki
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Tooltip("跳躍高度"), Range(0, 1000)]
        private float jump_height = 350;
        private Animator anim_ctl;
        private Rigidbody2D body_ctl;
        bool is_jumping = false;
        bool can_jump = false;
        [SerializeField] Vector3 detect_floor = Vector3.one;
        [SerializeField] Vector3 detect_floor_offset;
        [SerializeField] Color detect_floor_color = new Color(1f, 0, 0.2f, 0.5f);
        [SerializeField] LayerMask detect_floot_layer;
        #endregion

        #region 方法
        private void OnDrawGizmos()
        {
            Gizmos.color = detect_floor_color;
            Gizmos.DrawCube(transform.position + detect_floor_offset , detect_floor);
        }
        private void Awake()
        {
            anim_ctl = GetComponent<Animator>();
            body_ctl = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            jump_ctl();
        }
        private void FixedUpdate()
        {
            jump();
            check_ground();
        }
        #endregion

        #region 複雜功能
        void jump_ctl()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                is_jumping = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                is_jumping = false;
            }
        }
        void jump()
        {
            if (is_jumping && can_jump)
            {
                body_ctl.AddForce(new Vector2(0 , jump_height));
                is_jumping = false;
            }
        }
        void check_ground()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + detect_floor_offset, detect_floor , 0 , detect_floot_layer);
            can_jump = hit;
        }
        #endregion
    }
}
