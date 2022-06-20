using UnityEngine;

namespace KitsuneYuki
{
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Tooltip("���D����"), Range(0, 1000)]
        private float jump_height = 350;
        private Animator anim_ctl;
        private Rigidbody2D body_ctl;
        bool is_jumping = false;
        #endregion

        #region �����\��
        void jump_ctl()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                is_jumping = true;
            }
        }
        void jump()
        {
            if (is_jumping)
            {
                body_ctl.AddForce(new Vector2(0 , jump_height));
                is_jumping = false;
            }
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
            jump_ctl();
        }
        private void FixedUpdate()
        {
            jump();
        }
        #endregion
    }
}
