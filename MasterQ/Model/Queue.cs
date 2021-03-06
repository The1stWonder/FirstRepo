﻿using System;
using Xamarin.Forms.Internals;

namespace MasterQ
{
    [Preserve(AllMembers = true)] //alexpook link all
	public class Queue
	{
		public String branchID { get; set; }
		public int estimateTime { get; set; }
        public DateTime startTime { get; set; }
        public String queueNumber { get; set; }
        public int queueBefore { get; set; }
		public String serviceID { get; set; }
        public String serviceName { get; set; }
		public String tranID { get; set; }
        public String rank { get; set; }
	}
}
