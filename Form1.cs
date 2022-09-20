using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;
using TwinCAT.Ads.TypeSystem;
using TwinCAT.TypeSystem;

//AdsStream readStream = new AdsStream(sizeof(UInt32));


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TcAdsClient ads = new TcAdsClient();
        private int hvar;
        private int maincouter;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            ads.Connect(Convert.ToInt16(PortBox.Text));

            int notificationHandle = 0;

            

            if (ads.IsConnected)
            {
                MessageBox.Show("Succses");
                try
                {
                    // Notification to a ZDINT Type (UINT32)
                    // Check for change every 200 ms
                    notificationHandle = ads.AddDeviceNotificationEx("MAIN.nCounter", AdsTransMode.OnChange, 200, 0, null, typeof(Int16));
                    Thread.Sleep(5000); // Sleep the main thread to get some (asynchronous Notifications)
                }
                finally
                {
                    // Unregister the Event / Handle
                    ads.DeleteDeviceNotification(notificationHandle);
                    // ads.AdsNotificationEx -= Client_AdsNotification;
                }

                //ADS

            }
            else
            {
                ads.Disconnect();
            }
            checkBoxIsConnected.Checked = ads.IsConnected;

            hvar        = ads.CreateVariableHandle("MAIN.xboolTest");
            maincouter  = ads.CreateVariableHandle("MAIN.dcounter");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ads.WriteAny(hvar, true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ads.WriteAny(hvar, false);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
              // ads.WriteAny(maincouter, Convert.ToInt16(textBox3.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           
        }
        private void Client_AdsNotification(object sender, AdsNotificationExEventArgs e)
        {
            // Or here we know about UDINT type --> can be marshalled as UINT32
            //uint nCounter = (uint)e.Value;
            textBox3.Text = Convert.ToString(e);
        }
    }
}
