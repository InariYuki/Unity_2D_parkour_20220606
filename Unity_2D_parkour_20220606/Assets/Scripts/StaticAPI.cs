using UnityEngine;

namespace KitsuneYuki
{
    /// <summary>
    /// �R�AAPI
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

            print("��v���ƶq = " + Camera.allCamerasCount);
            print("�ثe���x = " + Application.platform);
            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭ� = " + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("�ɶ��j�p = " + Time.timeScale);
            print("�|�ˤ��J��9.999�O" + Mathf.Round(9.999f));
            print("�L����˥h��9.999�O" + Mathf.Floor(9.999f));
            print("�L����i�쪺9.999�O" + Mathf.Ceil(9.999f));
            print("(1 , 1 , 1)��(22 , 22 , 22)���Z���O" + Vector3.Distance(new Vector3(1, 1, 1) , new Vector3(22, 22, 22)));
            Application.OpenURL("https://unity.com/");
        }
        private void Update()
        {
            Physics2D.gravity = new Vector2(Random.Range(-1f , 1f) , Random.Range(-1f, 1f)) * 100;
            print("���F���N��? " + Input.anyKeyDown);
            print("�w�g�L " + Time.timeSinceLevelLoad + " ��");
            print("���F�ť���? " + Input.GetKeyDown(KeyCode.Space));
        }
    }
}

