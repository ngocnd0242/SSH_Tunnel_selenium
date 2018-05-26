using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using NLog;
using System.IO;
using System.Threading;
using Renci.SshNet;

namespace SSH_Tunnel_selenium
{
    public partial class Form1 : Form
    {
        private IWebDriver _driver;
        private SshClient _client;

        public Form1()
        {
            InitializeComponent();
        }

        public void getHtml()
        {
            try
            {
                var ffService = FirefoxDriverService.CreateDefaultService(Directory.GetCurrentDirectory(), "geckodriver.exe");
                ffService.HideCommandPromptWindow = true;
                FirefoxOptions ffOptions = new FirefoxOptions();
                _driver = new FirefoxDriver(ffService, ffOptions, TimeSpan.FromSeconds(6));
                _driver.Navigate().GoToUrl(txUrl.Text.Trim());
                textHtml.Text = _driver.PageSource;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _driver.Quit();
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            getHtml();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;

            _client = new SshClient(txip.Text.Trim(), txusername.Text.Trim(), txpwd.Text.Trim());
            _client.Connect();
            ForwardedPortDynamic port = new ForwardedPortDynamic("127.0.0.1", 1080);
            _client.AddForwardedPort(port);
            if (_client.IsConnected)
            {
                port.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            if(_client != null)
            {
                _client.Disconnect();
            }
        }
    }
}
