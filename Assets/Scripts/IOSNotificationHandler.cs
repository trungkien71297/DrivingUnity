using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_IOS
using Unity.Notifications.iOS;
#endif
public class IOSNotificationHandler : MonoBehaviour
{
    private const string ChannelId = "notification_channel";
#if UNITY_IOS
    public void ScheduleNotification(int score)
    {
        iOSNotification notification = new iOSNotification
        {
            Title = "Score",
            Subtitle = "Highest Score",
            Body = "Your score: " + score.ToString(),
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
            CategoryIdentifier = "",
            ThreadIdentifier = "thread1",
            Trigger = new iOSNotificationTimeIntervalTrigger
            {
                TimeInterval = new System.TimeSpan(0, 0, 5),
                Repeats = false
            }           
        };

        iOSNotificationCenter.ScheduleNotification(notification);
    }
#endif
}
