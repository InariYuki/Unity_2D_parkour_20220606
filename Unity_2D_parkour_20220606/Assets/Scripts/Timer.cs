using UnityEngine;

namespace KitsuneYuki
{
    public class Timer : MonoBehaviour
    {
        [HideInInspector] public float time_elapsed = 0;
        private void FixedUpdate()
        {
            time_elapsed += Time.deltaTime;
        }
    }
}
