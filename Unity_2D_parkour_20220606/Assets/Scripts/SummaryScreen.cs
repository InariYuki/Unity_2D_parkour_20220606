using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace KitsuneYuki
{
    public class SummaryScreen : MonoBehaviour
    {
        [SerializeField] CanvasGroup canvas;
        [SerializeField] TextMeshProUGUI summary_title;
        [HideInInspector] public string string_title;
        private void Start()
        {
            summary_title.text = string_title;
            InvokeRepeating("fade_in" , 0 , 1f/60f);
        }
        void fade_in()
        {
            canvas.alpha += 1f / 60f;
            if(canvas.alpha >= 1)
            {
                canvas.interactable = true;
                canvas.blocksRaycasts = true;
                CancelInvoke("fade_in");
            }
        }
        public void exit_game()
        {
            print("exit");
            Application.Quit();
        }
        public void restart_game()
        {
            SceneManager.LoadScene(0);
        }
    }
}

