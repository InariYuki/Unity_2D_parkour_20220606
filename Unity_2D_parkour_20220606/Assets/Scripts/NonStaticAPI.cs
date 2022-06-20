using UnityEngine;

namespace KitsuneYuki
{
    public class NonStaticAPI : MonoBehaviour
    {
        [SerializeField]
        GameObject ninja_frog;
        private void Start()
        {
            print("²{¦bª¬ºA" + ninja_frog.activeInHierarchy);
            ninja_frog.tag = "Player";
            ninja_frog.layer = 4;
            ninja_frog.SetActive(false);
        }
    }
}
