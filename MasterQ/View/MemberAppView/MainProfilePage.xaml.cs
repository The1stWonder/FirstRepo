﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterQ
{
	public partial class MainProfilePage : ContentPage
	{
		bool timercheck = true;
		public MainProfilePage()
		{
			InitializeComponent();

			if (SessionModel.bookingQ != null)
			{
				if (timercheck == true)
				{
                    if (SessionModel.bookingQ.queueNumber != 0)
                    {
                        timerStart();
                    }
				}
			}
		}

		public void timerStart()
		{
			Device.StartTimer(new TimeSpan(0, 0, 1), () =>
				{
                    if (timercheck == true && QueuePage.timercount != 0)
                    {
                        QueuePage.timercount--;
                        QueuePage.timercount.ToString();
                        return true; // runs again, or false to stop
                    }
					else
					{
						return false;
					}
				});
		}

		public void OnImageMainPage(object sender, System.EventArgs args)
		{
			timercheck = false;
			Navigation.PushAsync(new MainPage());
		}

		public void OnImageEditProfilePage(object sender, System.EventArgs args)
		{
			timercheck = false;
			Navigation.PushAsync(new EditProfilePage());
		}

		public void OnImageLogout(object sender, System.EventArgs args)
		{
			timercheck = false;
			Navigation.PushAsync(new LoginPage());
		}
	}
}
