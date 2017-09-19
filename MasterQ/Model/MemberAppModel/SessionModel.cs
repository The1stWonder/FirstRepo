﻿using System;
using System.Collections.Generic;

namespace MasterQ
{
    public class SessionModel
    {
        public static List<Service> services = new List<Service>();
        public static User loginUser = new User();
        public static Queue bookingQ = new Queue();

        public static Service getService(String serviceID)
        {
            return services.Find(s => s.serviceID.Equals(serviceID));
        }
    }
}
