using UnityEngine;

namespace KitsuneYuki
{
    public class NonStaticAPI : MonoBehaviour
    {
        /*[SerializeField]
        GameObject ninja_frog;
        [SerializeField]
        Transform start_point;*/
        [SerializeField] Camera cam;
        [SerializeField] SphereCollider scol;
        [SerializeField] Transform capsule;
        private void Start()
        {
            print(cam.depth);
            print(scol.radius);
            capsule.localScale = new Vector3(3 , 2 , 1);
            Color color = new Color();
            color.r = Random.Range(0f , 1f);
            color.g = Random.Range(0f , 1f);
            color.b = Random.Range(0f , 1f);
            cam.backgroundColor = color;

            /*print("�{�b���A" + ninja_frog.activeInHierarchy);
            ninja_frog.tag = "Player";
            ninja_frog.layer = 4;
            ninja_frog.SetActive(false);
            print(start_point.position);
            start_point.position = new Vector3(-3.152f , 5f , 0);*/
        }
        private void Update()
        {
            /*start_point.Translate(1f , 0 , 0);
            start_point.Rotate(0 , 0 , 3.5f);*/
        }
    }
}
