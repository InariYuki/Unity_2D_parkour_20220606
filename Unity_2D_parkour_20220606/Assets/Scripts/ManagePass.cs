using UnityEngine;

namespace KitsuneYuki
{
    public class ManagePass : MonoBehaviour
    {
        [SerializeField] string target_name = "§ÔªÌµì";
        [SerializeField] SystemRun system_run;
        [SerializeField] SystemJump system_jump;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(target_name))
            {
                system_run.enabled = false;
                system_jump.enabled = false;
            }
        }
    }
}
