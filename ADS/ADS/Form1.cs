using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace ADS
{
    public partial class DisconnecBtn : Form
    {
        private TcAdsClient ads = new TcAdsClient();
        private int hvar; //init variable nadler
        public DisconnecBtn()
        {
           
            InitializeComponent();
        }
        
     
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ads.Connect(netId.Text, Convert.ToInt16(Port.Text));

                if (ads.IsConnected) {
                    MessageBox.Show("Succes");
                    //this.BackColor = Color.Green;
                }else
                    {
                    MessageBox.Show("ERRROR CONNECTING");
                    ads.Disconnect();
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            ads.Disconnect();
            this.BackColor = Color.WhiteSmoke;
        }


        
    }


}
