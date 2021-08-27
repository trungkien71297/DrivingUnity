using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private TMP_Text score;
    [SerializeField] private AndroidNotificationHandler androidNotificationHandler;
    [SerializeField] private IOSNotificationHandler iOSNotificationHandler;
    private void Start()
    {
        int highest = PlayerPrefs.GetInt(Score.HIGH_SCORE_KEY, 0);
#if UNITY_ANDROID
        androidNotificationHandler.ScheduleNotification(System.DateTime.Now.AddSeconds(5), highest);
#endif
#if UNITY_IOS
        iOSNotificationHandler.ScheduleNotification(highest);
#endif


        score.text = highest.ToString();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
