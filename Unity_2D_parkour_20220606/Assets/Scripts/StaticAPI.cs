using UnityEngine;

namespace KitsuneYuki
{
    /// <summary>
    /// ÀRºAAPI
    /// </summary>
    public class StaticAPI : MonoBehaviour
    {
        private void Start()
        {
            /*print("random value is" + Random.value);
            print("an extremely small number is" + Mathf.Epsilon);
            print($"1 rad is {Mathf.Rad2Deg} degree");
            print($"PI is {Mathf.PI}");
            Cursor.visible = false;*/

            print(Camera.allCamerasCount);
            print(Application.platform);
            Physics.sleepThreshold = 10;
            Time.timeScale = 0.5f;
            print(Mathf.FloorToInt(9.999f));
            print(Vector3.Magnitude(new Vector3(1, 1, 1) - new Vector3(22, 22, 22)));
            Application.OpenURL("https://unity.com/");
        }
        private void FixedUpdate()
        {
            Physics2D.gravity = new Vector2(Random.Range(-1f , 1f) , Random.Range(-1f, 1f)) * 100;
            print(Input.anyKey);
            print(Time.unscaledTime);
            print(Input.GetKey(KeyCode.Space));
        }
    }
}

