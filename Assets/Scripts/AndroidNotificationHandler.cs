using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#endif
using UnityEngine;
public class AndroidNotificationHandler : MonoBehaviour
{

    private const string ChannelId = "notification_channel";
#if UNITY_ANDROID
    public void ScheduleNotification(DateTime dateTime, int score)
    {
        AndroidNotificationChannel channel = new AndroidNotificationChannel
        {
            Id = ChannelId,
            Name = "Notification Channel",
            Description = "Description",
            Importance = Importance.Default
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        AndroidNotification notification = new AndroidNotification
        {
            Title = "Score",
            Text = "Your score: " + score.ToString(),
            SmallIcon = "default",
            LargeIcon = "default",
            FireTime = dateTime
        };

        AndroidNotificationCenter.SendNotification(notification, ChannelId);
    }
#endif

}
