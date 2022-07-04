using UnityEngine;

namespace KitsuneYuki
{
    public class ManagePass : MonoBehaviour
    {
        [SerializeField] string target_name = "§ÔªÌµì";
        [SerializeField] SystemRun system_run;
        [SerializeField] SystemJump system_jump;
        [SerializeField] SummaryScreen summary_ctl;
        [SerializeField] string string_title_text;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(target_name))
            {
                system_run.enabled = false;
                system_jump.enabled = false;
                summary_ctl.string_title = string_title_text;
                summary_ctl.enabled = true;
            }
        }
    }
}
