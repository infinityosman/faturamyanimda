using CefSharp;
using CefSharp.WinForms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturamYanimda
{
    public partial class browserform : MaterialForm
    {
        private ChromiumWebBrowser browser;
        private bool formSubmitted = false;
        public string contractno;

        public browserform()
        {
            InitializeComponent();
            browser = new ChromiumWebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.FrameLoadEnd += Browser_FrameLoadEnd;
            kryptonPanel1.Controls.Add(browser);
            Cef.Initialize(new CefSettings());
        }

        public async void loadpage()
        {
            if (browser == null)
            {
                browser = new ChromiumWebBrowser();
                browser.Dock = DockStyle.Fill;
                browser.FrameLoadEnd += Browser_FrameLoadEnd;
                kryptonPanel1.Controls.Add(browser);
            }
            contractno = connection.billquery.contractno_textbox.Text;
            browser.Load(connection.billquery.sorgulinki);
            formSubmitted = false;

        }

        public async void loadpagefrombill()
        {
            if (browser == null)
            {
                browser = new ChromiumWebBrowser();
                browser.Dock = DockStyle.Fill;
                browser.FrameLoadEnd += Browser_FrameLoadEnd;
                kryptonPanel1.Controls.Add(browser);
            }

            contractno = connection.bills.contractNo;
            browser.Load(connection.bills.sorgulinki);
            formSubmitted = false; 

        }

        private async void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain && !formSubmitted)
            {
                await FillOutForm();
            }
        }

        private async Task FillOutForm()
        {
            await browser.EvaluateScriptAsync("document.querySelector('input[name=\"aboneno1\"]').value = '" + contractno + "'");
            await browser.EvaluateScriptAsync("document.querySelector('input[name=\"kvkk\"]').checked = true");

            formSubmitted = true;
        }

        private void browserform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (browser != null)
            {
                browser.Dispose();
                browser = null;
            }
        }


    }
}
