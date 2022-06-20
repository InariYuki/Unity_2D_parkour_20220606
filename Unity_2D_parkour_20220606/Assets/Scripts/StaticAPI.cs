using UnityEngine;

namespace KitsuneYuki
{
    /// <summary>
    /// 靜態API
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

            print("攝影機數量 = " + Camera.allCamerasCount);
            print("目前平台 = " + Application.platform);
            Physics.sleepThreshold = 10;
            print("睡眠臨界值 = " + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("時間大小 = " + Time.timeScale);
            print("四捨五入的9.999是" + Mathf.Round(9.999f));
            print("無條件捨去的9.999是" + Mathf.Floor(9.999f));
            print("無條件進位的9.999是" + Mathf.Ceil(9.999f));
            print("(1 , 1 , 1)跟(22 , 22 , 22)的距離是" + Vector3.Distance(new Vector3(1, 1, 1) , new Vector3(22, 22, 22)));
            Application.OpenURL("https://unity.com/");
        }
        private void Update()
        {
            Physics2D.gravity = new Vector2(Random.Range(-1f , 1f) , Random.Range(-1f, 1f)) * 100;
            print("按了任意鍵? " + Input.anyKeyDown);
            print("已經過 " + Time.timeSinceLevelLoad + " 秒");
            print("按了空白鍵? " + Input.GetKeyDown(KeyCode.Space));
        }
    }
}

