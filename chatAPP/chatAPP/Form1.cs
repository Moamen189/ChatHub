using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IHubProxy _proxy;
        private void Form1_Load(object sender, EventArgs e)
        {
            //define connection
            HubConnection con = new HubConnection("http://localhost:51314/");
            //create proxy 

         _proxy=    con.CreateHubProxy("chat");

            //strat connection

            con.Start();

            _proxy.On<string, string>("newmessage", (n, m) => lb_mess.Invoke(new Action(()=>lb_mess.Items.Add(n+":"+m))));
            _proxy.On<string, string>("newmebemer", (n, g) => lb_mess.Invoke(new Action( () => lb_mess.Items.Add(n + " joinned " + g))));
            _proxy.On<string, string, string>("messagegroup", (g, n, m) => lb_mess.Invoke(new Action(() => lb_mess.Items.Add(n + "(" + g + "): " + m))));
        }

        private void btn_sendmessage_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("sendmessage", txt_name.Text, txt_mess.Text);
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("joingroup", txt_group.Text, txt_name.Text);
        }

        private void btn_sendtogroup_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("sendtogroup", txt_group.Text, txt_name.Text, txt_mess.Text);
        }
    }
}
