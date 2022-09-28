using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testsignalr.Models;

namespace testsignalr
{
    [HubName("topic")]
    public class topicHub : Hub
    {
        ITIcontext db = new ITIcontext();
        public void add(int top_id ,string top_name)
        {
            Topic t = new Topic() { Top_Id = top_id, Top_Name = top_name };
            db.Topics.Add(t);
            db.SaveChanges();

            Clients.All.newtopic(top_id, top_name);
            
        }
    }
}